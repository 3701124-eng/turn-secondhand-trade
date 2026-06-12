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
            btn_Logout = new Button();
            btn_MyOrder = new Button();
            btn_Publish = new Button();
            btn_GoodsList = new Button();
            lbl_Welcome = new Label();
            pnl_Content = new Panel();
            pnl_Menu.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_Menu
            // 
            pnl_Menu.Controls.Add(btn_Logout);
            pnl_Menu.Controls.Add(btn_MyOrder);
            pnl_Menu.Controls.Add(btn_Publish);
            pnl_Menu.Controls.Add(btn_GoodsList);
            pnl_Menu.Controls.Add(lbl_Welcome);
            pnl_Menu.Dock = DockStyle.Left;
            pnl_Menu.Location = new Point(0, 0);
            pnl_Menu.Name = "pnl_Menu";
            pnl_Menu.Size = new Size(150, 450);
            pnl_Menu.TabIndex = 0;
            // 
            // btn_Logout
            // 
            btn_Logout.Dock = DockStyle.Bottom;
            btn_Logout.Location = new Point(0, 420);
            btn_Logout.Name = "btn_Logout";
            btn_Logout.Size = new Size(150, 30);
            btn_Logout.TabIndex = 4;
            btn_Logout.Text = "退出登录";
            btn_Logout.UseVisualStyleBackColor = true;
            btn_Logout.Click += BtnLogoutClick;
            // 
            // btn_MyOrder
            // 
            btn_MyOrder.Dock = DockStyle.Top;
            btn_MyOrder.Location = new Point(0, 100);
            btn_MyOrder.Name = "btn_MyOrder";
            btn_MyOrder.Size = new Size(150, 30);
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
            btn_Publish.Size = new Size(150, 30);
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
            btn_GoodsList.Size = new Size(150, 30);
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
            lbl_Welcome.Size = new Size(150, 40);
            lbl_Welcome.TabIndex = 0;
            lbl_Welcome.Text = "欢迎使用";
            lbl_Welcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnl_Content
            // 
            pnl_Content.Dock = DockStyle.Fill;
            pnl_Content.Location = new Point(150, 0);
            pnl_Content.Name = "pnl_Content";
            pnl_Content.Size = new Size(650, 450);
            pnl_Content.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnl_Content);
            Controls.Add(pnl_Menu);
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
    }
}
