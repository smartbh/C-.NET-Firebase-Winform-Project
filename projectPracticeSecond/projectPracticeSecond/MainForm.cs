using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectPracticeSecond
{
    public partial class MainForm : Form
    {
        public ManagerData MainFormManagerData;

        public delegate void SetManagerDataCallback(ManagerData Mobj);
        public SetManagerDataCallback setManagerData;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼이 로드 될때 할 작업들.
        /// 만약 로그인한 사원이 인사과나 관리자가 아니면
        /// 관리자 버튼이 보이지 않게 하기.
        /// 사진 로그인한 아이디 이름에 맞는것 띄우기
        /// 사진 아래에 사원 이름, 전화번호 라벨 띄우기.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(MainFormManagerData.administerBool.ToString());
            MessageBox.Show(MainFormManagerData.name.ToString());
            MessageBox.Show(MainFormManagerData.phone.ToString());
            MessageBox.Show(MainFormManagerData.pwd.ToString());
            MessageBox.Show(MainFormManagerData.workDepartment.ToString());
            MessageBox.Show(MainFormManagerData.workerNum.ToString());
            MessageBox.Show(MainFormManagerData.workPosition.ToString());

            lblWorkNumTXT.Text = MainFormManagerData.workerNum.ToString();
            lblWorkNameTXT.Text = MainFormManagerData.name;
            lblWorkDepartmentTXT.Text = MainFormManagerData.workDepartment;
            lblWorkPositionTXT.Text = MainFormManagerData.workPosition;

            if (MainFormManagerData.administerBool) //조건을 MainOBJ를 받아와서 MainOBJ bool 타입이 true인지 false인지.
            {
                btnManager.Visible = true;
                //관리자면 관리자 버튼 보이게
            }
            else
            {
                btnManager.Visible = false;
                //아니면 안보이게
            }
        }

        public void SetManagerData(ManagerData data)
        {
            MainFormManagerData = data;
        }

        private Point mousePoint; //마우스 포인트(이동,최대화용)

        /// <summary>
        /// 프로그램 종료 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region
        /// <summary>
        /// 프로그램 최소화 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion


        /// <summary>
        /// 마우스로 프로그램 이동시키는 부분
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void MainBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void MainBarPanel_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void lblTitle_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }


        //버튼으로 폼 옮겨 다니기

        /// <summary>
        /// 계약관리 폼으로 가는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContractManage_Click(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 고객관리로 가는 폼 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCustomerManage_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            MenuManagementForm ContractManage = new MenuManagementForm();
            ContractManage.TopLevel = false;
            ContractManage.TopMost = true;
            ContractManage.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ContractManage.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(ContractManage);
            ContractManage.Show();

            panel1.Dock = System.Windows.Forms.DockStyle.None;
        }


        /// <summary>
        /// 개인 업무폼 으로 가는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPersonal_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            personalWorkForm personalWorkForm = new personalWorkForm();
            personalWorkForm.TopLevel = false;
            personalWorkForm.TopMost = true;
            personalWorkForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            personalWorkForm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(personalWorkForm);
            personalWorkForm.Show();

        }


        /// <summary>
        /// 스케쥴 관리 폼으로 가는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            personalScheduleForm personalScheduleForm = new personalScheduleForm();
            personalScheduleForm.TopLevel = false;
            personalScheduleForm.TopMost = true;
            personalScheduleForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            personalScheduleForm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(personalScheduleForm);
            personalScheduleForm.Show();
        }

        /// <summary>
        /// 메일 관리로 가는 폼 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMail_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            personalMailWorkForm personalMailWorkForm = new personalMailWorkForm();
            personalMailWorkForm.TopLevel = false;
            personalMailWorkForm.TopMost = true;
            personalMailWorkForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            personalMailWorkForm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(personalMailWorkForm);
            personalMailWorkForm.Show();
        }

        /// <summary>
        /// 관리자 전용 폼으로 가는 버튼
        /// 만약 로그인한 사원이 관리자가 아니면 보이지 않게.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManager_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            managerWorkForm managerWorkForm = new managerWorkForm();
            this.setManagerData += new SetManagerDataCallback(managerWorkForm.SetManagerData);
            setManagerData(MainFormManagerData);

            managerWorkForm.TopLevel = false;
            managerWorkForm.TopMost = true;
            managerWorkForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            managerWorkForm.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Controls.Add(managerWorkForm);
            managerWorkForm.Show();
        }


    }
}
