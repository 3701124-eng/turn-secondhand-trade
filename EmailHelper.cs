using System.Configuration;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace 转一转校园二手物品交易系统
{
    internal class EmailHelper
    {
        public static async Task<(bool success, string message)> SendCodeAsync(string toEmail, string code)
        {
            try
            {
                string host = ConfigurationManager.AppSettings["SmtpHost"] ?? "";
                int port = int.Parse(ConfigurationManager.AppSettings["SmtpPort"] ?? "587");
                string user = ConfigurationManager.AppSettings["SmtpUser"] ?? "";
                string pass = ConfigurationManager.AppSettings["SmtpPass"] ?? "";
                string from = ConfigurationManager.AppSettings["SmtpFrom"] ?? "";

                var msg = new MimeMessage();
                msg.From.Add(new MailboxAddress("转一转校园二手交易系统", from));
                msg.To.Add(new MailboxAddress("", toEmail));
                msg.Subject = "密码重置验证码";
                msg.Body = new TextPart("plain")
                {
                    Text = $"您好！\n\n您的验证码是：{code}，有效期 5 分钟。\n如非本人操作，请忽略此邮件。"
                };

                using var client = new SmtpClient();
                await client.ConnectAsync(host, port, SecureSocketOptions.StartTls);
                await client.AuthenticateAsync(user, pass);
                await client.SendAsync(msg);
                await client.DisconnectAsync(true);

                return (true, "验证码已发送到您的邮箱");
            }
            catch (AuthenticationException)
            {
                return (false, "邮箱配置错误，请联系管理员");
            }
            catch (SmtpCommandException ex)
            {
                return (false, $"SMTP 服务器拒绝：{ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"发送失败：{ex.Message}");
            }
        }
    }
}
