using Microsoft.Data.SqlClient;
using System.Text.RegularExpressions;

namespace 转一转校园二手物品交易系统
{
    public partial class FrmForgotPassword : FrmBase
    {
        private string? _currentEmail;

        public FrmForgotPassword()
        {
            InitializeComponent();
        }

        private async void btn_SendCode_Click(object sender, EventArgs e)
        {
            string email = txt_Email.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                lbl_Tip.Text = "请输入邮箱地址";
                return;
            }
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                lbl_Tip.Text = "邮箱格式不正确";
                return;
            }

            string checkSql = "SELECT COUNT(*) FROM users WHERE email=@em";
            SqlParameter[] checkPs = { new SqlParameter("@em", email) };
            int exists = (int)SQLHelper.Scalar(checkSql, checkPs);
            if (exists == 0)
            {
                lbl_Tip.Text = "该邮箱未注册";
                return;
            }

            var (code, error) = VerificationCodeStore.Generate(email);
            if (error != null)
            {
                lbl_Tip.Text = error;
                return;
            }

            btn_SendCode.Enabled = false;
            btn_SendCode.Text = "发送中...";

            var (ok, msg) = await EmailHelper.SendCodeAsync(email, code!);
            if (ok)
            {
                _currentEmail = email;
                lbl_Tip.Text = "";
                panel1.Visible = false;
                panel2.Visible = true;
                lbl_StepIndicator.Text = "✅ 验证邮箱  →  ② 验证身份  →  ③ 重置密码";
            }
            else
            {
                lbl_Tip.Text = msg;
                VerificationCodeStore.Invalidate(email);
            }

            btn_SendCode.Enabled = true;
            btn_SendCode.Text = "发送验证码";
        }

        private void btn_Verify_Click(object sender, EventArgs e)
        {
            if (_currentEmail == null) return;

            string code = txt_Code.Text.Trim();
            if (string.IsNullOrWhiteSpace(code))
            {
                lbl_Tip.Text = "请输入验证码";
                return;
            }

            var result = VerificationCodeStore.Verify(_currentEmail, code);
            switch (result)
            {
                case VerifyResult.Success:
                    lbl_Tip.Text = "";
                    panel2.Visible = false;
                    panel3.Visible = true;
                    lbl_StepIndicator.Text = "✅ 验证邮箱  →  ✅ 验证身份  →  ③ 重置密码";
                    break;
                case VerifyResult.Expired:
                    lbl_Tip.Text = "验证码已过期，请重新发送";
                    break;
                case VerifyResult.Invalid:
                    lbl_Tip.Text = "验证码错误";
                    break;
            }
        }

        private void btn_ResetPwd_Click(object sender, EventArgs e)
        {
            if (_currentEmail == null) return;

            string newPwd = txt_NewPwd.Text;
            string confirmPwd = txt_ConfirmPwd.Text;

            if (string.IsNullOrWhiteSpace(newPwd))
            {
                lbl_Tip.Text = "请输入新密码";
                return;
            }
            if (newPwd != confirmPwd)
            {
                lbl_Tip.Text = "两次密码输入不一致";
                return;
            }

            string hash = BCrypt.Net.BCrypt.HashPassword(newPwd);
            string sql = "UPDATE users SET password=@p WHERE email=@em";
            SqlParameter[] ps = {
                new SqlParameter("@p", hash),
                new SqlParameter("@em", _currentEmail)
            };
            SQLHelper.Exec(sql, ps);

            ShowTip("密码重置成功，请重新登录");
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (_currentEmail != null)
                VerificationCodeStore.Invalidate(_currentEmail);
            base.OnFormClosing(e);
        }
    }
}
