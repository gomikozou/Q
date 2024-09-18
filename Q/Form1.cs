using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Q
{
    public partial class Form1 : Form
    {
        public static int loginOk;
        public static int userCheckNum;
        public Form1()
        {
            InitializeComponent();
            loginOk = 0;
            userCheckNum = 0;

            panel2.Visible = false;
            labelShowUserName.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            DialogResult dr =
                MessageBox.Show("終了しますか？", "確認",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NewCreate newCreate = new NewCreate();
            newCreate.ShowDialog();
            if (loginOk == 1)
            {
                labelShowUserName.Visible = true;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginOk = 0;
            labelShowUserName.Visible = false;
            MessageBox.Show("ログアウトしました");
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Study study = new Study();
            study.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            HardStudy study = new HardStudy();
            study.ShowDialog();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            NormalStudy study = new NormalStudy();
            study.ShowDialog();
        }
    }
}
