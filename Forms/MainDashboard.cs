using Dpanel_Management_System.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dpanel_Management_System
{
    public partial class Dashboard : Form
    {
        private Model.Dashboard model;
        private Button currentBtn ;
        public Dashboard()
        {
            InitializeComponent();
            //Defualt 7 Days
            
            model = new Model.Dashboard();
            

        }

        private void loadData()
        {
            var refreshData = model.LoadData(StartdatePicker.Value, enddatePicker.Value);

            if (refreshData == true)
            {
                OrderLblTxt.Text = model.numOrders.ToString();
                productLblTxt.Text = model.numProducts.ToString();
                revenusLblTxt.Text = model.TotalRevenue.ToString();
                profitLblTxt.Text = model.TotalProfit.ToString();
                customerLblTxt.Text = model.numCoustomers.ToString();
                StaffLblTxt.Text = model.numStaffs.ToString();
                productLblTxt.Text = model.numProducts.ToString();

                chartGrossRevenus.DataSource = model.GrossRevenueList;
                chartGrossRevenus.Series[0].XValueMember = "Date";
                chartGrossRevenus.Series[0].YValueMembers = "TotalAmount";
                chartGrossRevenus.DataBind();


                chartTop5Products.DataSource = model.TopProductsList;
                chartTop5Products.Series[0].XValueMember = "key";
                chartTop5Products.Series[0].YValueMembers = "Value";
                chartTop5Products.DataBind();

                DGVunderStockList.DataSource = model.UnderStockList;
                DGVunderStockList.Columns[0].HeaderText = "Items";
                DGVunderStockList.Columns[1].HeaderText = "unit";
                Console.WriteLine("loaded view :)");

            }
            else
            {
                Console.WriteLine("View not loaded , Same qurey :(");
            }
        }


        private void MainDashboard_Load(object sender, EventArgs e)
        {
            SetDateMenuBtnsUI(Last7DaysBtn);
            StartdatePicker.Value = DateTime.Today.AddDays(-7);
            enddatePicker.Value = DateTime.Now;
            Last7DaysBtn.Select();
            loadData();

        }
        private void TodayDateBtn_Click(object sender, EventArgs e)
        {
            loadData();
            SetDateMenuBtnsUI(sender);
        }

        private void SetDateMenuBtnsUI(object button)
        {
            var btn = (Button)button;
            btn.BackColor = last30DaysBtn.FlatAppearance.BorderColor;
            btn.ForeColor = Color.White;
            if (currentBtn != null && currentBtn != btn)
            {
                currentBtn.BackColor = this.BackColor;
                currentBtn.ForeColor = Color.FromArgb(124, 141, 181);
            }
            currentBtn = btn;
            if (currentBtn == CustomDateBtn)
            {
                StartdatePicker.Enabled = true;
                enddatePicker.Enabled = true;
                OkBtn.Visible = true;
                OkBtn.Enabled = true;
                StartdatePickerLbl.Cursor = Cursors.Hand;
                enddatePickerLbl.Cursor = Cursors.Hand;
            }
            else
            {
                StartdatePicker.Enabled = false;
                enddatePicker.Enabled = false;
                OkBtn.Visible = false;
                StartdatePickerLbl.Cursor = Cursors.No;
                enddatePickerLbl.Cursor = Cursors.No;
            }
            
        }

        private void CustomDateBtn_Click(object sender, EventArgs e)
        {

            OkBtn.Visible = true;
            OkBtn.Enabled = true;
            SetDateMenuBtnsUI(sender);
        }


        private void Last7DaysBtn_Click(object sender, EventArgs e)
        {

            StartdatePicker.Value = DateTime.Today.AddDays(-7);
            enddatePicker.Value = DateTime.Now;
            loadData();
            SetDateMenuBtnsUI(sender);
        }

        private void last30DaysBtn_Click(object sender, EventArgs e)
        {

            StartdatePicker.Value = new DateTime(DateTime.Today.Year,DateTime.Today.Month,1);
            enddatePicker.Value = DateTime.Now;
            loadData();
            SetDateMenuBtnsUI(sender);
        }

        private void MonthBtn_Click(object sender, EventArgs e)
        {

            StartdatePicker.Value = DateTime.Today.AddDays(-30);
            enddatePicker.Value = DateTime.Now;
            loadData();
            SetDateMenuBtnsUI(sender);
        }

        private void StartdatePickerLbl_Click(object sender, EventArgs e)
        {
            if (currentBtn == CustomDateBtn)
            {
                StartdatePicker.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void enddatePickerLbl_Click(object sender, EventArgs e)
        {
            {
            if (currentBtn == CustomDateBtn)
                enddatePicker.Select();
                SendKeys.Send("%{DOWN}");
            }
        }

        private void StartdatePicker_ValueChanged(object sender, EventArgs e)
        {
            StartdatePickerLbl.Text = StartdatePicker.Text;
        }

        private void enddatePicker_ValueChanged(object sender, EventArgs e)
        {
            enddatePickerLbl.Text = enddatePicker.Text;
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
