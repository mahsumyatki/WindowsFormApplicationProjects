
namespace LanguageCourseManagementProject
{
    partial class StudentManagement
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
            this.dataGridView_studentList = new System.Windows.Forms.DataGridView();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_imageChoose = new System.Windows.Forms.Button();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_address = new System.Windows.Forms.TextBox();
            this.textBox_nameSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_clean = new System.Windows.Forms.Button();
            this.textBox_filter = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_image = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_studentList
            // 
            this.dataGridView_studentList.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_studentList.Location = new System.Drawing.Point(0, 65);
            this.dataGridView_studentList.Name = "dataGridView_studentList";
            this.dataGridView_studentList.Size = new System.Drawing.Size(1034, 296);
            this.dataGridView_studentList.TabIndex = 0;
            this.dataGridView_studentList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_studentList_CellMouseClick);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.OrangeRed;
            this.button_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(649, 569);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(158, 36);
            this.button_update.TabIndex = 18;
            this.button_update.Text = "GÜNCELLE";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(813, 569);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(158, 36);
            this.button_delete.TabIndex = 19;
            this.button_delete.Text = "SİL";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_imageChoose
            // 
            this.button_imageChoose.BackColor = System.Drawing.Color.ForestGreen;
            this.button_imageChoose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_imageChoose.ForeColor = System.Drawing.Color.White;
            this.button_imageChoose.Location = new System.Drawing.Point(658, 481);
            this.button_imageChoose.Name = "button_imageChoose";
            this.button_imageChoose.Size = new System.Drawing.Size(32, 21);
            this.button_imageChoose.TabIndex = 20;
            this.button_imageChoose.Text = "\'\'\'";
            this.button_imageChoose.UseVisualStyleBackColor = false;
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Location = new System.Drawing.Point(813, 406);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(158, 109);
            this.pictureBox_image.TabIndex = 17;
            this.pictureBox_image.TabStop = false;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Location = new System.Drawing.Point(482, 446);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(170, 21);
            this.comboBox_gender.TabIndex = 16;
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(154, 446);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(170, 20);
            this.dateTimePicker_birthday.TabIndex = 15;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(482, 407);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(170, 20);
            this.textBox_phone.TabIndex = 12;
            // 
            // textBox_address
            // 
            this.textBox_address.Location = new System.Drawing.Point(154, 481);
            this.textBox_address.Multiline = true;
            this.textBox_address.Name = "textBox_address";
            this.textBox_address.Size = new System.Drawing.Size(170, 115);
            this.textBox_address.TabIndex = 13;
            // 
            // textBox_nameSurname
            // 
            this.textBox_nameSurname.Location = new System.Drawing.Point(153, 407);
            this.textBox_nameSurname.Name = "textBox_nameSurname";
            this.textBox_nameSurname.Size = new System.Drawing.Size(170, 20);
            this.textBox_nameSurname.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(405, 447);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cinsiyet :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(405, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(28, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Doğum Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(86, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adres :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(54, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ad Soyad :";
            // 
            // button_clean
            // 
            this.button_clean.BackColor = System.Drawing.Color.DarkOrange;
            this.button_clean.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clean.ForeColor = System.Drawing.Color.White;
            this.button_clean.Location = new System.Drawing.Point(485, 569);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(158, 36);
            this.button_clean.TabIndex = 18;
            this.button_clean.Text = "RESET";
            this.button_clean.UseVisualStyleBackColor = false;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // textBox_filter
            // 
            this.textBox_filter.Location = new System.Drawing.Point(652, 23);
            this.textBox_filter.Name = "textBox_filter";
            this.textBox_filter.Size = new System.Drawing.Size(178, 20);
            this.textBox_filter.TabIndex = 12;
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.DarkOrange;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(836, 13);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(84, 38);
            this.button_search.TabIndex = 18;
            this.button_search.Text = "ARA";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.textBox_filter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 65);
            this.panel1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(260, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "ÖĞRENCİ YÖNETİMİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(414, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Resim :";
            // 
            // textBox_image
            // 
            this.textBox_image.Location = new System.Drawing.Point(482, 482);
            this.textBox_image.Name = "textBox_image";
            this.textBox_image.Size = new System.Drawing.Size(170, 20);
            this.textBox_image.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(25, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 37);
            this.label8.TabIndex = 22;
            this.label8.Text = "<<<";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.DarkOrange;
            this.button_refresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(926, 14);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(103, 38);
            this.button_refresh.TabIndex = 22;
            this.button_refresh.Text = "YENİLE";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1034, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_imageChoose);
            this.Controls.Add(this.pictureBox_image);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.dateTimePicker_birthday);
            this.Controls.Add(this.textBox_image);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_address);
            this.Controls.Add(this.textBox_nameSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_studentList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StudentManagement";
            this.Text = "StudentManagement";
            this.Load += new System.EventHandler(this.StudentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_studentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_studentList;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_imageChoose;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthday;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_address;
        private System.Windows.Forms.TextBox textBox_nameSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.TextBox textBox_filter;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_image;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_refresh;
    }
}