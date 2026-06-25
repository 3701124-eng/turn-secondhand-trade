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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            pnl_Menu = new Panel();
            btn_Logout = new Button();
            btn_MyOrder = new Button();
            btn_Publish = new Button();
            btn_GoodsList = new Button();
            lbl_Welcome = new Label();
            pnl_Content = new Panel();
            btn_admin = new Button();
            pnl_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Menu
            // 
            pnl_Menu.BackgroundImage = (Image)resources.GetObject("pnl_Menu.BackgroundImage");
            pnl_Menu.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_Menu.Controls.Add(btn_admin);
            pnl_Menu.Controls.Add(btn_Logout);
            pnl_Menu.Controls.Add(btn_MyOrder);
            pnl_Menu.Controls.Add(btn_Publish);
            pnl_Menu.Controls.Add(btn_GoodsList);
            pnl_Menu.Controls.Add(lbl_Welcome);
            pnl_Menu.Dock = DockStyle.Left;
            pnl_Menu.Location = new Point(0, 0);
            pnl_Menu.Margin = new Padding(5, 4, 5, 4);
            pnl_Menu.Name = "pnl_Menu";
            pnl_Menu.Size = new Size(335, 736);
            pnl_Menu.TabIndex = 0;
            // 
            // btn_Logout
            // 
            btn_Logout.BackColor = Color.FromArgb(255, 128, 128);
            btn_Logout.Dock = DockStyle.Bottom;
            btn_Logout.Location = new Point(0, 694);
            btn_Logout.Margin = new Padding(5, 4, 5, 4);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(335, 42);
            btn_Logout.TabIndex = 4;
            btn_Logout.Text = "退出登录";
            btn_Logout.UseVisualStyleBackColor = false;
            btn_Logout.Click += BtnLogoutClick;
            // 
            // btn_MyOrder
            // 
            btn_MyOrder.Dock = DockStyle.Top;
            btn_MyOrder.Location = new Point(0, 140);
            btn_MyOrder.Margin = new Padding(5, 4, 5, 4);
            btn_MyOrder.Name = "btn_MyOrder";
            btn_MyOrder.Size = new Size(335, 42);
            btn_MyOrder.TabIndex = 3;
            btn_MyOrder.Text = "我的订单";
            btn_MyOrder.UseVisualStyleBackColor = true;
            btn_MyOrder.Click += BtnMyOrderClick;
            // 
            // btn_Publish
            // 
            btn_Publish.Dock = DockStyle.Top;
            btn_Publish.Location = new Point(0, 98);
            btn_Publish.Margin = new Padding(5, 4, 5, 4);
            btn_Publish.Name = "btn_Publish";
            btn_Publish.Size = new Size(335, 42);
            btn_Publish.TabIndex = 2;
            btn_Publish.Text = "发布商品";
            btn_Publish.UseVisualStyleBackColor = true;
            btn_Publish.Click += BtnPublishClick;
            // 
            // btn_GoodsList
            // 
            btn_GoodsList.Dock = DockStyle.Top;
            btn_GoodsList.Location = new Point(0, 56);
            btn_GoodsList.Margin = new Padding(5, 4, 5, 4);
            btn_GoodsList.Name = "btn_GoodsList";
            btn_GoodsList.Size = new Size(335, 42);
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
            lbl_Welcome.Margin = new Padding(5, 0, 5, 0);
            lbl_Welcome.Name = "lbl_Welcome";
            lbl_Welcome.Size = new Size(335, 56);
            lbl_Welcome.TabIndex = 0;
            lbl_Welcome.Text = "欢迎使用";
            lbl_Welcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl_Content
            // 
            pnl_Content.BackgroundImage = Properties.Resources.ChatGPT_Image_2026年6月12日_12_24_25;
            pnl_Content.BackgroundImageLayout = ImageLayout.Stretch;
            pnl_Content.Dock = DockStyle.Fill;
            pnl_Content.Location = new Point(335, 0);
            pnl_Content.Margin = new Padding(5, 4, 5, 4);
            pnl_Content.Name = "pnl_Content";
            pnl_Content.Size = new Size(949, 736);
            pnl_Content.TabIndex = 1;
            pnl_Content.Paint += pnl_Content_Paint;
            // 
            // btn_admin
            // 
            btn_admin.Dock = DockStyle.Top;
            btn_admin.Location = new Point(0, 182);
            btn_admin.Margin = new Padding(5, 4, 5, 4);
            btn_admin.Name = "btn_admin";
            btn_admin.Size = new Size(335, 42);
            btn_admin.TabIndex = 5;
            btn_admin.Text = "管理员面板";
            btn_admin.UseVisualStyleBackColor = true;
            btn_admin.Click += btn_admin_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1284, 736);
            Controls.Add(pnl_Content);
            Controls.Add(pnl_Menu);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmMain";
            Text = "二手交易系统";
            Load += FrmMainLoad;
            pnl_Menu.ResumeLayout(false);
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
    }
}
