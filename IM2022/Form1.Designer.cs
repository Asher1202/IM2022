
namespace IM2022
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.t_id = new System.Windows.Forms.TextBox();
            this.t_password = new System.Windows.Forms.MaskedTextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_id
            // 
            this.t_id.Location = new System.Drawing.Point(378, 106);
            this.t_id.Name = "t_id";
            this.t_id.Size = new System.Drawing.Size(125, 27);
            this.t_id.TabIndex = 0;
            // 
            // t_password
            // 
            this.t_password.Location = new System.Drawing.Point(378, 156);
            this.t_password.Name = "t_password";
            this.t_password.Size = new System.Drawing.Size(125, 27);
            this.t_password.TabIndex = 1;
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(549, 221);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(94, 29);
            this.bt_login.TabIndex = 2;
            this.bt_login.Text = "đăng nhập";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.t_password);
            this.Controls.Add(this.t_id);
            this.Name = "Form1";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_id;
        private System.Windows.Forms.MaskedTextBox t_password;
        private System.Windows.Forms.Button bt_login;
    }
}

