namespace 转一转校园二手物品交易系统
{
    partial class FrmRegister
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lbl_Title = new Label();
            lbl_UserName = new Label();
            txt_UserName = new TextBox();
            lbl_Pwd = new Label();
            txt_Pwd = new TextBox();
            lbl_ConfirmPwd = new Label();
            txt_ConfirmPwd = new TextBox();
            lbl_Phone = new Label();
            txt_Phone = new TextBox();
            lbl_Email = new Label();
            txt_Email = new TextBox();
            btn_Submit = new Button();
            btn_Cancel = new Button();
            lbl_Tip = new Label();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            lbl_Title.Location = new Point(534, 100);
            lbl_Title.Margin = new Padding(5, 0, 5, 0);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(110, 31);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "用户注册";
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.Location = new Point(366, 184);
            lbl_UserName.Margin = new Padding(5, 0, 5, 0);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(82, 24);
            lbl_UserName.TabIndex = 1;
            lbl_UserName.Text = "用户名：";
            lbl_UserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(501, 180);
            txt_UserName.Margin = new Padding(5, 4, 5, 4);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(312, 30);
            txt_UserName.TabIndex = 2;
            // 
            // lbl_Pwd
            // 
            lbl_Pwd.AutoSize = true;
            lbl_Pwd.Location = new Point(366, 241);
            lbl_Pwd.Margin = new Padding(5, 0, 5, 0);
            lbl_Pwd.Name = "lbl_Pwd";
            lbl_Pwd.Size = new Size(64, 24);
            lbl_Pwd.TabIndex = 3;
            lbl_Pwd.Text = "密码：";
            lbl_Pwd.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Pwd
            // 
            txt_Pwd.Location = new Point(501, 236);
            txt_Pwd.Margin = new Padding(5, 4, 5, 4);
            txt_Pwd.Name = "txt_Pwd";
            txt_Pwd.PasswordChar = '*';
            txt_Pwd.Size = new Size(312, 30);
            txt_Pwd.TabIndex = 4;
            // 
            // lbl_ConfirmPwd
            // 
            lbl_ConfirmPwd.AutoSize = true;
            lbl_ConfirmPwd.Location = new Point(366, 297);
            lbl_ConfirmPwd.Margin = new Padding(5, 0, 5, 0);
            lbl_ConfirmPwd.Name = "lbl_ConfirmPwd";
            lbl_ConfirmPwd.Size = new Size(100, 24);
            lbl_ConfirmPwd.TabIndex = 5;
            lbl_ConfirmPwd.Text = "确认密码：";
            lbl_ConfirmPwd.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_ConfirmPwd
            // 
            txt_ConfirmPwd.Location = new Point(501, 293);
            txt_ConfirmPwd.Margin = new Padding(5, 4, 5, 4);
            txt_ConfirmPwd.Name = "txt_ConfirmPwd";
            txt_ConfirmPwd.PasswordChar = '*';
            txt_ConfirmPwd.Size = new Size(312, 30);
            txt_ConfirmPwd.TabIndex = 6;
            // 
            // lbl_Phone
            // 
            lbl_Phone.AutoSize = true;
            lbl_Phone.Location = new Point(366, 353);
            lbl_Phone.Margin = new Padding(5, 0, 5, 0);
            lbl_Phone.Name = "lbl_Phone";
            lbl_Phone.Size = new Size(82, 24);
            lbl_Phone.TabIndex = 7;
            lbl_Phone.Text = "手机号：";
            lbl_Phone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(501, 349);
            txt_Phone.Margin = new Padding(5, 4, 5, 4);
            txt_Phone.MaxLength = 11;
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(312, 30);
            txt_Phone.TabIndex = 8;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(366, 409);
            lbl_Email.Margin = new Padding(5, 0, 5, 0);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new Size(64, 24);
            lbl_Email.TabIndex = 9;
            lbl_Email.Text = "邮箱：";
            lbl_Email.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(501, 405);
            txt_Email.Margin = new Padding(5, 4, 5, 4);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(312, 30);
            txt_Email.TabIndex = 10;
            // 
            // btn_Submit
            // 
            btn_Submit.Location = new Point(438, 480);
            btn_Submit.Margin = new Padding(5, 4, 5, 4);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(126, 42);
            btn_Submit.TabIndex = 11;
            btn_Submit.Text = "注册";
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += BtnSubmitClick;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(614, 480);
            btn_Cancel.Margin = new Padding(5, 4, 5, 4);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(126, 42);
            btn_Cancel.TabIndex = 12;
            btn_Cancel.Text = "取消";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += BtnCancelClick;
            // 
            // lbl_Tip
            // 
            lbl_Tip.AutoSize = true;
            lbl_Tip.ForeColor = Color.Red;
            lbl_Tip.Location = new Point(534, 494);
            lbl_Tip.Margin = new Padding(5, 0, 5, 0);
            lbl_Tip.Name = "lbl_Tip";
            lbl_Tip.Size = new Size(0, 24);
            lbl_Tip.TabIndex = 13;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1178, 744);
            Controls.Add(lbl_Tip);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Submit);
            Controls.Add(txt_Email);
            Controls.Add(lbl_Email);
            Controls.Add(txt_Phone);
            Controls.Add(lbl_Phone);
            Controls.Add(txt_ConfirmPwd);
            Controls.Add(lbl_ConfirmPwd);
            Controls.Add(txt_Pwd);
            Controls.Add(lbl_Pwd);
            Controls.Add(txt_UserName);
            Controls.Add(lbl_UserName);
            Controls.Add(lbl_Title);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmRegister";
            Text = "用户注册";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Title;
        private Label lbl_UserName;
        private TextBox txt_UserName;
        private Label lbl_Pwd;
        private TextBox txt_Pwd;
        private Label lbl_ConfirmPwd;
        private TextBox txt_ConfirmPwd;
        private Label lbl_Phone;
        private TextBox txt_Phone;
        private Label lbl_Email;
        private TextBox txt_Email;
        private Button btn_Submit;
        private Button btn_Cancel;
        private Label lbl_Tip;
    }
}
