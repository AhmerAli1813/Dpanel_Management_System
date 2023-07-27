using ivs.system;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Dpanel_Management_System.Forms
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Dashboard d = new Dashboard();
            Mainclass.showWindow(d, MainForm.ActiveForm);
        }
    }
}
