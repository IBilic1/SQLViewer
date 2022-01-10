using DataLayer.DAL;
using DataLayer.Models;
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

namespace SQLVIewer
{
    public partial class SSMS : Form
    {
        public SSMS()
        {
            InitializeComponent();
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            tbResults.Text = "";
            if ((e.Alt && e.KeyCode == Keys.X) && cbDataBases.SelectedItem!=null)
            {
                fpResults.Controls.Clear();
                showResults();
            }
        }

        private void showResults()
        {
            string message="";
            try
            {
                string[] details = tbQuery.Text.Trim().Split(Environment.NewLine.ToCharArray());

                IList<string> list = new ParseQuery().devideQueryNew(details, 0);
                foreach (string query in list)
                {
                    if (!string.IsNullOrEmpty(query))
                    {
                        DBResult dBAnswer = RepositoryFactory.GetRepository().CreateDataSet(query, cbDataBases.SelectedItem as Database);
                        message = dBAnswer.CompletionTime.ToString();
                        foreach (DataTable item in dBAnswer.DataSet.Tables)
                        {
                            DataGridView dgw = new DataGridView();
                            dgw.DataSource = item;
                            fpResults.Controls.Add(dgw);
                        }
                        tbResults.Text += $"{Environment.NewLine}{dBAnswer.Message}";
                    }
                }
                tbResults.Text += $"{Environment.NewLine}{message}";
            }
            catch (Exception e)
            {
                tbResults.Text += e.Message;
            }

        }
        private void SSMS_Load(object sender, EventArgs e)
        {
            cbDataBases.DataSource = RepositoryFactory.GetRepository().GetDatabases().ToList();
        }

        private void SSMS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnIvana_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("0. Delimiter nije potreban").Append(Environment.NewLine);
            sb.Append("1. Upite možete razlomiti enterom.").Append(Environment.NewLine);
            sb.Append("2. Prije entera nemojte ubacivati whitespace!").Append(Environment.NewLine);
            sb.Append("3. Nemojte upisati dva upita u jednom retku.").Append(Environment.NewLine);
            MessageBox.Show(sb.ToString(),"PRAVILA");

        }
    }
}
