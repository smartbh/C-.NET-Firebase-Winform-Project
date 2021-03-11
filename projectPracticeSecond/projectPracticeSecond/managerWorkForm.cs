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

        private void label1_Click(object sender, EventArgs e)
        {

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
                pictureBox1.Image = img.GetThumbnailImage(210,180,null, new IntPtr());
            }
        }

        private async void btnRegist_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();

            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);

            byte[] a = ms.GetBuffer();

            string output = Convert.ToBase64String(a);

            var data = new Image_Modal
            {
                Img = output
            };

            SetResponse response = await managerWorkFormFirebaseClient.SetTaskAsync("manager/010-1111-2222/", data);

            Image_Modal result = response.ResultAs<Image_Modal>();

            MessageBox.Show("이미지 등록됨!");
        }
    }
}
