using ivs.system;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dpanel_Management_System.Forms
{
    public partial class Mdi : Form
    {
        public Mdi()
        {
            InitializeComponent();
        }

        private void Mdi_Load(object sender, EventArgs e)
        {
            Sample s = new Sample();
            Mainclass.showWindow(s, this);
        }
    }
}
