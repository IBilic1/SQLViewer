using SQLVIewer.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer.DAL;

namespace SQLVIewer
{
    public partial class LoginForm : Form
    {
        private static IDictionary<Control, Control> validationFields;
        public LoginForm()
        {
            InitializeComponent();
            initValidation();
        }

        private void initValidation()
        {
            validationFields = new Dictionary<Control, Control>()
            {
                {TbServer,lblErrorServer },
                {TbUsername,lblErrorUsername },
                {TbPassword,lblErrorPassword }
            };
            validationFields.Values.ToList().ForEach(value=>value.Visible=false);
            lblError.Clear();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                validationFields.Values.ToList().ForEach(value => value.Visible = false);
                if (validationFields.IsNotEmpty())
                {
                    RepositoryFactory.GetRepository().Login(TbServer.Text.Trim(), TbUsername.Text.Trim(), TbPassword.Text.Trim());
                    new MenuForm().Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
