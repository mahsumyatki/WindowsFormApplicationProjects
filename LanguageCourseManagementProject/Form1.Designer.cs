﻿
namespace LanguageCourseManagementProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.button_student = new System.Windows.Forms.Button();
            this.panel_studentMenu = new System.Windows.Forms.Panel();
            this.button_studentRegistration = new System.Windows.Forms.Button();
            this.button_studentManagement = new System.Windows.Forms.Button();
            this.button_studentContent = new System.Windows.Forms.Button();
            this.button_studentPrint = new System.Windows.Forms.Button();
            this.panel_courseMenu = new System.Windows.Forms.Panel();
            this.button_coursePrint = new System.Windows.Forms.Button();
            this.button_courseManagement = new System.Windows.Forms.Button();
            this.button_courseRegistration = new System.Windows.Forms.Button();
            this.button_course = new System.Windows.Forms.Button();
            this.panel_pointMenu = new System.Windows.Forms.Panel();
            this.button_pointPrint = new System.Windows.Forms.Button();
            this.button_pointManagement = new System.Windows.Forms.Button();
            this.button_pointRegistration = new System.Windows.Forms.Button();
            this.button_point = new System.Windows.Forms.Button();
            this.button_signout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panel_studentMenu.SuspendLayout();
            this.panel_courseMenu.SuspendLayout();
            this.panel_pointMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.button_signout);
            this.panel1.Controls.Add(this.panel_pointMenu);
            this.panel1.Controls.Add(this.button_point);
            this.panel1.Controls.Add(this.panel_courseMenu);
            this.panel1.Controls.Add(this.button_course);
            this.panel1.Controls.Add(this.panel_studentMenu);
            this.panel1.Controls.Add(this.button_student);
            this.panel1.Controls.Add(this.panel_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 574);
            this.panel1.TabIndex = 0;
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.label1);
            this.panel_logo.Controls.Add(this.label2);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(200, 111);
            this.panel_logo.TabIndex = 0;
            // 
            // button_student
            // 
            this.button_student.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_student.FlatAppearance.BorderSize = 0;
            this.button_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_student.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_student.ForeColor = System.Drawing.Color.White;
            this.button_student.Location = new System.Drawing.Point(0, 111);
            this.button_student.Name = "button_student";
            this.button_student.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_student.Size = new System.Drawing.Size(200, 30);
            this.button_student.TabIndex = 1;
            this.button_student.Text = "Öğrenci";
            this.button_student.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_student.UseVisualStyleBackColor = true;
            this.button_student.Click += new System.EventHandler(this.button_student_Click);
            // 
            // panel_studentMenu
            // 
            this.panel_studentMenu.BackColor = System.Drawing.Color.Navy;
            this.panel_studentMenu.Controls.Add(this.button_studentPrint);
            this.panel_studentMenu.Controls.Add(this.button_studentContent);
            this.panel_studentMenu.Controls.Add(this.button_studentManagement);
            this.panel_studentMenu.Controls.Add(this.button_studentRegistration);
            this.panel_studentMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_studentMenu.Location = new System.Drawing.Point(0, 141);
            this.panel_studentMenu.Name = "panel_studentMenu";
            this.panel_studentMenu.Size = new System.Drawing.Size(200, 118);
            this.panel_studentMenu.TabIndex = 2;
            // 
            // button_studentRegistration
            // 
            this.button_studentRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_studentRegistration.FlatAppearance.BorderSize = 0;
            this.button_studentRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_studentRegistration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_studentRegistration.ForeColor = System.Drawing.Color.White;
            this.button_studentRegistration.Location = new System.Drawing.Point(0, 0);
            this.button_studentRegistration.Name = "button_studentRegistration";
            this.button_studentRegistration.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_studentRegistration.Size = new System.Drawing.Size(200, 30);
            this.button_studentRegistration.TabIndex = 2;
            this.button_studentRegistration.Text = "Kayıt";
            this.button_studentRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_studentRegistration.UseVisualStyleBackColor = true;
            this.button_studentRegistration.Click += new System.EventHandler(this.button_studentRegistration_Click);
            // 
            // button_studentManagement
            // 
            this.button_studentManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_studentManagement.FlatAppearance.BorderSize = 0;
            this.button_studentManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_studentManagement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_studentManagement.ForeColor = System.Drawing.Color.White;
            this.button_studentManagement.Location = new System.Drawing.Point(0, 30);
            this.button_studentManagement.Name = "button_studentManagement";
            this.button_studentManagement.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_studentManagement.Size = new System.Drawing.Size(200, 30);
            this.button_studentManagement.TabIndex = 3;
            this.button_studentManagement.Text = "Öğrenci Yönetimi";
            this.button_studentManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_studentManagement.UseVisualStyleBackColor = true;
            this.button_studentManagement.Click += new System.EventHandler(this.button_studentManagement_Click);
            // 
            // button_studentContent
            // 
            this.button_studentContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_studentContent.FlatAppearance.BorderSize = 0;
            this.button_studentContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_studentContent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_studentContent.ForeColor = System.Drawing.Color.White;
            this.button_studentContent.Location = new System.Drawing.Point(0, 60);
            this.button_studentContent.Name = "button_studentContent";
            this.button_studentContent.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_studentContent.Size = new System.Drawing.Size(200, 30);
            this.button_studentContent.TabIndex = 4;
            this.button_studentContent.Text = "İçerik";
            this.button_studentContent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_studentContent.UseVisualStyleBackColor = true;
            this.button_studentContent.Click += new System.EventHandler(this.button_studentContent_Click);
            // 
            // button_studentPrint
            // 
            this.button_studentPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_studentPrint.FlatAppearance.BorderSize = 0;
            this.button_studentPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_studentPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_studentPrint.ForeColor = System.Drawing.Color.White;
            this.button_studentPrint.Location = new System.Drawing.Point(0, 90);
            this.button_studentPrint.Name = "button_studentPrint";
            this.button_studentPrint.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_studentPrint.Size = new System.Drawing.Size(200, 30);
            this.button_studentPrint.TabIndex = 5;
            this.button_studentPrint.Text = "Yazdır";
            this.button_studentPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_studentPrint.UseVisualStyleBackColor = true;
            this.button_studentPrint.Click += new System.EventHandler(this.button_studentPrint_Click);
            // 
            // panel_courseMenu
            // 
            this.panel_courseMenu.BackColor = System.Drawing.Color.Navy;
            this.panel_courseMenu.Controls.Add(this.button_coursePrint);
            this.panel_courseMenu.Controls.Add(this.button_courseManagement);
            this.panel_courseMenu.Controls.Add(this.button_courseRegistration);
            this.panel_courseMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_courseMenu.Location = new System.Drawing.Point(0, 289);
            this.panel_courseMenu.Name = "panel_courseMenu";
            this.panel_courseMenu.Size = new System.Drawing.Size(200, 94);
            this.panel_courseMenu.TabIndex = 4;
            // 
            // button_coursePrint
            // 
            this.button_coursePrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_coursePrint.FlatAppearance.BorderSize = 0;
            this.button_coursePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_coursePrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_coursePrint.ForeColor = System.Drawing.Color.White;
            this.button_coursePrint.Location = new System.Drawing.Point(0, 60);
            this.button_coursePrint.Name = "button_coursePrint";
            this.button_coursePrint.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_coursePrint.Size = new System.Drawing.Size(200, 30);
            this.button_coursePrint.TabIndex = 4;
            this.button_coursePrint.Text = "Yazdır";
            this.button_coursePrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_coursePrint.UseVisualStyleBackColor = true;
            this.button_coursePrint.Click += new System.EventHandler(this.button_coursePrint_Click);
            // 
            // button_courseManagement
            // 
            this.button_courseManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_courseManagement.FlatAppearance.BorderSize = 0;
            this.button_courseManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_courseManagement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_courseManagement.ForeColor = System.Drawing.Color.White;
            this.button_courseManagement.Location = new System.Drawing.Point(0, 30);
            this.button_courseManagement.Name = "button_courseManagement";
            this.button_courseManagement.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_courseManagement.Size = new System.Drawing.Size(200, 30);
            this.button_courseManagement.TabIndex = 3;
            this.button_courseManagement.Text = "Kayıt Yönetimi";
            this.button_courseManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_courseManagement.UseVisualStyleBackColor = true;
            this.button_courseManagement.Click += new System.EventHandler(this.button_courseManagement_Click);
            // 
            // button_courseRegistration
            // 
            this.button_courseRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_courseRegistration.FlatAppearance.BorderSize = 0;
            this.button_courseRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_courseRegistration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_courseRegistration.ForeColor = System.Drawing.Color.White;
            this.button_courseRegistration.Location = new System.Drawing.Point(0, 0);
            this.button_courseRegistration.Name = "button_courseRegistration";
            this.button_courseRegistration.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_courseRegistration.Size = new System.Drawing.Size(200, 30);
            this.button_courseRegistration.TabIndex = 2;
            this.button_courseRegistration.Text = "Yeni Kayıt";
            this.button_courseRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_courseRegistration.UseVisualStyleBackColor = true;
            this.button_courseRegistration.Click += new System.EventHandler(this.button_courseRegistration_Click);
            // 
            // button_course
            // 
            this.button_course.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_course.FlatAppearance.BorderSize = 0;
            this.button_course.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_course.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_course.ForeColor = System.Drawing.Color.White;
            this.button_course.Location = new System.Drawing.Point(0, 259);
            this.button_course.Name = "button_course";
            this.button_course.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_course.Size = new System.Drawing.Size(200, 30);
            this.button_course.TabIndex = 3;
            this.button_course.Text = "Kurs";
            this.button_course.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_course.UseVisualStyleBackColor = true;
            this.button_course.Click += new System.EventHandler(this.button_course_Click);
            // 
            // panel_pointMenu
            // 
            this.panel_pointMenu.BackColor = System.Drawing.Color.Navy;
            this.panel_pointMenu.Controls.Add(this.button_pointPrint);
            this.panel_pointMenu.Controls.Add(this.button_pointManagement);
            this.panel_pointMenu.Controls.Add(this.button_pointRegistration);
            this.panel_pointMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_pointMenu.Location = new System.Drawing.Point(0, 413);
            this.panel_pointMenu.Name = "panel_pointMenu";
            this.panel_pointMenu.Size = new System.Drawing.Size(200, 95);
            this.panel_pointMenu.TabIndex = 6;
            // 
            // button_pointPrint
            // 
            this.button_pointPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_pointPrint.FlatAppearance.BorderSize = 0;
            this.button_pointPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pointPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pointPrint.ForeColor = System.Drawing.Color.White;
            this.button_pointPrint.Location = new System.Drawing.Point(0, 60);
            this.button_pointPrint.Name = "button_pointPrint";
            this.button_pointPrint.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_pointPrint.Size = new System.Drawing.Size(200, 30);
            this.button_pointPrint.TabIndex = 4;
            this.button_pointPrint.Text = "Yazdır";
            this.button_pointPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_pointPrint.UseVisualStyleBackColor = true;
            this.button_pointPrint.Click += new System.EventHandler(this.button_pointPrint_Click);
            // 
            // button_pointManagement
            // 
            this.button_pointManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_pointManagement.FlatAppearance.BorderSize = 0;
            this.button_pointManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pointManagement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pointManagement.ForeColor = System.Drawing.Color.White;
            this.button_pointManagement.Location = new System.Drawing.Point(0, 30);
            this.button_pointManagement.Name = "button_pointManagement";
            this.button_pointManagement.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_pointManagement.Size = new System.Drawing.Size(200, 30);
            this.button_pointManagement.TabIndex = 3;
            this.button_pointManagement.Text = "Puan Yönetimi";
            this.button_pointManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_pointManagement.UseVisualStyleBackColor = true;
            this.button_pointManagement.Click += new System.EventHandler(this.button_pointManagement_Click);
            // 
            // button_pointRegistration
            // 
            this.button_pointRegistration.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_pointRegistration.FlatAppearance.BorderSize = 0;
            this.button_pointRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pointRegistration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_pointRegistration.ForeColor = System.Drawing.Color.White;
            this.button_pointRegistration.Location = new System.Drawing.Point(0, 0);
            this.button_pointRegistration.Name = "button_pointRegistration";
            this.button_pointRegistration.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.button_pointRegistration.Size = new System.Drawing.Size(200, 30);
            this.button_pointRegistration.TabIndex = 2;
            this.button_pointRegistration.Text = "Yeni Puan";
            this.button_pointRegistration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_pointRegistration.UseVisualStyleBackColor = true;
            this.button_pointRegistration.Click += new System.EventHandler(this.button_pointRegistration_Click);
            // 
            // button_point
            // 
            this.button_point.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_point.FlatAppearance.BorderSize = 0;
            this.button_point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_point.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_point.ForeColor = System.Drawing.Color.White;
            this.button_point.Location = new System.Drawing.Point(0, 383);
            this.button_point.Name = "button_point";
            this.button_point.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_point.Size = new System.Drawing.Size(200, 30);
            this.button_point.TabIndex = 5;
            this.button_point.Text = "Puanlar";
            this.button_point.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_point.UseVisualStyleBackColor = true;
            this.button_point.Click += new System.EventHandler(this.button_point_Click);
            // 
            // button_signout
            // 
            this.button_signout.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_signout.FlatAppearance.BorderSize = 0;
            this.button_signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signout.ForeColor = System.Drawing.Color.White;
            this.button_signout.Location = new System.Drawing.Point(0, 508);
            this.button_signout.Name = "button_signout";
            this.button_signout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button_signout.Size = new System.Drawing.Size(200, 30);
            this.button_signout.TabIndex = 7;
            this.button_signout.Text = "Çıkış";
            this.button_signout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_signout.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(678, 574);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(678, 59);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 59);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(678, 52);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.comboBox1);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 509);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(678, 65);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Engravers MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(60, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 56);
            this.label2.TabIndex = 1;
            this.label2.Text = "A";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kullanıcı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Toplam Öğrenci :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kadın : ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(102, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Erkek : ";
            this.label6.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(517, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(457, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kurslar";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(458, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kadın : ";
            this.label8.Click += new System.EventHandler(this.label5_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(554, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 21);
            this.label9.TabIndex = 2;
            this.label9.Text = "Erkek : ";
            this.label9.Click += new System.EventHandler(this.label5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(55, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Admin";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(574, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(3, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 24);
            this.label11.TabIndex = 1;
            this.label11.Text = "Yatkı Dil Kursu-İstanbul";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 111);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(678, 397);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_logo.PerformLayout();
            this.panel_studentMenu.ResumeLayout(false);
            this.panel_courseMenu.ResumeLayout(false);
            this.panel_pointMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_signout;
        private System.Windows.Forms.Panel panel_pointMenu;
        private System.Windows.Forms.Button button_pointPrint;
        private System.Windows.Forms.Button button_pointManagement;
        private System.Windows.Forms.Button button_pointRegistration;
        private System.Windows.Forms.Button button_point;
        private System.Windows.Forms.Panel panel_courseMenu;
        private System.Windows.Forms.Button button_coursePrint;
        private System.Windows.Forms.Button button_courseManagement;
        private System.Windows.Forms.Button button_courseRegistration;
        private System.Windows.Forms.Button button_course;
        private System.Windows.Forms.Panel panel_studentMenu;
        private System.Windows.Forms.Button button_studentPrint;
        private System.Windows.Forms.Button button_studentContent;
        private System.Windows.Forms.Button button_studentManagement;
        private System.Windows.Forms.Button button_studentRegistration;
        private System.Windows.Forms.Button button_student;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}

