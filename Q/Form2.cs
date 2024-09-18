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
    public partial class NewCreate : Form
    {
        string[] UserInfo;

        public NewCreate()
        {
            InitializeComponent();

            UserInfo = new string[2];
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            UserInfo[0] = tbUserName.Text;
            UserInfo[1] = tbPassword.Text;

            if (userIdCheck(UserInfo))
            {
                if (tbPassword.Text == UserInfo[1])
                {
                    MessageBox.Show("ログインしました");
                    Form1.loginOk = 1;
                    Form1.userCheckNum = 1;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("パスワードエラー");
                }

            }
            else
            {
                MessageBox.Show("ユーザIDなし");
            }
        }

        private bool userIdCheck(string[] array2)
        {
            bool rc = true;

            SQLiteConnection con;
            SQLiteCommand com;
            SQLiteDataReader sdr;

            string sql;

            using (con = new SQLiteConnection("Data Source=UserDB.db"))
            {
                con.Open();

                sql = "SELECT name,pass FROM UserTbl WHERE name = '" +
                     array2[0] + "';";

                com = new SQLiteCommand(sql, con);
                sdr = com.ExecuteReader();

                if (!sdr.HasRows)
                {
                    rc = false;
                }
                else
                {
                    rc = true;
                    sdr.Read();

                    array2[0] = sdr["name"].ToString();
                    array2[1] = sdr["pass"].ToString();

                }

                sdr.Close();
            }

            return rc;
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSignUp_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
