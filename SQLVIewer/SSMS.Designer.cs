
namespace SQLVIewer
{
    partial class SSMS
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
            this.tbResults = new System.Windows.Forms.TextBox();
            this.fpResults = new System.Windows.Forms.FlowLayoutPanel();
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDataBases = new System.Windows.Forms.ComboBox();
            this.BtnIvana = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(5, 5);
            this.tbResults.Margin = new System.Windows.Forms.Padding(2);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.Size = new System.Drawing.Size(988, 345);
            this.tbResults.TabIndex = 0;
            // 
            // fpResults
            // 
            this.fpResults.AutoScroll = true;
            this.fpResults.Location = new System.Drawing.Point(5, 5);
            this.fpResults.Margin = new System.Windows.Forms.Padding(2);
            this.fpResults.Name = "fpResults";
            this.fpResults.Size = new System.Drawing.Size(988, 345);
            this.fpResults.TabIndex = 1;
            // 
            // tbQuery
            // 
            this.tbQuery.Location = new System.Drawing.Point(26, 58);
            this.tbQuery.Margin = new System.Windows.Forms.Padding(2);
            this.tbQuery.Multiline = true;
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.Size = new System.Drawing.Size(993, 226);
            this.tbQuery.TabIndex = 2;
            this.tbQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(22, 289);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1005, 381);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.fpResults);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(997, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Results";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbResults);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(997, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Messages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Databases:";
            // 
            // cbDataBases
            // 
            this.cbDataBases.FormattingEnabled = true;
            this.cbDataBases.Location = new System.Drawing.Point(109, 13);
            this.cbDataBases.Name = "cbDataBases";
            this.cbDataBases.Size = new System.Drawing.Size(121, 21);
            this.cbDataBases.TabIndex = 5;
            // 
            // BtnIvana
            // 
            this.BtnIvana.Location = new System.Drawing.Point(301, 13);
            this.BtnIvana.Name = "BtnIvana";
            this.BtnIvana.Size = new System.Drawing.Size(226, 23);
            this.BtnIvana.TabIndex = 6;
            this.BtnIvana.Text = "Pravila SQLIvana jezika";
            this.BtnIvana.UseVisualStyleBackColor = true;
            this.BtnIvana.Click += new System.EventHandler(this.BtnIvana_Click);
            // 
            // SSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 682);
            this.Controls.Add(this.BtnIvana);
            this.Controls.Add(this.cbDataBases);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tbQuery);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSMS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SSMS_FormClosed);
            this.Load += new System.EventHandler(this.SSMS_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.FlowLayoutPanel fpResults;
        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDataBases;
        private System.Windows.Forms.Button BtnIvana;
    }
}