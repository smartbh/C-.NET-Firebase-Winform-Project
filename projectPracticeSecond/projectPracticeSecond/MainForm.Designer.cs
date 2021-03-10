
namespace projectPracticeSecond
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainBarPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnMini = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.MainContentPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlWorker = new System.Windows.Forms.Panel();
            this.lblWorkPositionTXT = new System.Windows.Forms.Label();
            this.lblWorkPosition = new System.Windows.Forms.Label();
            this.lblWorkDepartmentTXT = new System.Windows.Forms.Label();
            this.lblWorkNameTXT = new System.Windows.Forms.Label();
            this.lblWorkDepartment = new System.Windows.Forms.Label();
            this.lblWorkNumTXT = new System.Windows.Forms.Label();
            this.lblWorkName = new System.Windows.Forms.Label();
            this.lblWorkNum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainButtonPanel = new System.Windows.Forms.Panel();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnMail = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnCustomerManage = new System.Windows.Forms.Button();
            this.btnContractManage = new System.Windows.Forms.Button();
            this.MainTitlePanel = new System.Windows.Forms.Panel();
            this.MainBarPanel.SuspendLayout();
            this.MainContentPanel.SuspendLayout();
            this.pnlWorker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainBarPanel
            // 
            this.MainBarPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MainBarPanel.Controls.Add(this.lblTitle);
            this.MainBarPanel.Controls.Add(this.btnMini);
            this.MainBarPanel.Controls.Add(this.btnExit);
            this.MainBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainBarPanel.Location = new System.Drawing.Point(0, 0);
            this.MainBarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainBarPanel.Name = "MainBarPanel";
            this.MainBarPanel.Size = new System.Drawing.Size(1942, 48);
            this.MainBarPanel.TabIndex = 0;
            this.MainBarPanel.DoubleClick += new System.EventHandler(this.MainBarPanel_DoubleClick);
            this.MainBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainBarPanel_MouseDown);
            this.MainBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainBarPanel_MouseMove);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1369, 48);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "PS 파이낸셜 솔루션";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.DoubleClick += new System.EventHandler(this.lblTitle_DoubleClick);
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseDown);
            this.lblTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblTitle_MouseMove);
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackColor = System.Drawing.SystemColors.Control;
            this.btnMini.FlatAppearance.BorderSize = 0;
            this.btnMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMini.Location = new System.Drawing.Point(1839, 0);
            this.btnMini.Margin = new System.Windows.Forms.Padding(4);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(51, 48);
            this.btnMini.TabIndex = 0;
            this.btnMini.Text = "-";
            this.btnMini.UseVisualStyleBackColor = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1891, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 48);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainContentPanel
            // 
            this.MainContentPanel.AutoScroll = true;
            this.MainContentPanel.Controls.Add(this.panel1);
            this.MainContentPanel.Controls.Add(this.pnlWorker);
            this.MainContentPanel.Controls.Add(this.MainButtonPanel);
            this.MainContentPanel.Controls.Add(this.MainTitlePanel);
            this.MainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContentPanel.Location = new System.Drawing.Point(0, 48);
            this.MainContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainContentPanel.Name = "MainContentPanel";
            this.MainContentPanel.Size = new System.Drawing.Size(1942, 1054);
            this.MainContentPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(15, 143);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1631, 895);
            this.panel1.TabIndex = 3;
            // 
            // pnlWorker
            // 
            this.pnlWorker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorker.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnlWorker.Controls.Add(this.lblWorkPositionTXT);
            this.pnlWorker.Controls.Add(this.lblWorkPosition);
            this.pnlWorker.Controls.Add(this.lblWorkDepartmentTXT);
            this.pnlWorker.Controls.Add(this.lblWorkNameTXT);
            this.pnlWorker.Controls.Add(this.lblWorkDepartment);
            this.pnlWorker.Controls.Add(this.lblWorkNumTXT);
            this.pnlWorker.Controls.Add(this.lblWorkName);
            this.pnlWorker.Controls.Add(this.lblWorkNum);
            this.pnlWorker.Controls.Add(this.pictureBox1);
            this.pnlWorker.Location = new System.Drawing.Point(1689, 143);
            this.pnlWorker.Margin = new System.Windows.Forms.Padding(4);
            this.pnlWorker.Name = "pnlWorker";
            this.pnlWorker.Size = new System.Drawing.Size(226, 372);
            this.pnlWorker.TabIndex = 2;
            // 
            // lblWorkPositionTXT
            // 
            this.lblWorkPositionTXT.AutoSize = true;
            this.lblWorkPositionTXT.Location = new System.Drawing.Point(77, 332);
            this.lblWorkPositionTXT.Name = "lblWorkPositionTXT";
            this.lblWorkPositionTXT.Size = new System.Drawing.Size(29, 20);
            this.lblWorkPositionTXT.TabIndex = 3;
            this.lblWorkPositionTXT.Text = "    ";
            // 
            // lblWorkPosition
            // 
            this.lblWorkPosition.AutoSize = true;
            this.lblWorkPosition.Location = new System.Drawing.Point(21, 332);
            this.lblWorkPosition.Name = "lblWorkPosition";
            this.lblWorkPosition.Size = new System.Drawing.Size(47, 20);
            this.lblWorkPosition.TabIndex = 3;
            this.lblWorkPosition.Text = "직책 :";
            // 
            // lblWorkDepartmentTXT
            // 
            this.lblWorkDepartmentTXT.AutoSize = true;
            this.lblWorkDepartmentTXT.Location = new System.Drawing.Point(77, 302);
            this.lblWorkDepartmentTXT.Name = "lblWorkDepartmentTXT";
            this.lblWorkDepartmentTXT.Size = new System.Drawing.Size(29, 20);
            this.lblWorkDepartmentTXT.TabIndex = 3;
            this.lblWorkDepartmentTXT.Text = "    ";
            // 
            // lblWorkNameTXT
            // 
            this.lblWorkNameTXT.AutoSize = true;
            this.lblWorkNameTXT.Location = new System.Drawing.Point(77, 273);
            this.lblWorkNameTXT.Name = "lblWorkNameTXT";
            this.lblWorkNameTXT.Size = new System.Drawing.Size(29, 20);
            this.lblWorkNameTXT.TabIndex = 2;
            this.lblWorkNameTXT.Text = "    ";
            // 
            // lblWorkDepartment
            // 
            this.lblWorkDepartment.AutoSize = true;
            this.lblWorkDepartment.Location = new System.Drawing.Point(21, 302);
            this.lblWorkDepartment.Name = "lblWorkDepartment";
            this.lblWorkDepartment.Size = new System.Drawing.Size(47, 20);
            this.lblWorkDepartment.TabIndex = 3;
            this.lblWorkDepartment.Text = "부서 :";
            // 
            // lblWorkNumTXT
            // 
            this.lblWorkNumTXT.AutoSize = true;
            this.lblWorkNumTXT.Location = new System.Drawing.Point(77, 244);
            this.lblWorkNumTXT.Name = "lblWorkNumTXT";
            this.lblWorkNumTXT.Size = new System.Drawing.Size(29, 20);
            this.lblWorkNumTXT.TabIndex = 1;
            this.lblWorkNumTXT.Text = "    ";
            // 
            // lblWorkName
            // 
            this.lblWorkName.AutoSize = true;
            this.lblWorkName.Location = new System.Drawing.Point(21, 273);
            this.lblWorkName.Name = "lblWorkName";
            this.lblWorkName.Size = new System.Drawing.Size(47, 20);
            this.lblWorkName.TabIndex = 2;
            this.lblWorkName.Text = "이름 :";
            // 
            // lblWorkNum
            // 
            this.lblWorkNum.AutoSize = true;
            this.lblWorkNum.Location = new System.Drawing.Point(21, 244);
            this.lblWorkNum.Name = "lblWorkNum";
            this.lblWorkNum.Size = new System.Drawing.Size(47, 20);
            this.lblWorkNum.TabIndex = 1;
            this.lblWorkNum.Text = "사번 :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainButtonPanel
            // 
            this.MainButtonPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.MainButtonPanel.Controls.Add(this.btnManager);
            this.MainButtonPanel.Controls.Add(this.btnMail);
            this.MainButtonPanel.Controls.Add(this.btnSchedule);
            this.MainButtonPanel.Controls.Add(this.btnPersonal);
            this.MainButtonPanel.Controls.Add(this.btnCustomerManage);
            this.MainButtonPanel.Controls.Add(this.btnContractManage);
            this.MainButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainButtonPanel.Location = new System.Drawing.Point(0, 72);
            this.MainButtonPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainButtonPanel.Name = "MainButtonPanel";
            this.MainButtonPanel.Size = new System.Drawing.Size(1942, 63);
            this.MainButtonPanel.TabIndex = 1;
            // 
            // btnManager
            // 
            this.btnManager.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManager.Location = new System.Drawing.Point(762, 0);
            this.btnManager.Margin = new System.Windows.Forms.Padding(4);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(136, 63);
            this.btnManager.TabIndex = 0;
            this.btnManager.Text = "인사 메뉴";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnMail
            // 
            this.btnMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMail.Location = new System.Drawing.Point(618, 0);
            this.btnMail.Margin = new System.Windows.Forms.Padding(4);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(136, 63);
            this.btnMail.TabIndex = 0;
            this.btnMail.Text = "메일";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSchedule.Location = new System.Drawing.Point(474, 0);
            this.btnSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(136, 63);
            this.btnSchedule.TabIndex = 0;
            this.btnSchedule.Text = "스케쥴";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPersonal.Location = new System.Drawing.Point(330, 0);
            this.btnPersonal.Margin = new System.Windows.Forms.Padding(4);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(136, 63);
            this.btnPersonal.TabIndex = 0;
            this.btnPersonal.Text = "개인 업무";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnCustomerManage
            // 
            this.btnCustomerManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCustomerManage.Location = new System.Drawing.Point(186, 0);
            this.btnCustomerManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomerManage.Name = "btnCustomerManage";
            this.btnCustomerManage.Size = new System.Drawing.Size(136, 63);
            this.btnCustomerManage.TabIndex = 0;
            this.btnCustomerManage.Text = "고객 관리";
            this.btnCustomerManage.UseVisualStyleBackColor = true;
            this.btnCustomerManage.Click += new System.EventHandler(this.btnCustomerManage_Click);
            // 
            // btnContractManage
            // 
            this.btnContractManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContractManage.Location = new System.Drawing.Point(42, 0);
            this.btnContractManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnContractManage.Name = "btnContractManage";
            this.btnContractManage.Size = new System.Drawing.Size(136, 63);
            this.btnContractManage.TabIndex = 0;
            this.btnContractManage.Text = "계약 관리";
            this.btnContractManage.UseVisualStyleBackColor = true;
            this.btnContractManage.Click += new System.EventHandler(this.btnContractManage_Click);
            // 
            // MainTitlePanel
            // 
            this.MainTitlePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTitlePanel.Location = new System.Drawing.Point(0, 0);
            this.MainTitlePanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainTitlePanel.Name = "MainTitlePanel";
            this.MainTitlePanel.Size = new System.Drawing.Size(1942, 72);
            this.MainTitlePanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.MainContentPanel);
            this.Controls.Add(this.MainBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainBarPanel.ResumeLayout(false);
            this.MainContentPanel.ResumeLayout(false);
            this.pnlWorker.ResumeLayout(false);
            this.pnlWorker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainBarPanel;
        private System.Windows.Forms.Panel MainContentPanel;
        private System.Windows.Forms.Panel MainTitlePanel;
        private System.Windows.Forms.Panel MainButtonPanel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnMini;
        private System.Windows.Forms.Panel pnlWorker;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnCustomerManage;
        private System.Windows.Forms.Button btnContractManage;
        private System.Windows.Forms.Label lblWorkPositionTXT;
        private System.Windows.Forms.Label lblWorkPosition;
        private System.Windows.Forms.Label lblWorkDepartmentTXT;
        private System.Windows.Forms.Label lblWorkNameTXT;
        private System.Windows.Forms.Label lblWorkDepartment;
        private System.Windows.Forms.Label lblWorkNumTXT;
        private System.Windows.Forms.Label lblWorkName;
        private System.Windows.Forms.Label lblWorkNum;
    }
}