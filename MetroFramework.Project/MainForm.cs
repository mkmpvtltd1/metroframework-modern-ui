using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace MetroFramework.Project
{
    public partial class MainForm : MetroForm
    {
        private bool isLogin = false;
        public MainForm()
        {
            InitializeComponent();

        }

        private void metroPanel1_Resize(object sender, EventArgs e)
        {
            if (!isLogin)
            {
                LoadLoginControl();
            }
        }

        private void LoadLoginControl()
        {
            Login login = new Login();
            pnlMain.Controls.Clear();
            login.Location = new Point((pnlMain.Width - login.Width) / 2, (pnlMain.Height - login.Height) / 2);
            pnlMain.Controls.Add(login);
        }
    }
}
