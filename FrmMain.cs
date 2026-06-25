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
            {
                pnl_Content.Controls.Remove(currentForm);
                currentForm.Dispose();
            }

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_Content.Controls.Add(childForm);
            childForm.Show();
        }

        private void BtnGoodsListClick(object sender, EventArgs e)
        {
            OpenChildForm(new FrmGoodslist());
        }

        private void BtnPublishClick(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPublishGoods());
        }

        private void BtnMyOrderClick(object sender, EventArgs e)
        {
            OpenChildForm(new FrmMyOrder());
        }

        private void BtnLogoutClick(object sender, EventArgs e)
        {
            Program.CurrentUserId = 0;
            Program.CurrentUserName = "";
            this.Close();
        }

        private void pnl_Content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Frmadmin());
        }
    }
}
