
namespace LanguageCourseManagementProject
{
    partial class LoginPage
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(159, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(262, 38);
            this.label6.TabIndex = 9;
            this.label6.Text = "YATKI DİL KURSU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Engravers MT", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 75);
            this.label2.TabIndex = 10;
            this.label2.Text = "A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Kullanıcı : ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(221, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 1);
            this.label3.TabIndex = 46;
            // 
            // textBox_user
            // 
            this.textBox_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_user.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_user.ForeColor = System.Drawing.Color.White;
            this.textBox_user.Location = new System.Drawing.Point(221, 183);
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(200, 16);
            this.textBox_user.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(143, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "Şifre : ";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(221, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 1);
            this.label5.TabIndex = 46;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.textBox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_password.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.ForeColor = System.Drawing.Color.White;
            this.textBox_password.Location = new System.Drawing.Point(221, 237);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(200, 16);
            this.textBox_password.TabIndex = 47;
            // 
            // button_login
            // 
            this.button_login.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.Location = new System.Drawing.Point(221, 298);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(200, 37);
            this.button_login.TabIndex = 48;
            this.button_login.Text = "GİRİŞ YAP";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(565, 384);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
    }
}