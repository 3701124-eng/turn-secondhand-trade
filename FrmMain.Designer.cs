namespace 转一转校园二手物品交易系统
{
    partial class FrmMain
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
            pnl_Menu = new Panel();
            btn_admin = new Button();
            btn_Logout = new Button();
            btn_MyOrder = new Button();
            btn_Publish = new Button();
            btn_GoodsList = new Button();
            lbl_Welcome = new Label();
            pnl_Content = new Panel();
            panel1 = new Panel();
            pnl_Menu.SuspendLayout();
            pnl_Content.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Menu
            // 
            pnl_Menu.AutoScroll = true;
            pnl_Menu.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Sys_images", "Backgrounds", "background_menu.png"));
            pnl_Menu.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_Menu.Controls.Add(btn_admin);
            pnl_Menu.Controls.Add(btn_Logout);
            pnl_Menu.Controls.Add(btn_MyOrder);
            pnl_Menu.Controls.Add(btn_Publish);
            pnl_Menu.Controls.Add(btn_GoodsList);
            pnl_Menu.Controls.Add(lbl_Welcome);
            pnl_Menu.Dock = DockStyle.Left;
            pnl_Menu.Location = new Point(0, 0);
            pnl_Menu.Name = "pnl_Menu";
            pnl_Menu.Size = new Size(213, 521);
            pnl_Menu.TabIndex = 0;
            // 
            // btn_admin
            // 
            btn_admin.Dock = DockStyle.Top;
            btn_admin.Location = new Point(0, 130);
            btn_admin.Name = "btn_admin";
            btn_admin.Size = new Size(213, 30);
            btn_admin.TabIndex = 5;
            btn_admin.Text = "管理员面板";
            btn_admin.UseVisualStyleBackColor = true;
            btn_admin.Click += btn_admin_Click;
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.FromArgb(255, 128, 128);
            btn_Logout.Dock = DockStyle.Bottom;
            btn_Logout.Location = new Point(0, 491);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(213, 30);
            btn_Logout.TabIndex = 4;
            btn_Logout.Text = "退出登录";
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += BtnLogoutClick;
            // 
            // btn_MyOrder
            // 
            btn_MyOrder.Dock = DockStyle.Top;
            btn_MyOrder.Location = new Point(0, 100);
            btn_MyOrder.Name = "btn_MyOrder";
            btn_MyOrder.Size = new Size(213, 30);
            btn_MyOrder.TabIndex = 3;
            btn_MyOrder.Text = "我的订单";
            btn_MyOrder.UseVisualStyleBackColor = true;
            btn_MyOrder.Click += BtnMyOrderClick;
            // 
            // btn_Publish
            // 
            btn_Publish.Dock = DockStyle.Top;
            btn_Publish.Location = new Point(0, 70);
            btn_Publish.Name = "btn_Publish";
            btn_Publish.Size = new Size(213, 30);
            btn_Publish.TabIndex = 2;
            btn_Publish.Text = "发布商品";
            btn_Publish.UseVisualStyleBackColor = true;
            btn_Publish.Click += BtnPublishClick;
            // 
            // btn_GoodsList
            // 
            btn_GoodsList.Dock = DockStyle.Top;
            btn_GoodsList.Location = new Point(0, 40);
            btn_GoodsList.Name = "btn_GoodsList";
            btn_GoodsList.Size = new Size(213, 30);
            btn_GoodsList.TabIndex = 1;
            btn_GoodsList.Text = "浏览商品";
            btn_GoodsList.UseVisualStyleBackColor = true;
            btn_GoodsList.Click += BtnGoodsListClick;
            // 
            // lbl_Welcome
            // 
            lbl_Welcome.Dock = DockStyle.Top;
            lbl_Welcome.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            lbl_Welcome.Location = new Point(0, 0);
            lbl_Welcome.Name = "lbl_Welcome";
            lbl_Welcome.Size = new Size(213, 40);
            lbl_Welcome.TabIndex = 0;
            lbl_Welcome.Text = "欢迎使用";
            lbl_Welcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl_Content
            // 
            pnl_Content.AutoScroll = true;
            pnl_Content.BackColor = Color.OldLace;
            pnl_Content.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Sys_images", "Backgrounds", "background_main.jpg"));
            pnl_Content.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_Content.Controls.Add(panel1);
            pnl_Content.Dock = DockStyle.Fill;
            pnl_Content.Location = new Point(213, 0);
            pnl_Content.Name = "pnl_Content";
            pnl_Content.Size = new Size(604, 521);
            pnl_Content.TabIndex = 1;
            pnl_Content.Paint += pnl_Content_Paint;
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(133, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 229);
            panel1.TabIndex = 0;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 521);
            Controls.Add(pnl_Content);
            Controls.Add(pnl_Menu);
            Name = "FrmMain";
            Text = "二手交易系统";
            Load += FrmMainLoad;
            pnl_Menu.ResumeLayout(false);
            pnl_Content.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_Menu;
        private Label lbl_Welcome;
        private Button btn_GoodsList;
        private Button btn_Publish;
        private Button btn_MyOrder;
        private Button btn_Logout;
        private Panel pnl_Content;
        private Button btn_admin;
        private Panel panel1;
    }
}
