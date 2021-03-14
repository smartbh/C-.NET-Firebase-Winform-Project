using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace projectPracticeSecond
{
    public partial class managerWorkForm : Form
    {
        public ManagerData managerWorkFormManagerData;
        public static IFirebaseClient managerWorkFormFirebaseClient;
        
        public managerWorkForm()
        {
            InitializeComponent();
        }

        public void SetManagerData(ManagerData data)
        {
            managerWorkFormManagerData = data;
        }

        public void SetClientData(IFirebaseClient Cobj)
        {
            managerWorkFormFirebaseClient = Cobj;
        }

        private void managerWorkForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(managerWorkFormManagerData.name);
            //MessageBox.Show(managerWorkFormManagerData.phone);
            //MessageBox.Show(managerWorkFormManagerData.pwd);
            //MessageBox.Show(managerWorkFormManagerData.workDepartment);
            //MessageBox.Show(managerWorkFormManagerData.workerNum.ToString());
            //MessageBox.Show(managerWorkFormManagerData.workPosition);
            //MessageBox.Show(managerWorkFormManagerData.administerBool.ToString());

            MessageBox.Show(managerWorkFormFirebaseClient.ToString());
        }

        private void btnImgLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "불러올 이미지를 선택해 주세요.";
            openFileDialog.Filter = "이미지 파일(*.jpg)| *.jpg|이미지 파일(*.png)|*.png";
            //"텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*"

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(openFileDialog.FileName);
                picThumbnail.Image = img.GetThumbnailImage(210,180,null, new IntPtr());
            }
        }

        private async void btnRegist_Click(object sender, EventArgs e)
        {
            bool isItAdmin;
            //이미지를 등록하는 코드
            #region
            MemoryStream ms = new MemoryStream();

            picThumbnail.Image.Save(ms, ImageFormat.Jpeg);

            byte[] a = ms.GetBuffer();

            string output = Convert.ToBase64String(a);

            var data = new Image_Modal
            {
                Img = output
            };

            //SetResponse response = await managerWorkFormFirebaseClient.SetTaskAsync("manager/010-1111-2222/", data);

            //Image_Modal ImgResult = response.ResultAs<Image_Modal>();

            MessageBox.Show("이미지 등록됨!");
            #endregion

            ManagerData NewWorker = new ManagerData
            {
                name = tBoxName.Text,
                phone = tBoxPhone.Text,
                pwd = tBoxPWD.Text,
                Img = data.Img.ToString(),
                administerBool = isItAdmin = (tBoxIsAdmin.Text.Equals("관리자")) ? true : false,
                workerNum = int.Parse(tBoxWorkerNum.Text),
                workDepartment = tBoxDepartment.Text,
                workPosition = tBoxPosition.Text
            };

            SetResponse RegistNewWorkerResponse = await managerWorkFormFirebaseClient.SetTaskAsync("manager/" + tBoxPhone.Text, NewWorker);
            ManagerData result = RegistNewWorkerResponse.ResultAs<ManagerData>();
        }

        //수정할 사원찾기 (전화번호)
        private async void btnModify_Click(object sender, EventArgs e)
        {
            string SearchWorkerNum;
            SearchWorkerNum = tboxSearch.Text;

            FirebaseResponse WorkerResponse = await managerWorkFormFirebaseClient.GetTaskAsync("manager/" + SearchWorkerNum);
            ManagerData FindManagerData = WorkerResponse.ResultAs<ManagerData>();

            tBoxName.Text = FindManagerData.name;
            tBoxPhone.Text = FindManagerData.phone;
            tBoxPWD.Text = FindManagerData.pwd;
            //관리자 확인
            if (FindManagerData.administerBool)
            {
                tBoxIsAdmin.SelectedIndex = 0; //관리자
            }
            else
            {
                tBoxIsAdmin.SelectedIndex = 1; //평사원
            }

            tBoxWorkerNum.Text = FindManagerData.workerNum.ToString();

            //부서
            switch (FindManagerData.workDepartment)
            {
                case "부서1" :
                    tBoxDepartment.SelectedIndex = 0;
                    break;
                case "부서2":
                    tBoxDepartment.SelectedIndex = 1;
                    break;
                case "부서3":
                    tBoxDepartment.SelectedIndex = 2;
                    break;
                case "부서4":
                    tBoxDepartment.SelectedIndex = 3;
                    break;
                case "부서5":
                    tBoxDepartment.SelectedIndex = 4;
                    break;
                case "부서6":
                    tBoxDepartment.SelectedIndex = 5;
                    break;
            }

            tBoxPosition.Text = FindManagerData.workPosition;

            //이미지
            #region
            byte[] imgByte = Convert.FromBase64String(FindManagerData.Img);

            MemoryStream ImgMs = new MemoryStream();

            ImgMs.Write(imgByte, 0, Convert.ToInt32(imgByte.Length));

            Bitmap ThumbnailBitmap = new Bitmap(ImgMs, false);

            ImgMs.Dispose();

            picThumbnail.Image = ThumbnailBitmap;
            #endregion

        }

        //사원 정보 삭제
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string SearchWorkerNum;
            SearchWorkerNum = tboxSearch.Text;

            FirebaseResponse WorkerResponse = await managerWorkFormFirebaseClient.DeleteTaskAsync("manager/" + SearchWorkerNum);
        }
    }
}
