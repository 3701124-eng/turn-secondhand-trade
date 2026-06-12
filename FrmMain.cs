namespace 转一转校园二手物品交易系统
{
    public partial class FrmMain : FrmBase
    {
        private Form? currentForm = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMainLoad(object sender, EventArgs e)
        {
            Text = "二手交易系统 - " + Program.CurrentUserName;
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentForm != null)
                currentForm.Close();

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Content.Controls.Add(childForm);
            childForm.Show();
        }

        private void BtnGoodsListClick(object sender, EventArgs e)
        {
            ShowTip("功能开发中");
        }

        private void BtnPublishClick(object sender, EventArgs e)
        {
            ShowTip("功能开发中");
        }

        private void BtnMyOrderClick(object sender, EventArgs e)
        {
            ShowTip("功能开发中");
        }

        private void BtnLogoutClick(object sender, EventArgs e)
        {
            Program.CurrentUserId = 0;
            Program.CurrentUserName = "";
            this.Close();
        }
    }
}
