namespace 转一转校园二手物品交易系统
{
    partial class FrmForgotPassword
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lbl_Title = new Label();
            lbl_StepIndicator = new Label();
            panel1 = new Panel();
            btn_SendCode = new Button();
            txt_Email = new TextBox();
            lbl_Email = new Label();
            panel2 = new Panel();
            btn_Verify = new Button();
            txt_Code = new TextBox();
            lbl_CodeTitle = new Label();
            panel3 = new Panel();
            btn_ResetPwd = new Button();
            txt_ConfirmPwd = new TextBox();
            lbl_ConfirmPwd = new Label();
            txt_NewPwd = new TextBox();
            lbl_NewPwd = new Label();
            lbl_Tip = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            lbl_Title.Location = new Point(267, 30);
            lbl_Title.Size = new Size(110, 31);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "找回密码";
            // 
            // lbl_StepIndicator
            // 
            lbl_StepIndicator.AutoSize = true;
            lbl_StepIndicator.Font = new Font("Microsoft YaHei UI", 9F);
            lbl_StepIndicator.ForeColor = Color.Gray;
            lbl_StepIndicator.Location = new Point(85, 80);
            lbl_StepIndicator.Size = new Size(481, 24);
            lbl_StepIndicator.TabIndex = 1;
            lbl_StepIndicator.Text = "① 验证邮箱  →  ② 验证身份  →  ③ 重置密码";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_SendCode);
            panel1.Controls.Add(txt_Email);
            panel1.Controls.Add(lbl_Email);
            panel1.Location = new Point(50, 125);
            panel1.Size = new Size(550, 200);
            panel1.TabIndex = 2;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Location = new Point(35, 45);
            lbl_Email.Size = new Size(100, 24);
            lbl_Email.TabIndex = 0;
            lbl_Email.Text = "注册邮箱：";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(145, 42);
            txt_Email.Size = new Size(310, 30);
            txt_Email.TabIndex = 1;
            // 
            // btn_SendCode
            // 
            btn_SendCode.BackColor = SystemColors.Highlight;
            btn_SendCode.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btn_SendCode.ForeColor = Color.White;
            btn_SendCode.Location = new Point(180, 105);
            btn_SendCode.Size = new Size(180, 45);
            btn_SendCode.TabIndex = 2;
            btn_SendCode.Text = "发送验证码";
            btn_SendCode.UseVisualStyleBackColor = false;
            btn_SendCode.Click += btn_SendCode_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_Verify);
            panel2.Controls.Add(txt_Code);
            panel2.Controls.Add(lbl_CodeTitle);
            panel2.Location = new Point(50, 125);
            panel2.Size = new Size(550, 200);
            panel2.TabIndex = 3;
            panel2.Visible = false;
            // 
            // lbl_CodeTitle
            // 
            lbl_CodeTitle.AutoSize = true;
            lbl_CodeTitle.Location = new Point(35, 25);
            lbl_CodeTitle.Size = new Size(244, 24);
            lbl_CodeTitle.TabIndex = 0;
            lbl_CodeTitle.Text = "验证码已发送至您的注册邮箱";
            // 
            // txt_Code
            // 
            txt_Code.Font = new Font("Microsoft YaHei UI", 14F, FontStyle.Bold);
            txt_Code.Location = new Point(145, 55);
            txt_Code.Size = new Size(200, 42);
            txt_Code.TabIndex = 1;
            txt_Code.TextAlign = HorizontalAlignment.Center;
            // 
            // btn_Verify
            // 
            btn_Verify.BackColor = SystemColors.Highlight;
            btn_Verify.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btn_Verify.ForeColor = Color.White;
            btn_Verify.Location = new Point(180, 120);
            btn_Verify.Size = new Size(130, 42);
            btn_Verify.TabIndex = 2;
            btn_Verify.Text = "验证";
            btn_Verify.UseVisualStyleBackColor = false;
            btn_Verify.Click += btn_Verify_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_ResetPwd);
            panel3.Controls.Add(txt_ConfirmPwd);
            panel3.Controls.Add(lbl_ConfirmPwd);
            panel3.Controls.Add(txt_NewPwd);
            panel3.Controls.Add(lbl_NewPwd);
            panel3.Location = new Point(50, 125);
            panel3.Size = new Size(550, 200);
            panel3.TabIndex = 4;
            panel3.Visible = false;
            // 
            // lbl_NewPwd
            // 
            lbl_NewPwd.AutoSize = true;
            lbl_NewPwd.Location = new Point(35, 30);
            lbl_NewPwd.Size = new Size(82, 24);
            lbl_NewPwd.TabIndex = 0;
            lbl_NewPwd.Text = "新密码：";
            // 
            // txt_NewPwd
            // 
            txt_NewPwd.Location = new Point(145, 27);
            txt_NewPwd.PasswordChar = '*';
            txt_NewPwd.Size = new Size(310, 30);
            txt_NewPwd.TabIndex = 1;
            // 
            // lbl_ConfirmPwd
            // 
            lbl_ConfirmPwd.AutoSize = true;
            lbl_ConfirmPwd.Location = new Point(35, 80);
            lbl_ConfirmPwd.Size = new Size(100, 24);
            lbl_ConfirmPwd.TabIndex = 2;
            lbl_ConfirmPwd.Text = "确认密码：";
            // 
            // txt_ConfirmPwd
            // 
            txt_ConfirmPwd.Location = new Point(145, 77);
            txt_ConfirmPwd.PasswordChar = '*';
            txt_ConfirmPwd.Size = new Size(310, 30);
            txt_ConfirmPwd.TabIndex = 3;
            // 
            // btn_ResetPwd
            // 
            btn_ResetPwd.BackColor = SystemColors.Highlight;
            btn_ResetPwd.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btn_ResetPwd.ForeColor = Color.White;
            btn_ResetPwd.Location = new Point(180, 130);
            btn_ResetPwd.Size = new Size(130, 42);
            btn_ResetPwd.TabIndex = 4;
            btn_ResetPwd.Text = "重置密码";
            btn_ResetPwd.UseVisualStyleBackColor = false;
            btn_ResetPwd.Click += btn_ResetPwd_Click;
            // 
            // lbl_Tip
            // 
            lbl_Tip.AutoSize = true;
            lbl_Tip.ForeColor = Color.Red;
            lbl_Tip.Location = new Point(85, 350);
            lbl_Tip.Size = new Size(0, 24);
            lbl_Tip.TabIndex = 5;
            // 
            // FrmForgotPassword
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(644, 421);
            Controls.Add(lbl_Tip);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lbl_StepIndicator);
            Controls.Add(lbl_Title);
            DoubleBuffered = true;
            Name = "FrmForgotPassword";
            Text = "找回密码";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lbl_Title;
        private Label lbl_StepIndicator;
        private Panel panel1;
        private Label lbl_Email;
        private TextBox txt_Email;
        private Button btn_SendCode;
        private Panel panel2;
        private Label lbl_CodeTitle;
        private TextBox txt_Code;
        private Button btn_Verify;
        private Panel panel3;
        private Label lbl_NewPwd;
        private TextBox txt_NewPwd;
        private Label lbl_ConfirmPwd;
        private TextBox txt_ConfirmPwd;
        private Button btn_ResetPwd;
        private Label lbl_Tip;
    }
}
