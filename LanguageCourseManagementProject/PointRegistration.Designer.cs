
namespace LanguageCourseManagementProject
{
    partial class PointRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointRegistration));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_studentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViev_studentList = new System.Windows.Forms.DataGridView();
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_point = new System.Windows.Forms.TextBox();
            this.dataGridView_point = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViev_studentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_point)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 71);
            this.panel1.TabIndex = 38;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(958, 3);
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
            this.label6.Location = new System.Drawing.Point(413, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "YENİ PUAN";
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.DarkOrange;
            this.button_reset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.Color.White;
            this.button_reset.Location = new System.Drawing.Point(672, 552);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(158, 36);
            this.button_reset.TabIndex = 36;
            this.button_reset.Text = "RESET";
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.DarkCyan;
            this.button_add.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.White;
            this.button_add.Location = new System.Drawing.Point(849, 552);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(158, 36);
            this.button_add.TabIndex = 37;
            this.button_add.Text = "EKLE";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(139, 519);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(170, 69);
            this.textBox_description.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(40, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Açıklama :";
            // 
            // textBox_studentId
            // 
            this.textBox_studentId.Location = new System.Drawing.Point(139, 450);
            this.textBox_studentId.Name = "textBox_studentId";
            this.textBox_studentId.Size = new System.Drawing.Size(170, 20);
            this.textBox_studentId.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(40, 486);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "Kurs Seç :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(40, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Öğrenci Id :";
            // 
            // dataGridViev_studentList
            // 
            this.dataGridViev_studentList.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViev_studentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViev_studentList.Location = new System.Drawing.Point(1, 69);
            this.dataGridViev_studentList.Name = "dataGridViev_studentList";
            this.dataGridViev_studentList.Size = new System.Drawing.Size(652, 346);
            this.dataGridViev_studentList.TabIndex = 29;
            // 
            // comboBox_course
            // 
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Items.AddRange(new object[] {
            "YDS Hazırlık",
            "YKSDil Hazırlık",
            "YÖKDil Hazırlık",
            "Genel İngilizce"});
            this.comboBox_course.Location = new System.Drawing.Point(139, 486);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(170, 21);
            this.comboBox_course.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(461, 451);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Puan :";
            // 
            // textBox_point
            // 
            this.textBox_point.Location = new System.Drawing.Point(524, 451);
            this.textBox_point.Name = "textBox_point";
            this.textBox_point.Size = new System.Drawing.Size(170, 20);
            this.textBox_point.TabIndex = 35;
            // 
            // dataGridView_point
            // 
            this.dataGridView_point.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_point.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_point.Location = new System.Drawing.Point(672, 69);
            this.dataGridView_point.Name = "dataGridView_point";
            this.dataGridView_point.Size = new System.Drawing.Size(389, 346);
            this.dataGridView_point.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 37);
            this.label8.TabIndex = 40;
            this.label8.Text = "<<<";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // PointRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 598);
            this.Controls.Add(this.comboBox_course);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_point);
            this.Controls.Add(this.textBox_studentId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_point);
            this.Controls.Add(this.dataGridViev_studentList);
            this.Name = "PointRegistration";
            this.Text = "PointRegistrationcs";
            this.Load += new System.EventHandler(this.PointRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViev_studentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_point)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_studentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViev_studentList;
        private System.Windows.Forms.ComboBox comboBox_course;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_point;
        private System.Windows.Forms.DataGridView dataGridView_point;
        private System.Windows.Forms.Label label8;
    }
}