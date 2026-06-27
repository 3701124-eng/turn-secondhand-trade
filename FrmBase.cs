using System.Data;
using System.Windows.Forms;

namespace 转一转校园二手物品交易系统
{
    public class FrmBase : Form
    {
        public FrmBase()
        {
            Font = new Font("Microsoft YaHei UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
        }

        protected void ShowTip(string msg)
        {
            MessageBox.Show(msg, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        protected void ShowError(string msg)
        {
            MessageBox.Show(msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        protected bool ShowConfirm(string msg)
        {
            return MessageBox.Show(msg, "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // FrmBase
            // 
            ClientSize = new Size(929, 679);
            Name = "FrmBase";
            Load += FrmBase_Load;
            ResumeLayout(false);

        }

        protected void LoadComboBox(ComboBox cbo, DataTable dt, string displayMember, string valueMember)
        {
            cbo.DisplayMember = displayMember;
            cbo.ValueMember = valueMember;
            cbo.DataSource = dt;
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {

        }
    }
}
