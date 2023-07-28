using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ivs.system
{
    class  Mainclass
    {
        // Message box is function (method) created
        public static DialogResult showMsg(string msg , string heading , string type)
        {
            if(type == "success")
            {
               return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (type == "Error")
            {
               return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               return MessageBox.Show(msg, heading, MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }
        public static void showWindow(Form openWin, Form closeWin, Form MdIWin)
        {
            closeWin.Close();
            openWin.MdiParent = MdIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
        public static void showWindow(Form openWin, Form MdIWin)
        {
            openWin.MdiParent = MdIWin;
            openWin.WindowState = FormWindowState.Maximized;
            openWin.Show();
        }
        

    }
}
