using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 转一转校园二手物品交易系统
{
    public partial class FrmMyOrder : Form
    {
        public FrmMyOrder()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Sys_images", "Backgrounds", "background_form.png"));
            this.DoubleBuffered = true;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (dgv_Order.CurrentRow == null)
            {
                MessageBox.Show("请选中一个订单");
                return;
            }

            string status = dgv_Order.CurrentRow.Cells["ColStatus"].Value.ToString();
            int orderId = Convert.ToInt32(dgv_Order.CurrentRow.Cells["ColId"].Value);

            if (rdo_Seller.Checked)
            {
                if (status != "待付款")
                {
                    MessageBox.Show("只有「待付款」状态的订单才能确认收款");
                    return;
                }
                SQLHelper.Exec("UPDATE orders SET order_status='待收货' WHERE order_id=@id",
                    new[] { new SqlParameter("@id", orderId) });
                MessageBox.Show("已确认收款");
            }
            else
            {
                if (status != "待收货")
                {
                    MessageBox.Show("只有「待收货」状态的订单才能确认收货");
                    return;
                }
                SQLHelper.Exec("UPDATE orders SET order_status='已完成', complete_time=GETDATE() WHERE order_id=@id",
                    new[] { new SqlParameter("@id", orderId) });
                MessageBox.Show("确认收货成功！");
            }
            LoadOrders();
        }

        private void rdo_Buyer_CheckedChanged(object sender, EventArgs e)
        {
            btn_Confirm.Text = "确认收货";
            LoadOrders();
        }

        private void rdo_Seller_CheckedChanged(object sender, EventArgs e)
        {
            btn_Confirm.Text = "确认付款";
            LoadOrders();
        }

        private void FrmMyOrder_Load(object sender, EventArgs e)
        {
            btn_Confirm.Text = "确认收货";
            BeginInvoke(() => LoadOrders());
        }

        private void LoadOrders()
        {
            // 判断是"我买的"还是"我卖的"
            string field = rdo_Buyer.Checked ? "o.buyer_id" : "o.seller_id";
            lbl_Tip.Text = rdo_Buyer.Checked ? "当前显示：我买的订单" : "当前显示：我卖的订单";

            string sql = @"
    SELECT o.order_id, o.order_status, o.order_time,
           g.title AS goods_title, g.price AS goods_price,
           b.username AS buyer_name, s.username AS seller_name
    FROM orders o
    JOIN goods g ON o.goods_id = g.goods_id
    JOIN users b ON o.buyer_id = b.user_id
    JOIN users s ON o.seller_id = s.user_id
    WHERE " + field + @" = @uid
    ORDER BY o.order_time DESC";
            SqlParameter[] ps = { new SqlParameter("@uid", Program.CurrentUserId) };
            dgv_Order.DataSource = SQLHelper.Query(sql, ps);
        }
    }
}
