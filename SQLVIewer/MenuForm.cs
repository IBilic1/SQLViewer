using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLVIewer
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnClick(object sender, EventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case nameof(BtnSQLViewer):
                    new MainForm().Show();
                    break;
                case nameof(BtnSSMS):
                    new SSMS().Show();
                    break;
                default:
                    throw new Exception("There is no such button.");
            }
            Hide();
        }
    }
}
