using Microsoft.Data.SqlClient;
using System.Data;

namespace 转一转校园二手物品交易系统
{
    public partial class FrmLogin : FrmBase
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLoginClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_UserName.Text) || string.IsNullOrEmpty(txt_Pwd.Text))
            {
                ShowTip("请输入用户名和密码");
                return;
            }

            string sql = "SELECT user_id, username, password FROM users WHERE username=@u";
            SqlParameter[] ps = {
                new SqlParameter("@u", txt_UserName.Text.Trim())
            };
            DataTable dt = SQLHelper.Query(sql, ps);

            if (dt.Rows.Count == 0)
            {
                ShowError("用户名或密码错误");
                return;
            }

            object pwdObj = dt.Rows[0]["password"];
            string hash = pwdObj == DBNull.Value ? "" : pwdObj.ToString()!;
            if (string.IsNullOrEmpty(hash) || !BCrypt.Net.BCrypt.Verify(txt_Pwd.Text, hash))
            {
                ShowError("用户名或密码错误");
                return;
            }

            Program.CurrentUserId = Convert.ToInt32(dt.Rows[0]["user_id"]);
            Program.CurrentUserName = dt.Rows[0]["username"]?.ToString() ?? "";

            FrmMain main = new FrmMain();
            main.FormClosed += (s, args) =>
            {
                if (Program.CurrentUserId == 0)
                    this.Show();
                else
                    this.Close();
            };
            main.Show();
            this.Hide();
        }

        private void BtnRegisterClick(object sender, EventArgs e)
        {
            FrmRegister reg = new FrmRegister();
            reg.ShowDialog();
        }

        private void link_ForgotPwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForgotPassword frm = new FrmForgotPassword();
            frm.ShowDialog();
        }
    }
}
