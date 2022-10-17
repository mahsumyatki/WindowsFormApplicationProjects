
namespace LanguageCourseManagementProject
{
    partial class StudentRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegistration));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.pictureBox_studentImage = new System.Windows.Forms.PictureBox();
            this.comboBox_studentGender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_studentBirthday = new System.Windows.Forms.DateTimePicker();
            this.textBox_studentImage = new System.Windows.Forms.TextBox();
            this.textBox_studentPhone = new System.Windows.Forms.TextBox();
            this.textBox_studentAddress = new System.Windows.Forms.TextBox();
            this.textBox_studentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_student = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_studentImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 37);
            this.label7.TabIndex = 9;
            this.label7.Text = "<<<";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(913, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(370, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "ÖĞRENCİ KAYIT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 71);
            this.panel1.TabIndex = 25;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(679, 546);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 28);
            this.button3.TabIndex = 24;
            this.button3.Text = "RESET";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkCyan;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(815, 546);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 28);
            this.button2.TabIndex = 23;
            this.button2.Text = "EKLE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_upload
            // 
            this.button_upload.BackColor = System.Drawing.Color.ForestGreen;
            this.button_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_upload.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.ForeColor = System.Drawing.Color.White;
            this.button_upload.Location = new System.Drawing.Point(679, 460);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(31, 20);
            this.button_upload.TabIndex = 22;
            this.button_upload.Text = "\'\'\'";
            this.button_upload.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_upload.UseVisualStyleBackColor = false;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // pictureBox_studentImage
            // 
            this.pictureBox_studentImage.Location = new System.Drawing.Point(815, 385);
            this.pictureBox_studentImage.Name = "pictureBox_studentImage";
            this.pictureBox_studentImage.Size = new System.Drawing.Size(130, 109);
            this.pictureBox_studentImage.TabIndex = 21;
            this.pictureBox_studentImage.TabStop = false;
            // 
            // comboBox_studentGender
            // 
            this.comboBox_studentGender.FormattingEnabled = true;
            this.comboBox_studentGender.Location = new System.Drawing.Point(517, 424);
            this.comboBox_studentGender.Name = "comboBox_studentGender";
            this.comboBox_studentGender.Size = new System.Drawing.Size(155, 21);
            this.comboBox_studentGender.TabIndex = 20;
            // 
            // dateTimePicker_studentBirthday
            // 
            this.dateTimePicker_studentBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_studentBirthday.Location = new System.Drawing.Point(190, 425);
            this.dateTimePicker_studentBirthday.Name = "dateTimePicker_studentBirthday";
            this.dateTimePicker_studentBirthday.Size = new System.Drawing.Size(155, 20);
            this.dateTimePicker_studentBirthday.TabIndex = 19;
            // 
            // textBox_studentImage
            // 
            this.textBox_studentImage.Location = new System.Drawing.Point(517, 460);
            this.textBox_studentImage.Name = "textBox_studentImage";
            this.textBox_studentImage.Size = new System.Drawing.Size(155, 20);
            this.textBox_studentImage.TabIndex = 18;
            // 
            // textBox_studentPhone
            // 
            this.textBox_studentPhone.Location = new System.Drawing.Point(517, 385);
            this.textBox_studentPhone.Name = "textBox_studentPhone";
            this.textBox_studentPhone.Size = new System.Drawing.Size(155, 20);
            this.textBox_studentPhone.TabIndex = 17;
            // 
            // textBox_studentAddress
            // 
            this.textBox_studentAddress.Location = new System.Drawing.Point(190, 460);
            this.textBox_studentAddress.Multiline = true;
            this.textBox_studentAddress.Name = "textBox_studentAddress";
            this.textBox_studentAddress.Size = new System.Drawing.Size(155, 69);
            this.textBox_studentAddress.TabIndex = 15;
            // 
            // textBox_studentName
            // 
            this.textBox_studentName.Location = new System.Drawing.Point(190, 386);
            this.textBox_studentName.Name = "textBox_studentName";
            this.textBox_studentName.Size = new System.Drawing.Size(155, 20);
            this.textBox_studentName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(440, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cinsiyet :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(449, 461);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Resim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(440, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(64, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Doğum Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(91, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Adres :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(91, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ad Soyad :";
            // 
            // dataGridView_student
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dataGridView_student.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_student.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_student.Location = new System.Drawing.Point(0, 71);
            this.dataGridView_student.Name = "dataGridView_student";
            this.dataGridView_student.Size = new System.Drawing.Size(1017, 281);
            this.dataGridView_student.TabIndex = 8;
            // 
            // StudentRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.pictureBox_studentImage);
            this.Controls.Add(this.comboBox_studentGender);
            this.Controls.Add(this.dateTimePicker_studentBirthday);
            this.Controls.Add(this.textBox_studentImage);
            this.Controls.Add(this.textBox_studentPhone);
            this.Controls.Add(this.textBox_studentAddress);
            this.Controls.Add(this.textBox_studentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_student);
            this.Name = "StudentRegistration";
            this.Text = "StudentRegistration";
            this.Load += new System.EventHandler(this.StudentRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_studentImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_student)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.PictureBox pictureBox_studentImage;
        private System.Windows.Forms.ComboBox comboBox_studentGender;
        private System.Windows.Forms.DateTimePicker dateTimePicker_studentBirthday;
        private System.Windows.Forms.TextBox textBox_studentImage;
        private System.Windows.Forms.TextBox textBox_studentPhone;
        private System.Windows.Forms.TextBox textBox_studentAddress;
        private System.Windows.Forms.TextBox textBox_studentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView_student;
    }
}