namespace Dpanel_Management_System
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Logo = new System.Windows.Forms.Label();
            this.StartdatePicker = new System.Windows.Forms.DateTimePicker();
            this.enddatePicker = new System.Windows.Forms.DateTimePicker();
            this.CustomDateBtn = new System.Windows.Forms.Button();
            this.MonthBtn = new System.Windows.Forms.Button();
            this.last30DaysBtn = new System.Windows.Forms.Button();
            this.Last7DaysBtn = new System.Windows.Forms.Button();
            this.TodayDateBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.OrderLblTxt = new System.Windows.Forms.Label();
            this.ordersLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.revenusLblTxt = new System.Windows.Forms.Label();
            this.RevenusLbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.profitLblTxt = new System.Windows.Forms.Label();
            this.profitLbl = new System.Windows.Forms.Label();
            this.chartGrossRevenus = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTop5Products = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.productLblTxt = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.StaffLblTxt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerLblTxt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.DGVunderStockList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.OkBtn = new FontAwesome.Sharp.IconButton();
            this.StartdatePickerLbl = new System.Windows.Forms.Label();
            this.enddatePickerLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5Products)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVunderStockList)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.AutoSize = true;
            this.Logo.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold);
            this.Logo.ForeColor = System.Drawing.Color.White;
            this.Logo.Location = new System.Drawing.Point(12, 23);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(106, 30);
            this.Logo.TabIndex = 0;
            this.Logo.Text = "Analisyst";
            // 
            // StartdatePicker
            // 
            this.StartdatePicker.CustomFormat = "yyy-MMM-dd";
            this.StartdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartdatePicker.Location = new System.Drawing.Point(198, 31);
            this.StartdatePicker.Name = "StartdatePicker";
            this.StartdatePicker.Size = new System.Drawing.Size(91, 22);
            this.StartdatePicker.TabIndex = 1;
            this.StartdatePicker.ValueChanged += new System.EventHandler(this.StartdatePicker_ValueChanged);
            // 
            // enddatePicker
            // 
            this.enddatePicker.CustomFormat = "yyy-MMM-dd";
            this.enddatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.enddatePicker.Location = new System.Drawing.Point(330, 31);
            this.enddatePicker.Name = "enddatePicker";
            this.enddatePicker.Size = new System.Drawing.Size(91, 22);
            this.enddatePicker.TabIndex = 2;
            this.enddatePicker.ValueChanged += new System.EventHandler(this.enddatePicker_ValueChanged);
            // 
            // CustomDateBtn
            // 
            this.CustomDateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomDateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.CustomDateBtn.FlatAppearance.BorderSize = 2;
            this.CustomDateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.CustomDateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CustomDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomDateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomDateBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.CustomDateBtn.Location = new System.Drawing.Point(534, 30);
            this.CustomDateBtn.Name = "CustomDateBtn";
            this.CustomDateBtn.Size = new System.Drawing.Size(80, 27);
            this.CustomDateBtn.TabIndex = 3;
            this.CustomDateBtn.Text = "Custom";
            this.CustomDateBtn.UseVisualStyleBackColor = true;
            this.CustomDateBtn.Click += new System.EventHandler(this.CustomDateBtn_Click);
            // 
            // MonthBtn
            // 
            this.MonthBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MonthBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.MonthBtn.FlatAppearance.BorderSize = 2;
            this.MonthBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.MonthBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.MonthBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MonthBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MonthBtn.Location = new System.Drawing.Point(874, 30);
            this.MonthBtn.Name = "MonthBtn";
            this.MonthBtn.Size = new System.Drawing.Size(80, 27);
            this.MonthBtn.TabIndex = 4;
            this.MonthBtn.Text = "This month";
            this.MonthBtn.UseVisualStyleBackColor = true;
            this.MonthBtn.Click += new System.EventHandler(this.MonthBtn_Click);
            // 
            // last30DaysBtn
            // 
            this.last30DaysBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.last30DaysBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.last30DaysBtn.FlatAppearance.BorderSize = 2;
            this.last30DaysBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.last30DaysBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.last30DaysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.last30DaysBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last30DaysBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.last30DaysBtn.Location = new System.Drawing.Point(788, 30);
            this.last30DaysBtn.Name = "last30DaysBtn";
            this.last30DaysBtn.Size = new System.Drawing.Size(80, 27);
            this.last30DaysBtn.TabIndex = 5;
            this.last30DaysBtn.Text = "last 30 days";
            this.last30DaysBtn.UseVisualStyleBackColor = true;
            this.last30DaysBtn.Click += new System.EventHandler(this.last30DaysBtn_Click);
            // 
            // Last7DaysBtn
            // 
            this.Last7DaysBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Last7DaysBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.Last7DaysBtn.FlatAppearance.BorderSize = 2;
            this.Last7DaysBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.Last7DaysBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.Last7DaysBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Last7DaysBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Last7DaysBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Last7DaysBtn.Location = new System.Drawing.Point(704, 30);
            this.Last7DaysBtn.Name = "Last7DaysBtn";
            this.Last7DaysBtn.Size = new System.Drawing.Size(80, 27);
            this.Last7DaysBtn.TabIndex = 6;
            this.Last7DaysBtn.Text = "last 7 days";
            this.Last7DaysBtn.UseVisualStyleBackColor = true;
            this.Last7DaysBtn.Click += new System.EventHandler(this.Last7DaysBtn_Click);
            // 
            // TodayDateBtn
            // 
            this.TodayDateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TodayDateBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(120)))), ((int)(((byte)(177)))));
            this.TodayDateBtn.FlatAppearance.BorderSize = 2;
            this.TodayDateBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.TodayDateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.TodayDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TodayDateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayDateBtn.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TodayDateBtn.Location = new System.Drawing.Point(617, 30);
            this.TodayDateBtn.Name = "TodayDateBtn";
            this.TodayDateBtn.Size = new System.Drawing.Size(80, 27);
            this.TodayDateBtn.TabIndex = 7;
            this.TodayDateBtn.Text = "Today";
            this.TodayDateBtn.UseVisualStyleBackColor = true;
            this.TodayDateBtn.Click += new System.EventHandler(this.TodayDateBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.OrderLblTxt);
            this.panel1.Controls.Add(this.ordersLbl);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 74);
            this.panel1.TabIndex = 9;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CubesStacked;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(17, 18);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(49, 54);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // OrderLblTxt
            // 
            this.OrderLblTxt.AutoSize = true;
            this.OrderLblTxt.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.OrderLblTxt.ForeColor = System.Drawing.Color.White;
            this.OrderLblTxt.Location = new System.Drawing.Point(77, 32);
            this.OrderLblTxt.Name = "OrderLblTxt";
            this.OrderLblTxt.Size = new System.Drawing.Size(70, 23);
            this.OrderLblTxt.TabIndex = 1;
            this.OrderLblTxt.Text = "100000";
            // 
            // ordersLbl
            // 
            this.ordersLbl.AutoSize = true;
            this.ordersLbl.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.ordersLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ordersLbl.Location = new System.Drawing.Point(14, -3);
            this.ordersLbl.Name = "ordersLbl";
            this.ordersLbl.Size = new System.Drawing.Size(121, 17);
            this.ordersLbl.TabIndex = 0;
            this.ordersLbl.Text = "Numbers of orders";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.iconButton2);
            this.panel2.Controls.Add(this.revenusLblTxt);
            this.panel2.Controls.Add(this.RevenusLbl);
            this.panel2.Location = new System.Drawing.Point(193, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 74);
            this.panel2.TabIndex = 10;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Rupee;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(9, 17);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(49, 54);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // revenusLblTxt
            // 
            this.revenusLblTxt.AutoSize = true;
            this.revenusLblTxt.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.revenusLblTxt.ForeColor = System.Drawing.Color.White;
            this.revenusLblTxt.Location = new System.Drawing.Point(80, 32);
            this.revenusLblTxt.Name = "revenusLblTxt";
            this.revenusLblTxt.Size = new System.Drawing.Size(70, 23);
            this.revenusLblTxt.TabIndex = 1;
            this.revenusLblTxt.Text = "100000";
            // 
            // RevenusLbl
            // 
            this.RevenusLbl.AutoSize = true;
            this.RevenusLbl.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.RevenusLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.RevenusLbl.Location = new System.Drawing.Point(14, -3);
            this.RevenusLbl.Name = "RevenusLbl";
            this.RevenusLbl.Size = new System.Drawing.Size(88, 17);
            this.RevenusLbl.TabIndex = 0;
            this.RevenusLbl.Text = "Total Revenus";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel3.Controls.Add(this.iconButton3);
            this.panel3.Controls.Add(this.profitLblTxt);
            this.panel3.Controls.Add(this.profitLbl);
            this.panel3.Location = new System.Drawing.Point(380, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(384, 74);
            this.panel3.TabIndex = 10;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(17, 21);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(49, 54);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // profitLblTxt
            // 
            this.profitLblTxt.AutoSize = true;
            this.profitLblTxt.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.profitLblTxt.ForeColor = System.Drawing.Color.White;
            this.profitLblTxt.Location = new System.Drawing.Point(93, 31);
            this.profitLblTxt.Name = "profitLblTxt";
            this.profitLblTxt.Size = new System.Drawing.Size(70, 23);
            this.profitLblTxt.TabIndex = 1;
            this.profitLblTxt.Text = "100000";
            // 
            // profitLbl
            // 
            this.profitLbl.AutoSize = true;
            this.profitLbl.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.profitLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.profitLbl.Location = new System.Drawing.Point(14, -3);
            this.profitLbl.Name = "profitLbl";
            this.profitLbl.Size = new System.Drawing.Size(72, 17);
            this.profitLbl.TabIndex = 0;
            this.profitLbl.Text = "Total profit";
            // 
            // chartGrossRevenus
            // 
            this.chartGrossRevenus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlDark;
            chartArea3.AxisX.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.LineWidth = 0;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea3.AxisX.MajorGrid.LineWidth = 0;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            chartArea3.AxisX.MajorTickMark.LineWidth = 5;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.SystemColors.ControlDark;
            chartArea3.AxisY.LabelStyle.Format = "{0:0,}k";
            chartArea3.AxisY.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisY.LineWidth = 0;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea3.Name = "ChartArea1";
            this.chartGrossRevenus.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend3.ForeColor = System.Drawing.SystemColors.ControlDark;
            legend3.Name = "Legend1";
            this.chartGrossRevenus.Legends.Add(legend3);
            this.chartGrossRevenus.Location = new System.Drawing.Point(3, 162);
            this.chartGrossRevenus.Name = "chartGrossRevenus";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            series3.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(42)))), ((int)(((byte)(220)))));
            series3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(127)))));
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(127)))));
            series3.Legend = "Legend1";
            series3.MarkerStep = 10;
            series3.Name = "Series1";
            this.chartGrossRevenus.Series.Add(series3);
            this.chartGrossRevenus.Size = new System.Drawing.Size(694, 259);
            this.chartGrossRevenus.TabIndex = 11;
            this.chartGrossRevenus.Text = "chart1";
            title3.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title3.ForeColor = System.Drawing.Color.WhiteSmoke;
            title3.Name = "Title1";
            title3.Text = "Gross Revenus";
            this.chartGrossRevenus.Titles.Add(title3);
            // 
            // chartTop5Products
            // 
            this.chartTop5Products.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            chartArea4.BorderColor = System.Drawing.Color.Empty;
            chartArea4.BorderWidth = 5;
            chartArea4.Name = "ChartArea1";
            this.chartTop5Products.ChartAreas.Add(chartArea4);
            legend4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.ForeColor = System.Drawing.SystemColors.ControlDark;
            legend4.Name = "Legend1";
            this.chartTop5Products.Legends.Add(legend4);
            this.chartTop5Products.Location = new System.Drawing.Point(732, 162);
            this.chartTop5Products.Name = "chartTop5Products";
            this.chartTop5Products.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            series4.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(11)))), ((int)(((byte)(116)))));
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            series4.BorderWidth = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(20)))), ((int)(((byte)(127)))));
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            series4.IsValueShownAsLabel = true;
            series4.LabelForeColor = System.Drawing.Color.WhiteSmoke;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            series4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series4.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(24)))), ((int)(((byte)(111)))));
            this.chartTop5Products.Series.Add(series4);
            this.chartTop5Products.Size = new System.Drawing.Size(320, 462);
            this.chartTop5Products.TabIndex = 12;
            this.chartTop5Products.Text = "chart2";
            title4.Alignment = System.Drawing.ContentAlignment.TopLeft;
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            title4.ForeColor = System.Drawing.Color.WhiteSmoke;
            title4.Name = "Title1";
            title4.Text = "Top 5 products";
            this.chartTop5Products.Titles.Add(title4);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel4.Controls.Add(this.iconButton6);
            this.panel4.Controls.Add(this.iconButton4);
            this.panel4.Controls.Add(this.iconButton5);
            this.panel4.Controls.Add(this.productLblTxt);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.StaffLblTxt);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.customerLblTxt);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(17, 433);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(204, 192);
            this.panel4.TabIndex = 13;
            // 
            // iconButton6
            // 
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.ForeColor = System.Drawing.Color.White;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Fan;
            this.iconButton6.IconColor = System.Drawing.Color.White;
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton6.IconSize = 40;
            this.iconButton6.Location = new System.Drawing.Point(2, 130);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Size = new System.Drawing.Size(56, 50);
            this.iconButton6.TabIndex = 10;
            this.iconButton6.UseVisualStyleBackColor = true;
            // 
            // iconButton4
            // 
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 40;
            this.iconButton4.Location = new System.Drawing.Point(3, 79);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(56, 50);
            this.iconButton4.TabIndex = 9;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.PersonShelter;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 40;
            this.iconButton5.Location = new System.Drawing.Point(3, 27);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(56, 50);
            this.iconButton5.TabIndex = 8;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // productLblTxt
            // 
            this.productLblTxt.AutoSize = true;
            this.productLblTxt.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.productLblTxt.ForeColor = System.Drawing.Color.White;
            this.productLblTxt.Location = new System.Drawing.Point(95, 157);
            this.productLblTxt.Name = "productLblTxt";
            this.productLblTxt.Size = new System.Drawing.Size(70, 23);
            this.productLblTxt.TabIndex = 6;
            this.productLblTxt.Text = "100000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(96, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total Products";
            // 
            // StaffLblTxt
            // 
            this.StaffLblTxt.AutoSize = true;
            this.StaffLblTxt.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.StaffLblTxt.ForeColor = System.Drawing.Color.White;
            this.StaffLblTxt.Location = new System.Drawing.Point(95, 97);
            this.StaffLblTxt.Name = "StaffLblTxt";
            this.StaffLblTxt.Size = new System.Drawing.Size(70, 23);
            this.StaffLblTxt.TabIndex = 4;
            this.StaffLblTxt.Text = "100000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(96, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Staff";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, -3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Counter";
            // 
            // customerLblTxt
            // 
            this.customerLblTxt.AutoSize = true;
            this.customerLblTxt.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold);
            this.customerLblTxt.ForeColor = System.Drawing.Color.White;
            this.customerLblTxt.Location = new System.Drawing.Point(95, 44);
            this.customerLblTxt.Name = "customerLblTxt";
            this.customerLblTxt.Size = new System.Drawing.Size(70, 23);
            this.customerLblTxt.TabIndex = 1;
            this.customerLblTxt.Text = "100000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(96, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total customer";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.panel5.Controls.Add(this.DGVunderStockList);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(241, 432);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(456, 192);
            this.panel5.TabIndex = 14;
            // 
            // DGVunderStockList
            // 
            this.DGVunderStockList.AllowUserToResizeColumns = false;
            this.DGVunderStockList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVunderStockList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            this.DGVunderStockList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVunderStockList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVunderStockList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(120)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVunderStockList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGVunderStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVunderStockList.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGVunderStockList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVunderStockList.EnableHeadersVisualStyles = false;
            this.DGVunderStockList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(25)))), ((int)(((byte)(148)))));
            this.DGVunderStockList.Location = new System.Drawing.Point(0, 20);
            this.DGVunderStockList.Name = "DGVunderStockList";
            this.DGVunderStockList.RowHeadersVisible = false;
            this.DGVunderStockList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVunderStockList.Size = new System.Drawing.Size(456, 172);
            this.DGVunderStockList.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Under Stock list";
            // 
            // OkBtn
            // 
            this.OkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(80)))), ((int)(((byte)(114)))));
            this.OkBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OkBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(165)))), ((int)(((byte)(226)))));
            this.OkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OkBtn.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.OkBtn.IconColor = System.Drawing.Color.White;
            this.OkBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OkBtn.IconSize = 20;
            this.OkBtn.Location = new System.Drawing.Point(499, 32);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(29, 23);
            this.OkBtn.TabIndex = 15;
            this.OkBtn.UseVisualStyleBackColor = false;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // StartdatePickerLbl
            // 
            this.StartdatePickerLbl.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.StartdatePickerLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.StartdatePickerLbl.Location = new System.Drawing.Point(198, 31);
            this.StartdatePickerLbl.Name = "StartdatePickerLbl";
            this.StartdatePickerLbl.Size = new System.Drawing.Size(91, 22);
            this.StartdatePickerLbl.TabIndex = 2;
            this.StartdatePickerLbl.Text = "12/04/2016";
            this.StartdatePickerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StartdatePickerLbl.Click += new System.EventHandler(this.StartdatePickerLbl_Click);
            // 
            // enddatePickerLbl
            // 
            this.enddatePickerLbl.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.enddatePickerLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.enddatePickerLbl.Location = new System.Drawing.Point(330, 30);
            this.enddatePickerLbl.Name = "enddatePickerLbl";
            this.enddatePickerLbl.Size = new System.Drawing.Size(91, 22);
            this.enddatePickerLbl.TabIndex = 16;
            this.enddatePickerLbl.Text = "12/04-2016";
            this.enddatePickerLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.enddatePickerLbl.Click += new System.EventHandler(this.enddatePickerLbl_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Cross;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(303, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "-";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1090, 659);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.enddatePickerLbl);
            this.Controls.Add(this.StartdatePickerLbl);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.chartTop5Products);
            this.Controls.Add(this.chartGrossRevenus);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TodayDateBtn);
            this.Controls.Add(this.Last7DaysBtn);
            this.Controls.Add(this.last30DaysBtn);
            this.Controls.Add(this.MonthBtn);
            this.Controls.Add(this.CustomDateBtn);
            this.Controls.Add(this.enddatePicker);
            this.Controls.Add(this.StartdatePicker);
            this.Controls.Add(this.Logo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrossRevenus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTop5Products)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVunderStockList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Logo;
        private System.Windows.Forms.DateTimePicker StartdatePicker;
        private System.Windows.Forms.DateTimePicker enddatePicker;
        private System.Windows.Forms.Button CustomDateBtn;
        private System.Windows.Forms.Button MonthBtn;
        private System.Windows.Forms.Button last30DaysBtn;
        private System.Windows.Forms.Button Last7DaysBtn;
        private System.Windows.Forms.Button TodayDateBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OrderLblTxt;
        private System.Windows.Forms.Label ordersLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label revenusLblTxt;
        private System.Windows.Forms.Label RevenusLbl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label profitLblTxt;
        private System.Windows.Forms.Label profitLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrossRevenus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTop5Products;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label customerLblTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label productLblTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label StaffLblTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView DGVunderStockList;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton OkBtn;
        private System.Windows.Forms.Label StartdatePickerLbl;
        private System.Windows.Forms.Label enddatePickerLbl;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton6;
        private FontAwesome.Sharp.IconButton iconButton4;
    }
}

