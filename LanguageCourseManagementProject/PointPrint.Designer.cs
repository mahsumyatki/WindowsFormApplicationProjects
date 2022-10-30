
namespace LanguageCourseManagementProject
{
    partial class PointPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointPrint));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.textBox_filter = new System.Windows.Forms.TextBox();
            this.button_print = new System.Windows.Forms.Button();
            this.dataGridView_pointList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pointList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.button_search);
            this.panel1.Controls.Add(this.textBox_filter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 65);
            this.panel1.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 37);
            this.label8.TabIndex = 51;
            this.label8.Text = "<<<";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(347, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "PUAN LİSTESİ";
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.Color.DarkOrange;
            this.button_refresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.White;
            this.button_refresh.Location = new System.Drawing.Point(922, 21);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(109, 38);
            this.button_refresh.TabIndex = 18;
            this.button_refresh.Text = "YENİLE";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // button_search
            // 
            this.button_search.BackColor = System.Drawing.Color.DarkOrange;
            this.button_search.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_search.ForeColor = System.Drawing.Color.White;
            this.button_search.Location = new System.Drawing.Point(832, 21);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(84, 38);
            this.button_search.TabIndex = 18;
            this.button_search.Text = "ARA";
            this.button_search.UseVisualStyleBackColor = false;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // textBox_filter
            // 
            this.textBox_filter.Location = new System.Drawing.Point(648, 31);
            this.textBox_filter.Name = "textBox_filter";
            this.textBox_filter.Size = new System.Drawing.Size(178, 20);
            this.textBox_filter.TabIndex = 12;
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.DarkCyan;
            this.button_print.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_print.ForeColor = System.Drawing.Color.White;
            this.button_print.Location = new System.Drawing.Point(873, 562);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(158, 36);
            this.button_print.TabIndex = 30;
            this.button_print.Text = "YAZDIR";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // dataGridView_pointList
            // 
            this.dataGridView_pointList.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridView_pointList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_pointList.Location = new System.Drawing.Point(0, 138);
            this.dataGridView_pointList.Name = "dataGridView_pointList";
            this.dataGridView_pointList.Size = new System.Drawing.Size(1040, 418);
            this.dataGridView_pointList.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(347, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "PUAN LİSTESİ";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PointPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1043, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.dataGridView_pointList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PointPrint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PointPrint";
            this.Load += new System.EventHandler(this.PointPrint_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_pointList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_filter;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.DataGridView dataGridView_pointList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}