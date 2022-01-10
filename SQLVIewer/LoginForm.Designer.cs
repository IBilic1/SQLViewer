
namespace SQLVIewer
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbServer = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbUsername = new System.Windows.Forms.TextBox();
            this.lblErrorPassword = new System.Windows.Forms.Label();
            this.lblErrorUsername = new System.Windows.Forms.Label();
            this.lblErrorServer = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // TbServer
            // 
            this.TbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbServer.Location = new System.Drawing.Point(182, 64);
            this.TbServer.Name = "TbServer";
            this.TbServer.Size = new System.Drawing.Size(256, 26);
            this.TbServer.TabIndex = 3;
            // 
            // TbPassword
            // 
            this.TbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbPassword.Location = new System.Drawing.Point(182, 200);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.PasswordChar = '$';
            this.TbPassword.Size = new System.Drawing.Size(256, 26);
            this.TbPassword.TabIndex = 4;
            // 
            // TbUsername
            // 
            this.TbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbUsername.Location = new System.Drawing.Point(182, 138);
            this.TbUsername.Name = "TbUsername";
            this.TbUsername.Size = new System.Drawing.Size(256, 26);
            this.TbUsername.TabIndex = 5;
            // 
            // lblErrorPassword
            // 
            this.lblErrorPassword.AutoSize = true;
            this.lblErrorPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPassword.Location = new System.Drawing.Point(462, 202);
            this.lblErrorPassword.Name = "lblErrorPassword";
            this.lblErrorPassword.Size = new System.Drawing.Size(17, 17);
            this.lblErrorPassword.TabIndex = 8;
            this.lblErrorPassword.Text = "X";
            // 
            // lblErrorUsername
            // 
            this.lblErrorUsername.AutoSize = true;
            this.lblErrorUsername.ForeColor = System.Drawing.Color.Red;
            this.lblErrorUsername.Location = new System.Drawing.Point(462, 138);
            this.lblErrorUsername.Name = "lblErrorUsername";
            this.lblErrorUsername.Size = new System.Drawing.Size(17, 17);
            this.lblErrorUsername.TabIndex = 7;
            this.lblErrorUsername.Text = "X";
            // 
            // lblErrorServer
            // 
            this.lblErrorServer.AutoSize = true;
            this.lblErrorServer.ForeColor = System.Drawing.Color.Red;
            this.lblErrorServer.Location = new System.Drawing.Point(462, 67);
            this.lblErrorServer.Name = "lblErrorServer";
            this.lblErrorServer.Size = new System.Drawing.Size(17, 17);
            this.lblErrorServer.TabIndex = 6;
            this.lblErrorServer.Text = "X";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(182, 316);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(46, 17);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "label7";
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.Location = new System.Drawing.Point(182, 251);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(256, 39);
            this.BtnLogIn.TabIndex = 10;
            this.BtnLogIn.Text = "Login";
            this.BtnLogIn.UseVisualStyleBackColor = true;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 374);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblErrorPassword);
            this.Controls.Add(this.lblErrorUsername);
            this.Controls.Add(this.lblErrorServer);
            this.Controls.Add(this.TbUsername);
            this.Controls.Add(this.TbPassword);
            this.Controls.Add(this.TbServer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbServer;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbUsername;
        private System.Windows.Forms.Label lblErrorPassword;
        private System.Windows.Forms.Label lblErrorUsername;
        private System.Windows.Forms.Label lblErrorServer;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button BtnLogIn;
    }
}