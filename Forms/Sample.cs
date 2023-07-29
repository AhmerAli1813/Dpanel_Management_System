using ivs.system;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Dpanel_Management_System.Forms
{
    public partial class Sample : Form
    {

        public Color backColor { get; set; }
        public Color foreColor { get; set; }
        public int Themes { get; set; }

        public void BodyThemes(Color backcolor, Color forecolor, int Theme)
        {
            this.backColor = backcolor;
            this.foreColor = forecolor;
            this.Themes = Theme;
        }

        public Sample()
        {
           
            InitializeComponent();
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            Dashborad win = new Dashborad();
            Mainclass.showWindow(win, this, MDI.ActiveForm);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void SerachTxtBoxLbl_Click(object sender, EventArgs e)
        {
            SerachTxtBox.Select();

        }
        
        private void SerachTxtBox_TextChanged(object sender, EventArgs e)
        {
            
            if (SerachTxtBox.Text == null)
            {
                
                SerachTxtBoxLbl.Text ="Serach here..." ;
            }
            else
            {
                SerachTxtBoxLbl.Text = SerachTxtBox.Text;
            }
        }


        private void AnalaisysBtn_Click(object sender, EventArgs e)
        {

            Analaisys win = new Analaisys();
            Mainclass.showWindow(win, this, MDI.ActiveForm);
        }
    }
}
