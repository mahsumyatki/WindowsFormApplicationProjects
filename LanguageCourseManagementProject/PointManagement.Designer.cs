
namespace LanguageCourseManagementProject
{
    partial class PointManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_filter = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.dataGridView_pointList = new System.Windows.Forms.DataGridView();
            this.comboBox_course = new System.Windows.Forms.ComboBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_point = new System.Windows.Forms.TextBox();
            this.textBox_studentId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pointList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.textBox_filter);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 74);
            this.panel1.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 37);
            this.label8.TabIndex = 50;
            this.label8.Text = "<<<";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.DarkOrange;
            this.button_refresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(931, 20);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(118, 38);
            this.button_refresh.TabIndex = 20;
            this.button_refresh.Text = "YENİLE";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.DarkOrange;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(841, 19);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(84, 38);
            this.button_search.TabIndex = 20;
            this.button_search.Text = "ARA";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_filter
            // 
            this.textBox_filter.Location = new System.Drawing.Point(657, 29);
            this.textBox_filter.Name = "textBox_filter";
            this.textBox_filter.Size = new System.Drawing.Size(178, 20);
            this.textBox_filter.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(320, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "PUAN YÖNETİMİ";
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.Color.DarkOrange;
            this.button_reset.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reset.ForeColor = System.Drawing.Color.White;
            this.button_reset.Location = new System.Drawing.Point(563, 554);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(158, 36);
            this.button_reset.TabIndex = 39;
            this.button_reset.Text = "RESET";
            this.button_reset.UseVisualStyleBackColor = false;
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.OrangeRed;
            this.button_update.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Location = new System.Drawing.Point(727, 554);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(158, 36);
            this.button_update.TabIndex = 40;
            this.button_update.Text = "GÜNCELLE";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.DarkCyan;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.Color.White;
            this.button_delete.Location = new System.Drawing.Point(891, 554);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(158, 36);
            this.button_delete.TabIndex = 41;
            this.button_delete.Text = "SİL";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // dataGridView_pointList
            // 
            this.dataGridView_pointList.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_pointList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pointList.Location = new System.Drawing.Point(223, 72);
            this.dataGridView_pointList.Name = "dataGridView_pointList";
            this.dataGridView_pointList.Size = new System.Drawing.Size(581, 349);
            this.dataGridView_pointList.TabIndex = 42;
            // 
            // comboBox_course
            // 
            this.comboBox_course.FormattingEnabled = true;
            this.comboBox_course.Location = new System.Drawing.Point(135, 488);
            this.comboBox_course.Name = "comboBox_course";
            this.comboBox_course.Size = new System.Drawing.Size(170, 21);
            this.comboBox_course.TabIndex = 47;
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(135, 521);
            this.textBox_description.Multiline = true;
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(170, 69);
            this.textBox_description.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(36, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Açıklama :";
            // 
            // textBox_point
            // 
            this.textBox_point.Location = new System.Drawing.Point(520, 453);
            this.textBox_point.Name = "textBox_point";
            this.textBox_point.Size = new System.Drawing.Size(170, 20);
            this.textBox_point.TabIndex = 45;
            // 
            // textBox_studentId
            // 
            this.textBox_studentId.Location = new System.Drawing.Point(135, 452);
            this.textBox_studentId.Name = "textBox_studentId";
            this.textBox_studentId.Size = new System.Drawing.Size(170, 20);
            this.textBox_studentId.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(36, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Kurs Seç :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(457, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Puan :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(36, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Öğrenci Id :";
            // 
            // PointManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 598);
            this.Controls.Add(this.comboBox_course);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_description);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.textBox_point);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.textBox_studentId);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_pointList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PointManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PointManagement";
            this.Load += new System.EventHandler(this.PointManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pointList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.DataGridView dataGridView_pointList;
        private System.Windows.Forms.ComboBox comboBox_course;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_point;
        private System.Windows.Forms.TextBox textBox_studentId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_filter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_refresh;
    }
}