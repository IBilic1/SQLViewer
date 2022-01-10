
namespace SQLVIewer
{
    partial class MenuForm
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
            this.BtnSSMS = new System.Windows.Forms.Button();
            this.BtnSQLViewer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSSMS
            // 
            this.BtnSSMS.Location = new System.Drawing.Point(58, 65);
            this.BtnSSMS.Name = "BtnSSMS";
            this.BtnSSMS.Size = new System.Drawing.Size(319, 133);
            this.BtnSSMS.TabIndex = 0;
            this.BtnSSMS.Text = "SSMS";
            this.BtnSSMS.UseVisualStyleBackColor = true;
            this.BtnSSMS.Click += new System.EventHandler(this.BtnClick);
            // 
            // BtnSQLViewer
            // 
            this.BtnSQLViewer.Location = new System.Drawing.Point(58, 246);
            this.BtnSQLViewer.Name = "BtnSQLViewer";
            this.BtnSQLViewer.Size = new System.Drawing.Size(319, 133);
            this.BtnSQLViewer.TabIndex = 1;
            this.BtnSQLViewer.Text = "SQL Viewer";
            this.BtnSQLViewer.UseVisualStyleBackColor = true;
            this.BtnSQLViewer.Click += new System.EventHandler(this.BtnClick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.BtnSQLViewer);
            this.Controls.Add(this.BtnSSMS);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSSMS;
        private System.Windows.Forms.Button BtnSQLViewer;
    }
}