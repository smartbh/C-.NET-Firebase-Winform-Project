using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;


namespace projectPracticeSecond
{
    public partial class Login : Form
    {
        public delegate void SetManagerDataCallback(ManagerData Mdata);
        public SetManagerDataCallback setManagerData;

        public delegate void SetFirebaseClientCallback(IFirebaseClient firebaseClient);
        public SetFirebaseClientCallback setFirebaseClient;

        static private IFirebaseConfig config = new FirebaseConfig //파이어베이스 연결 아이디
        {
            AuthSecret = "NkgJnHYTWNn4JK3UP0D1kOo5fUGzoys6DFRBXrlf",
            BasePath = "https://fir-99bb4.firebaseio.com/"
        };

        static private IFirebaseClient client; //파이어베이스 데이터(전역)
        static private FirebaseResponse ManagerResponse; //파이어베이스 매니저 데이터
        static private FirebaseResponse ContractResponse; //파이어베이스 계약 데이터

        static private Point mousePoint;
        static private string log_id = string.Empty;
        static private string log_pw = string.Empty;
        static private ManagerData ManagerObj; //관리자 데이터
        static private ContractData ContractDataObj; //파이어베이스 계약 데이터

        /// <summary>
        /// 관리자 데이터, 매니저 데이터, 계약 데이터는
        /// 로그인 시 다음 폼으로 보내야 한다.
        /// Login -> MainForm -> 그외 다수 폼으로
        /// </summary>

        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼 로드, async 삭제해봄
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            //client = null;

            //파이어베이스 계정에 로그인. 특정키가 필요
            if (config.AuthSecret.Equals("NkgJnHYTWNn4JK3UP0D1kOo5fUGzoys6DFRBXrlf") &&
                config.BasePath.Equals("https://fir-99bb4.firebaseio.com/"))
            {
                MessageBox.Show("파이어베이스 연결 성공!");
            }
            else
            {
                MessageBox.Show("파이어베이스 연결 실패!\r\n권한 아이디를 확인해주세요!");
                Application.Exit();
            }
                
        }

        /// <summary>
        /// 윈도우 폼 기능 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void button1_Click(object sender, EventArgs e) //프로그램 종료
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) //프로그램 최소화
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        /// <summary>
        /// 로그인 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            ManagerResponse = await client.GetTaskAsync("manager/" + login_ID.Text); //매니저 데이터 받아오기
            ContractResponse = await client.GetTaskAsync("contract_list/");

            if (ManagerResponse.Body != "null")
            {
                ManagerObj = ManagerResponse.ResultAs<ManagerData>(); //매니저 데이터를 객체에 집어넣기
                //ContractDataObj = ContractResponse.ResultAs<ContractData>();//계약 데이터를 객체에 집어넣기
                ContractDataObj = JsonConvert.DeserializeObject<ContractData>(ContractResponse.Body.ToString());

                #region
                MessageBox.Show(ManagerResponse.Body.ToString());
                MessageBox.Show(ManagerObj.ToString());
                MessageBox.Show(ManagerObj.name.ToString());
                MessageBox.Show(ManagerObj.pwd.ToString());
                MessageBox.Show(ManagerObj.phone.ToString());
                MessageBox.Show(ManagerObj.administerBool.ToString());
                MessageBox.Show(ManagerObj.Img.ToString());

                MessageBox.Show(ContractResponse.Body.ToString());
                MessageBox.Show(ContractDataObj.ToString());
                MessageBox.Show(ContractDataObj.GetType().ToString());
                //MessageBox.Show(ContractDataObj.고객명.ToString());
                //MessageBox.Show(ContractDataObj.누적체결금액.ToString());
                //MessageBox.Show(ContractDataObj.담당자명.ToString());
                //MessageBox.Show(ContractDataObj.담당자전화번호.ToString());
                //MessageBox.Show(ContractDataObj.만기날짜.ToString());
                //MessageBox.Show(ContractDataObj.상품명.ToString());
                //MessageBox.Show(ContractDataObj.은행계좌번호.ToString());
                //MessageBox.Show(ContractDataObj.입금날짜.ToString());
                //MessageBox.Show(ContractDataObj.전화번호.ToString());
                //MessageBox.Show(ContractDataObj.체결금액.ToString());
                #endregion

                if (ManagerObj.pwd.Equals(login_Pw.Text))
                {


                    MessageBox.Show("로그인 되었습니다!");
                    this.Visible = false;

                    //메인폼 불러오기
                    MainForm mainForm = new MainForm();
                    this.setManagerData += new SetManagerDataCallback(mainForm.SetManagerData);
                    setManagerData(ManagerObj);

                    this.setFirebaseClient += new SetFirebaseClientCallback(mainForm.SetClientData);
                    setFirebaseClient(client);

                    mainForm.ShowDialog();
                    this.Close();
                    //Application.Exit();
                }
                else
                {
                    MessageBox.Show("비밀번호가 맞지 않습니다!");
                }
            }
            else
                MessageBox.Show("아이디 또는 비밀번호가 맞지 않습니다!");
        }

        /// <summary>
        /// 텍스트 박스 선택시
        /// 배경색 전환
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void login_IDClick(object sender, EventArgs e)//텍스트 박스 선택시
        {
            login_ID.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel5.BackColor = SystemColors.Control;
            login_Pw.BackColor = SystemColors.Control;
        }

        private void login_PwClick(object sender, EventArgs e)
        {
            login_Pw.BackColor = Color.White;
            panel5.BackColor = Color.White;
            panel3.BackColor = SystemColors.Control;
            login_ID.BackColor = SystemColors.Control;
        }
        #endregion

        /// <summary>
        /// 비밀번호 이미지를 누르면 비밀번호가 보이게
        /// 혹시라도 오타를 낼 경우
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_PW_MouseDown(object sender, MouseEventArgs e)
        {
            login_Pw.UseSystemPasswordChar = false;
        }

        private void pic_PW_MouseUp(object sender, MouseEventArgs e)
        {
            login_Pw.UseSystemPasswordChar = true;
        }


        /// <summary>
        /// 회원가입해서 파이어베이스에
        /// 데이터넣기
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnRegist_Click(object sender, EventArgs e)
        {
            var mdata = new ManagerData
            {
                name = string.Empty,
                pwd = login_Pw.Text
            };

            SetResponse response = await client.SetTaskAsync("manager/"+login_ID.Text, mdata);
            ManagerData result = response.ResultAs<ManagerData>();

            MessageBox.Show("Data Inserted " + result.phone);

        }



        /// <summary>
        /// 마우스로 프로그램 이동하는 코드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region
        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void panel6_DoubleClick(object sender, EventArgs e) //크기 최대화, 노멀화
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

        #endregion
    }
}
