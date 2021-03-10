using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;

namespace projectPracticeSecond
{
    public partial class MenuManagementForm : Form
    {
        IFirebaseConfig config = new FirebaseConfig //파이어베이스 연결 아이디
        {
            AuthSecret = "NkgJnHYTWNn4JK3UP0D1kOo5fUGzoys6DFRBXrlf",
            BasePath = "https://fir-99bb4.firebaseio.com/"
        };

        static IFirebaseClient client;

        public MenuManagementForm()
        {
            InitializeComponent();

        }

        private void MenuManagementForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("파이어베이스 코드에 문제가 있습니다. 확인해주세요");
                Application.Exit();

            }

            FirebaseResponse firebaseResponse = client.Get(@"contract_list");
            MessageBox.Show(firebaseResponse.Body.ToString());
            Dictionary<string, List<ContractData>> data = JsonConvert.DeserializeObject<Dictionary<string, List<ContractData>>>(firebaseResponse.Body.ToString());

            fillTheCell(data);
        }

        private void fillTheCell(Dictionary<string, List<ContractData>> record)
        {
            advancedDataGridView1.Rows.Clear();

            foreach(var item in record)
            {
                foreach (var each in item.Value)
                {
                    advancedDataGridView1.Rows.Add(each.고객명, each.누적체결금액, each.담당자명, each.담당자전화번호, each.만기날짜,
    each.상품명, each.은행계좌번호, each.입금날짜, each.전화번호, each.체결금액);
                }
            }
        }

    }
}
