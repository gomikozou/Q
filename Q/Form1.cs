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
            labelShowUserName.Text = "ログインしていません";
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
                labelShowUserName.Text = "ログインしています";
            }
            else
            {
                labelShowUserName.Text = "ログインしていません";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginOk = 0;
            labelShowUserName.Text = "ログインしていません";
            MessageBox.Show("ログアウトしました");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }


        private void btnEasy_Click(object sender, EventArgs e)
        {
            List<string> question = new List<string> { "1 + 1 = ?", "2 × 8 = ?", "8 ÷ 4 = ?", "太陽の読み方は？", "川の読み方は？" };
            List<string> answer = new List<string> { "2", "16", "2", "たいよう", "かわ" };
            Study study = new Study(question, answer);
            study.ShowDialog();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            List<string> question = new List<string> { "89 + 507 = ?" , "20 × 8 = ?", "200 ÷ 4 = ?","容赦の読み方は？", "罪業の読み方は？" };
            List<string> answer = new List<string> { "596", "160", "50", "ようしゃ", "ざいごう" };
            Study study = new Study(question, answer);
            study.ShowDialog();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            List<string> question = new List<string> { "378 + 5894 = ?", "367 × 47 = ?", "336 ÷ 12 = ?", "梲の読み方は？", "偶の読み方は？" };
            List<string> answer = new List<string> { "6272", "17249", "28", "うだつ", "たまたま" };
            Study study = new Study(question, answer);
            study.ShowDialog();
        }

    }
}
