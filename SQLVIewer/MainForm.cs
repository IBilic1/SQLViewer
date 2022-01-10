using DataLayer.DAL;
using DataLayer.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SQLVIewer
{
    public partial class MainForm : Form
    {
        private const string FileFilter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
        private const string FileName = "{0}.xml";
        public MainForm()
        {
            InitializeComponent();
            CbDatabases.DataSource = RepositoryFactory.GetRepository().GetDatabases().ToList();
        }
        private void CbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            LbTables.DataSource = (CbDatabases.SelectedItem as Database).Tables;
            LbViews.DataSource = (CbDatabases.SelectedItem as Database).Views;
            LbProcedures.DataSource = (CbDatabases.SelectedItem as Database).Procedures;
        }

        private void LbProcedures_SelectedIndexChanged(object sender, EventArgs e)
        {
            TbProcedureDefinition.Text = (LbProcedures.SelectedItem as Procedure).Definition;
            LbProcedureParameters.DataSource= (LbProcedures.SelectedItem as Procedure).Parameters;
        }

        private void LbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            LbTableColumns.DataSource = (LbTables.SelectedItem as DBEntity).Columns;
        }

        private void LbViews_SelectedIndexChanged(object sender, EventArgs e)
        {
            LbViewColumns.DataSource = (LbTables.SelectedItem as DBEntity).Columns;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnXML_Click(object sender, EventArgs e)
        {
            DBEntity entity;
            switch ((sender as Button).Name)
            {
                case nameof(btnXMLTable):
                    entity = LbTables.SelectedItem as DBEntity;
                    break;
                case nameof(btnXMLViews):
                    entity = LbViews.SelectedItem as DBEntity;
                    break;
                default:
                    throw new Exception("No such button!");
            }

            var dialog = new SaveFileDialog()
            {
                FileName = string.Format(FileName, entity.Name),
                Filter = FileFilter
            };
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                DataSet ds = RepositoryFactory.GetRepository().CreateDataSet(entity);
                ds.WriteXml(dialog.FileName,XmlWriteMode.WriteSchema);
            }
        }

        private void BtnSelect_Clikc(object sender, EventArgs e)
        {
            DBEntity entity;
            switch ((sender as Button).Name)
            {
                case nameof(btnSelectTable):
                    entity = LbTables.SelectedItem as DBEntity;
                    break;
                case nameof(btnSelectViews):
                    entity = LbViews.SelectedItem as DBEntity;
                    break;
                default:
                    throw new Exception("No such button!");
            }
            DataSet ds = RepositoryFactory.GetRepository().CreateDataSet(entity);
            new SelectResultForm(ds.Tables[0]).ShowDialog();
        }
    }
}
