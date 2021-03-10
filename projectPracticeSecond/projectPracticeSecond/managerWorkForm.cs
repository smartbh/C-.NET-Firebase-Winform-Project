using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projectPracticeSecond
{
    public partial class managerWorkForm : Form
    {
        public ManagerData managerWorkFormManagerData;

        public managerWorkForm()
        {
            InitializeComponent();
        }

        public void SetManagerData(ManagerData data)
        {
            managerWorkFormManagerData = data;
        }

        private void managerWorkForm_Load(object sender, EventArgs e)
        {

        }
    }
}
