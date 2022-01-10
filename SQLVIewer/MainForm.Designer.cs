
namespace SQLVIewer
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CbDatabases = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LbTables = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TbProcedureDefinition = new System.Windows.Forms.TextBox();
            this.LbTableColumns = new System.Windows.Forms.ListBox();
            this.LbViews = new System.Windows.Forms.ListBox();
            this.LbViewColumns = new System.Windows.Forms.ListBox();
            this.LbProcedureParameters = new System.Windows.Forms.ListBox();
            this.LbProcedures = new System.Windows.Forms.ListBox();
            this.btnXMLTable = new System.Windows.Forms.Button();
            this.btnSelectTable = new System.Windows.Forms.Button();
            this.btnSelectViews = new System.Windows.Forms.Button();
            this.btnXMLViews = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Databases:";
            // 
            // CbDatabases
            // 
            this.CbDatabases.FormattingEnabled = true;
            this.CbDatabases.Location = new System.Drawing.Point(114, 54);
            this.CbDatabases.Name = "CbDatabases";
            this.CbDatabases.Size = new System.Drawing.Size(251, 24);
            this.CbDatabases.TabIndex = 1;
            this.CbDatabases.SelectedIndexChanged += new System.EventHandler(this.CbDatabases_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tables:";
            // 
            // LbTables
            // 
            this.LbTables.FormattingEnabled = true;
            this.LbTables.ItemHeight = 16;
            this.LbTables.Location = new System.Drawing.Point(114, 111);
            this.LbTables.Name = "LbTables";
            this.LbTables.Size = new System.Drawing.Size(160, 244);
            this.LbTables.TabIndex = 3;
            this.LbTables.SelectedIndexChanged += new System.EventHandler(this.LbTables_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Table columns:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(696, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "View:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(970, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "View columns:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(937, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Procedure parameters:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(305, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Procedure definition:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 425);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Procedures:";
            // 
            // TbProcedureDefinition
            // 
            this.TbProcedureDefinition.Location = new System.Drawing.Point(462, 422);
            this.TbProcedureDefinition.Multiline = true;
            this.TbProcedureDefinition.Name = "TbProcedureDefinition";
            this.TbProcedureDefinition.Size = new System.Drawing.Size(459, 247);
            this.TbProcedureDefinition.TabIndex = 18;
            // 
            // LbTableColumns
            // 
            this.LbTableColumns.FormattingEnabled = true;
            this.LbTableColumns.ItemHeight = 16;
            this.LbTableColumns.Location = new System.Drawing.Point(462, 111);
            this.LbTableColumns.Name = "LbTableColumns";
            this.LbTableColumns.Size = new System.Drawing.Size(160, 244);
            this.LbTableColumns.TabIndex = 19;
            // 
            // LbViews
            // 
            this.LbViews.FormattingEnabled = true;
            this.LbViews.ItemHeight = 16;
            this.LbViews.Location = new System.Drawing.Point(761, 111);
            this.LbViews.Name = "LbViews";
            this.LbViews.Size = new System.Drawing.Size(160, 244);
            this.LbViews.TabIndex = 20;
            this.LbViews.SelectedIndexChanged += new System.EventHandler(this.LbViews_SelectedIndexChanged);
            // 
            // LbViewColumns
            // 
            this.LbViewColumns.FormattingEnabled = true;
            this.LbViewColumns.ItemHeight = 16;
            this.LbViewColumns.Location = new System.Drawing.Point(1095, 111);
            this.LbViewColumns.Name = "LbViewColumns";
            this.LbViewColumns.Size = new System.Drawing.Size(160, 244);
            this.LbViewColumns.TabIndex = 21;
            // 
            // LbProcedureParameters
            // 
            this.LbProcedureParameters.FormattingEnabled = true;
            this.LbProcedureParameters.ItemHeight = 16;
            this.LbProcedureParameters.Location = new System.Drawing.Point(1095, 425);
            this.LbProcedureParameters.Name = "LbProcedureParameters";
            this.LbProcedureParameters.Size = new System.Drawing.Size(160, 244);
            this.LbProcedureParameters.TabIndex = 22;
            // 
            // LbProcedures
            // 
            this.LbProcedures.FormattingEnabled = true;
            this.LbProcedures.ItemHeight = 16;
            this.LbProcedures.Location = new System.Drawing.Point(114, 425);
            this.LbProcedures.Name = "LbProcedures";
            this.LbProcedures.Size = new System.Drawing.Size(160, 244);
            this.LbProcedures.TabIndex = 23;
            this.LbProcedures.SelectedIndexChanged += new System.EventHandler(this.LbProcedures_SelectedIndexChanged);
            // 
            // btnXMLTable
            // 
            this.btnXMLTable.Location = new System.Drawing.Point(292, 258);
            this.btnXMLTable.Name = "btnXMLTable";
            this.btnXMLTable.Size = new System.Drawing.Size(105, 43);
            this.btnXMLTable.TabIndex = 24;
            this.btnXMLTable.Text = "XML";
            this.btnXMLTable.UseVisualStyleBackColor = true;
            this.btnXMLTable.Click += new System.EventHandler(this.BtnXML_Click);
            // 
            // btnSelectTable
            // 
            this.btnSelectTable.Location = new System.Drawing.Point(292, 312);
            this.btnSelectTable.Name = "btnSelectTable";
            this.btnSelectTable.Size = new System.Drawing.Size(105, 43);
            this.btnSelectTable.TabIndex = 25;
            this.btnSelectTable.Text = "Select";
            this.btnSelectTable.UseVisualStyleBackColor = true;
            this.btnSelectTable.Click += new System.EventHandler(this.BtnSelect_Clikc);
            // 
            // btnSelectViews
            // 
            this.btnSelectViews.Location = new System.Drawing.Point(940, 312);
            this.btnSelectViews.Name = "btnSelectViews";
            this.btnSelectViews.Size = new System.Drawing.Size(105, 43);
            this.btnSelectViews.TabIndex = 27;
            this.btnSelectViews.Text = "Select";
            this.btnSelectViews.UseVisualStyleBackColor = true;
            this.btnSelectViews.Click += new System.EventHandler(this.BtnSelect_Clikc);
            // 
            // btnXMLViews
            // 
            this.btnXMLViews.Location = new System.Drawing.Point(940, 258);
            this.btnXMLViews.Name = "btnXMLViews";
            this.btnXMLViews.Size = new System.Drawing.Size(105, 43);
            this.btnXMLViews.TabIndex = 26;
            this.btnXMLViews.Text = "XML";
            this.btnXMLViews.UseVisualStyleBackColor = true;
            this.btnXMLViews.Click += new System.EventHandler(this.BtnXML_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 727);
            this.Controls.Add(this.btnSelectViews);
            this.Controls.Add(this.btnXMLViews);
            this.Controls.Add(this.btnSelectTable);
            this.Controls.Add(this.btnXMLTable);
            this.Controls.Add(this.LbProcedures);
            this.Controls.Add(this.LbProcedureParameters);
            this.Controls.Add(this.LbViewColumns);
            this.Controls.Add(this.LbViews);
            this.Controls.Add(this.LbTableColumns);
            this.Controls.Add(this.TbProcedureDefinition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LbTables);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CbDatabases);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbDatabases;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox LbTables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TbProcedureDefinition;
        private System.Windows.Forms.ListBox LbTableColumns;
        private System.Windows.Forms.ListBox LbViews;
        private System.Windows.Forms.ListBox LbViewColumns;
        private System.Windows.Forms.ListBox LbProcedureParameters;
        private System.Windows.Forms.ListBox LbProcedures;
        private System.Windows.Forms.Button btnXMLTable;
        private System.Windows.Forms.Button btnSelectTable;
        private System.Windows.Forms.Button btnSelectViews;
        private System.Windows.Forms.Button btnXMLViews;
    }
}

