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
            btn_Submit = new Button();
            btn_Cancel = new Button();
            lbl_Tip = new Label();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            lbl_Title.Location = new Point(350, 30);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(76, 22);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "用户注册";
            // 
            // lbl_UserName
            // 
            lbl_UserName.AutoSize = true;
            lbl_UserName.Location = new Point(270, 90);
            lbl_UserName.Name = "lbl_UserName";
            lbl_UserName.Size = new Size(60, 17);
            lbl_UserName.TabIndex = 1;
            lbl_UserName.Text = "用户名：";
            lbl_UserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_UserName
            // 
            txt_UserName.Location = new Point(340, 87);
            txt_UserName.Name = "txt_UserName";
            txt_UserName.Size = new Size(200, 23);
            txt_UserName.TabIndex = 2;
            // 
            // lbl_Pwd
            // 
            lbl_Pwd.AutoSize = true;
            lbl_Pwd.Location = new Point(270, 130);
            lbl_Pwd.Name = "lbl_Pwd";
            lbl_Pwd.Size = new Size(44, 17);
            lbl_Pwd.TabIndex = 3;
            lbl_Pwd.Text = "密码：";
            lbl_Pwd.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Pwd
            // 
            txt_Pwd.Location = new Point(340, 127);
            txt_Pwd.Name = "txt_Pwd";
            txt_Pwd.PasswordChar = '*';
            txt_Pwd.Size = new Size(200, 23);
            txt_Pwd.TabIndex = 4;
            // 
            // lbl_ConfirmPwd
            // 
            lbl_ConfirmPwd.AutoSize = true;
            lbl_ConfirmPwd.Location = new Point(254, 170);
            lbl_ConfirmPwd.Name = "lbl_ConfirmPwd";
            lbl_ConfirmPwd.Size = new Size(76, 17);
            lbl_ConfirmPwd.TabIndex = 5;
            lbl_ConfirmPwd.Text = "确认密码：";
            lbl_ConfirmPwd.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_ConfirmPwd
            // 
            txt_ConfirmPwd.Location = new Point(340, 167);
            txt_ConfirmPwd.Name = "txt_ConfirmPwd";
            txt_ConfirmPwd.PasswordChar = '*';
            txt_ConfirmPwd.Size = new Size(200, 23);
            txt_ConfirmPwd.TabIndex = 6;
            // 
            // lbl_Phone
            // 
            lbl_Phone.AutoSize = true;
            lbl_Phone.Location = new Point(254, 210);
            lbl_Phone.Name = "lbl_Phone";
            lbl_Phone.Size = new Size(60, 17);
            lbl_Phone.TabIndex = 7;
            lbl_Phone.Text = "手机号：";
            lbl_Phone.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txt_Phone
            // 
            txt_Phone.Location = new Point(340, 207);
            txt_Phone.Name = "txt_Phone";
            txt_Phone.Size = new Size(200, 23);
            txt_Phone.TabIndex = 8;
            txt_Phone.MaxLength = 11;
            // 
            // btn_Submit
            // 
            btn_Submit.Location = new Point(300, 260);
            btn_Submit.Name = "btn_Submit";
            btn_Submit.Size = new Size(80, 30);
            btn_Submit.TabIndex = 9;
            btn_Submit.Text = "注册";
            btn_Submit.UseVisualStyleBackColor = true;
            btn_Submit.Click += BtnSubmitClick;
            // 
            // btn_Cancel
            // 
            btn_Cancel.Location = new Point(412, 260);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(80, 30);
            btn_Cancel.TabIndex = 10;
            btn_Cancel.Text = "取消";
            btn_Cancel.UseVisualStyleBackColor = true;
            btn_Cancel.Click += BtnCancelClick;
            // 
            // lbl_Tip
            // 
            lbl_Tip.AutoSize = true;
            lbl_Tip.ForeColor = Color.Red;
            lbl_Tip.Location = new Point(340, 310);
            lbl_Tip.Name = "lbl_Tip";
            lbl_Tip.Size = new Size(0, 17);
            lbl_Tip.TabIndex = 11;
            // 
            // FrmRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_Tip);
            Controls.Add(btn_Cancel);
            Controls.Add(btn_Submit);
            Controls.Add(txt_Phone);
            Controls.Add(lbl_Phone);
            Controls.Add(txt_ConfirmPwd);
            Controls.Add(lbl_ConfirmPwd);
            Controls.Add(txt_Pwd);
            Controls.Add(lbl_Pwd);
            Controls.Add(txt_UserName);
            Controls.Add(lbl_UserName);
            Controls.Add(lbl_Title);
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
        private Button btn_Submit;
        private Button btn_Cancel;
        private Label lbl_Tip;
    }
}
