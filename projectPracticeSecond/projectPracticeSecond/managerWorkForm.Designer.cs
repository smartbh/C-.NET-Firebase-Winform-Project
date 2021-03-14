
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegist = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnImgLoad = new System.Windows.Forms.Button();
            this.picThumbnail = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(863, 484);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Controls.Add(this.btnRegist, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnModify, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tboxSearch, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel5, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(727, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.78571F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.21429F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(134, 480);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnRegist
            // 
            this.btnRegist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegist.Location = new System.Drawing.Point(2, 2);
            this.btnRegist.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegist.Name = "btnRegist";
            this.btnRegist.Size = new System.Drawing.Size(128, 63);
            this.btnRegist.TabIndex = 0;
            this.btnRegist.Text = "사원 등록하기";
            this.btnRegist.UseVisualStyleBackColor = true;
            this.btnRegist.Click += new System.EventHandler(this.btnRegist_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(2, 69);
            this.btnModify.Margin = new System.Windows.Forms.Padding(2);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(128, 58);
            this.btnModify.TabIndex = 1;
            this.btnModify.Text = "사원 정보 수정하기";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(128, 65);
            this.panel4.TabIndex = 9;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(0, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 60);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "사원 삭제하기";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tboxSearch
            // 
            this.tboxSearch.Location = new System.Drawing.Point(2, 202);
            this.tboxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.Size = new System.Drawing.Size(128, 23);
            this.tboxSearch.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 231);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(128, 246);
            this.panel5.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 45);
            this.label8.TabIndex = 0;
            this.label8.Text = "수정 하고 싶은\r\n사원 번호를\r\n입력해 주세요";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.25591F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.74409F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(719, 478);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 474);
            this.panel1.TabIndex = 0;
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
            this.tBoxDepartment.Location = new System.Drawing.Point(89, 256);
            this.tBoxDepartment.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxDepartment.Name = "tBoxDepartment";
            this.tBoxDepartment.Size = new System.Drawing.Size(98, 23);
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
            this.tBoxIsAdmin.Location = new System.Drawing.Point(89, 216);
            this.tBoxIsAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxIsAdmin.Name = "tBoxIsAdmin";
            this.tBoxIsAdmin.Size = new System.Drawing.Size(98, 23);
            this.tBoxIsAdmin.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 256);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "부서 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "관리자 :";
            // 
            // tBoxPosition
            // 
            this.tBoxPosition.Location = new System.Drawing.Point(89, 176);
            this.tBoxPosition.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxPosition.Name = "tBoxPosition";
            this.tBoxPosition.Size = new System.Drawing.Size(98, 23);
            this.tBoxPosition.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "직책 :";
            // 
            // tBoxPhone
            // 
            this.tBoxPhone.Location = new System.Drawing.Point(89, 134);
            this.tBoxPhone.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxPhone.Name = "tBoxPhone";
            this.tBoxPhone.Size = new System.Drawing.Size(98, 23);
            this.tBoxPhone.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "전화번호 :";
            // 
            // tBoxWorkerNum
            // 
            this.tBoxWorkerNum.Location = new System.Drawing.Point(89, 96);
            this.tBoxWorkerNum.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxWorkerNum.Name = "tBoxWorkerNum";
            this.tBoxWorkerNum.Size = new System.Drawing.Size(98, 23);
            this.tBoxWorkerNum.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "사번 :";
            // 
            // tBoxPWD
            // 
            this.tBoxPWD.Location = new System.Drawing.Point(89, 57);
            this.tBoxPWD.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxPWD.Name = "tBoxPWD";
            this.tBoxPWD.PasswordChar = '*';
            this.tBoxPWD.Size = new System.Drawing.Size(98, 23);
            this.tBoxPWD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "비밀번호 :";
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(89, 22);
            this.tBoxName.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(98, 23);
            this.tBoxName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 : ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(465, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 472);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnImgLoad);
            this.panel3.Controls.Add(this.picThumbnail);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 472);
            this.panel3.TabIndex = 0;
            // 
            // btnImgLoad
            // 
            this.btnImgLoad.Location = new System.Drawing.Point(50, 238);
            this.btnImgLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnImgLoad.Name = "btnImgLoad";
            this.btnImgLoad.Size = new System.Drawing.Size(73, 22);
            this.btnImgLoad.TabIndex = 6;
            this.btnImgLoad.Text = "불러오기";
            this.btnImgLoad.UseVisualStyleBackColor = true;
            this.btnImgLoad.Click += new System.EventHandler(this.btnImgLoad_Click);
            // 
            // picThumbnail
            // 
            this.picThumbnail.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picThumbnail.Location = new System.Drawing.Point(11, 15);
            this.picThumbnail.Margin = new System.Windows.Forms.Padding(2);
            this.picThumbnail.Name = "picThumbnail";
            this.picThumbnail.Size = new System.Drawing.Size(163, 200);
            this.picThumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThumbnail.TabIndex = 5;
            this.picThumbnail.TabStop = false;
            // 
            // managerWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(863, 484);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "managerWorkForm";
            this.Text = "managerWorkForm";
            this.Load += new System.EventHandler(this.managerWorkForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picThumbnail)).EndInit();
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
        private System.Windows.Forms.PictureBox picThumbnail;
        private System.Windows.Forms.TextBox hone;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
    }
}