﻿
namespace projectPracticeSecond
{
    partial class managerWorkForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnImgLoad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tBoxDepartment = new System.Windows.Forms.ComboBox();
            this.tBoxIsAdmin = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxPosition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBoxPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBoxWorkerNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxPWD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegist = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnImgLoad);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tBoxDepartment);
            this.panel1.Controls.Add(this.tBoxIsAdmin);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tBoxPosition);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tBoxPhone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tBoxWorkerNum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tBoxPWD);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tBoxName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 444);
            this.panel1.TabIndex = 0;
            // 
            // btnImgLoad
            // 
            this.btnImgLoad.Location = new System.Drawing.Point(339, 229);
            this.btnImgLoad.Name = "btnImgLoad";
            this.btnImgLoad.Size = new System.Drawing.Size(94, 29);
            this.btnImgLoad.TabIndex = 6;
            this.btnImgLoad.Text = "불러오기";
            this.btnImgLoad.UseVisualStyleBackColor = true;
            this.btnImgLoad.Click += new System.EventHandler(this.btnImgLoad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(329, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 180);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tBoxDepartment
            // 
            this.tBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tBoxDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tBoxDepartment.FormattingEnabled = true;
            this.tBoxDepartment.Items.AddRange(new object[] {
            "부서1",
            "부서2",
            "부서3",
            "부서4",
            "부서5",
            "부서6"});
            this.tBoxDepartment.Location = new System.Drawing.Point(115, 341);
            this.tBoxDepartment.Name = "tBoxDepartment";
            this.tBoxDepartment.Size = new System.Drawing.Size(125, 28);
            this.tBoxDepartment.TabIndex = 4;
            // 
            // tBoxIsAdmin
            // 
            this.tBoxIsAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tBoxIsAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tBoxIsAdmin.FormattingEnabled = true;
            this.tBoxIsAdmin.Items.AddRange(new object[] {
            "관리자",
            "평사원"});
            this.tBoxIsAdmin.Location = new System.Drawing.Point(115, 288);
            this.tBoxIsAdmin.Name = "tBoxIsAdmin";
            this.tBoxIsAdmin.Size = new System.Drawing.Size(125, 28);
            this.tBoxIsAdmin.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "부서 :";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "관리자 :";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBoxPosition
            // 
            this.tBoxPosition.Location = new System.Drawing.Point(115, 235);
            this.tBoxPosition.Name = "tBoxPosition";
            this.tBoxPosition.Size = new System.Drawing.Size(125, 27);
            this.tBoxPosition.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "직책 :";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBoxPhone
            // 
            this.tBoxPhone.Location = new System.Drawing.Point(115, 179);
            this.tBoxPhone.Name = "tBoxPhone";
            this.tBoxPhone.Size = new System.Drawing.Size(125, 27);
            this.tBoxPhone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "전화번호 :";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBoxWorkerNum
            // 
            this.tBoxWorkerNum.Location = new System.Drawing.Point(115, 128);
            this.tBoxWorkerNum.Name = "tBoxWorkerNum";
            this.tBoxWorkerNum.Size = new System.Drawing.Size(125, 27);
            this.tBoxWorkerNum.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "사번 :";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBoxPWD
            // 
            this.tBoxPWD.Location = new System.Drawing.Point(115, 76);
            this.tBoxPWD.Name = "tBoxPWD";
            this.tBoxPWD.PasswordChar = '*';
            this.tBoxPWD.Size = new System.Drawing.Size(125, 27);
            this.tBoxPWD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "비밀번호 :";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(115, 29);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(125, 27);
            this.tBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnRegist, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(627, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.88496F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.11504F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 217F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(170, 444);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnRegist
            // 
            this.btnRegist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegist.Location = new System.Drawing.Point(3, 3);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(164, 109);
            this.btnRegist.TabIndex = 0;
            this.btnRegist.Text = "등록하기";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // managerWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "managerWorkForm";
            this.Text = "managerWorkForm";
            this.Load += new System.EventHandler(this.managerWorkForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBoxPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBoxWorkerNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxPWD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tBoxDepartment;
        private System.Windows.Forms.ComboBox tBoxIsAdmin;
        private System.Windows.Forms.Button btnRegist;
        private System.Windows.Forms.Button btnImgLoad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox hone;
    }
}