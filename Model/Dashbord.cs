using Dpanel_Management_System.Db;
using ivs.system;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dpanel_Management_System.Model
{
    public struct RevenuebyDate
    {
        public string Date { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class Dashboard : DbConnection
    {
        //Fields And Properties
        private DateTime startDate;
        private DateTime endDate;
        private int numberDays;
        public int numCoustomers { get; private set; }
        public int numSuppliers { get; private set; }
        public int numStaffs { get; private set; }
        public int numProducts { get; private set; }
        public List<KeyValuePair<int, int>> TopProductsList { get; private set; }
        public List<KeyValuePair<string, int>> UnderStockList { get; private set; }
        public List<RevenuebyDate> GrossRevenueList { get; private set; }
        public int numOrders { get; private set; }
        public decimal TotalRevenue { get; private set; }
        public decimal TotalProfit { get; private set; }

        public Dashboard()
        {

        }
        //Private Methods
        private void GetNumbersItems()
        {
            using (var connection = GetConnection() )
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //get total numbers of Coustomer
                    command.CommandText = @"select count(customer_id) from sales.customers";
                    numCoustomers = (int)command.ExecuteScalar();

                    //get total numbers of orders
                    command.CommandText = @"select count(order_id) from sales.orders";
                    numOrders = (int)command.ExecuteScalar();

                    //get total numbers of Staffs
                    command.CommandText = @"select count(staff_id) from sales.staffs";
                    numStaffs = (int)command.ExecuteScalar();

                    //get total numbers of products
                    command.CommandText = @"select count(product_id) from production.products";
                    numProducts = (int)command.ExecuteScalar();

                    //get total numbers of orders by Date
                    SqlCommand cmd = new SqlCommand("st_OrderCountBWDate", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                    numOrders = (int)cmd.ExecuteScalar();
                }
            }
        }
        private void GetOrderAnalisys()
        {
            GrossRevenueList = new List<RevenuebyDate>();
            TotalProfit = 0;
            TotalRevenue = 0;
            using (var connection = GetConnection() )
            {
                connection.Open();
                SqlDataReader reader;
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //
                    SqlCommand cmd = new SqlCommand("st_OrderSumPrizeWTHDate", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@startDate", startDate);
                    cmd.Parameters.AddWithValue("@endDate", endDate);
                     reader = cmd.ExecuteReader();
                    var tableResult = new List<KeyValuePair<DateTime, decimal>>();

                    while (reader.Read())
                    {
                        tableResult.Add(
                            new KeyValuePair<DateTime, decimal>((DateTime)reader[0], (decimal)reader[1])
                                );
                        TotalRevenue += (decimal)reader[1];
                    }
                    TotalProfit = TotalRevenue * 0.2m;
                    reader.Close();

                    //group by days
                    if (numberDays <= 30)
                    {
                        foreach (var item in tableResult)
                        {
                            GrossRevenueList.Add(new RevenuebyDate()
                            {

                                Date = item.Key.ToString("dd-MMM"),
                                TotalAmount = item.Value

                            });


                        }
                        //group by week
                    }
                    else if (numberDays <= 92)
                    {
                        GrossRevenueList = (from orderList in tableResult
                                            group orderList by CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                                orderList.Key, CalendarWeekRule.FirstDay, DayOfWeek.Monday
                                                ) into OrdersDD
                                            select new RevenuebyDate
                                            {
                                                Date = "Week" + OrdersDD.Key.ToString(),
                                                TotalAmount = OrdersDD.Sum(amount => amount.Value)
                                            }
                            ).ToList();
                    }
                    // group by month
                    else if (numberDays <= (365 * 2))
                    {
                        bool IsYear = numberDays <= 365 ? true : false;
                        GrossRevenueList = (from orderList in tableResult
                                            group orderList by orderList.Key.ToString("MMM-YYYY")
                                            into OrdersDD
                                            select new RevenuebyDate
                                            {
                                                Date = IsYear ? OrdersDD.Key.Substring(0, OrdersDD.Key.IndexOf("")) : OrdersDD.Key,
                                                TotalAmount = OrdersDD.Sum(amount => amount.Value)
                                            }
                                            ).ToList();
                    }
                    else
                    {

                        GrossRevenueList = (from orderList in tableResult
                                            group orderList by orderList.Key.ToString("YYYY")
                                            into OrdersDD
                                            select new RevenuebyDate
                                            {
                                                Date = OrdersDD.Key,
                                                TotalAmount = OrdersDD.Sum(amount => amount.Value)
                                            }
                                            ).ToList();
                    }
                }
            }
        }
        private void GetProductAnalisys()
        {
            TopProductsList = new List<KeyValuePair<int, int>>();
            UnderStockList = new List<KeyValuePair<string, int>>();
            using (var connection = GetConnection() )
            {
                connection.Open();
                SqlDataReader reader;
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    //get top 5 sale products 

                    command.CommandText = @"select  top 5 sum(oi.quantity) as Q  ,product_id from sales.order_items as oi
                                                join sales.orders as o on oi.order_id = o.order_id
                                                where o.order_date between @startDate and @endDate
                                                group by product_id
                                                order by Q desc";
                    command.Parameters.Add("@startDate", SqlDbType.DateTime).Value = startDate;
                    command.Parameters.Add("@endDate", SqlDbType.DateTime).Value = endDate;
                    reader = command.ExecuteReader();   

                    while (reader.Read())
                    {
                        TopProductsList.Add(
                            new KeyValuePair<int, int>((int)reader[0], (int)reader[1])
                            );
                    }
                    reader.Close();

                    //Get Stock 
                    command.CommandText = @"select  p.product_name , s.quantity from production.stocks as s
                                            join production.products as p on s.product_id = p.product_id
                                            where s.quantity >=10 order by s.quantity desc ";
                       reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        UnderStockList.Add(
                           new KeyValuePair<string, int>(reader[0].ToString(), (int)reader[1])
                           );
                    }
                    reader.Close();
                }
            }
        }

        public bool LoadData(DateTime _StartDate , DateTime _EndDate  )
        {
            _EndDate = new DateTime(_EndDate.Year, _EndDate.Month, _EndDate.Day,
                _EndDate.Hour, _EndDate.Minute, 59);
            if(_EndDate!=this.endDate|| _StartDate != this.startDate)
            {

                this.startDate = _StartDate;
                this.endDate = _EndDate;
                this.numberDays = (_EndDate - _StartDate).Days;

                GetNumbersItems();
                GetProductAnalisys();
                GetOrderAnalisys();
                Console.WriteLine("date is Refeached :), {0} - {1}", _StartDate.ToString(), _EndDate.ToString());
                return true;
            }else
            {
                Console.WriteLine("date is not Refeached :(, {0} - {1}", _StartDate.ToString(), _EndDate.ToString());
                return false;
            }
        }
    }
}
