namespace 转一转校园二手物品交易系统
{
    partial class FrmMyOrder
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
            dgv_Order = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColGoods = new DataGridViewTextBoxColumn();
            ColPrice = new DataGridViewTextBoxColumn();
            ColDealPrice = new DataGridViewTextBoxColumn();
            ColTime = new DataGridViewTextBoxColumn();
            ColStatus = new DataGridViewTextBoxColumn();
            ColBuyer = new DataGridViewTextBoxColumn();
            btn_Confirm = new Button();
            btn_ModifyPrice = new Button();
            btn_ModifyAddress = new Button();
            rdo_Seller = new RadioButton();
            rdo_Buyer = new RadioButton();
            lbl_Tip = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_Order).BeginInit();
            SuspendLayout();
            // 
            // dgv_Order
            // 
            dgv_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Order.BackgroundColor = SystemColors.Info;
            dgv_Order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Order.Columns.AddRange(new DataGridViewColumn[] { ColId, ColGoods, ColPrice, ColDealPrice, ColTime, ColStatus, ColBuyer });
            dgv_Order.GridColor = SystemColors.Highlight;
            dgv_Order.Location = new Point(29, 121);
            dgv_Order.Margin = new Padding(5, 4, 5, 4);
            dgv_Order.Name = "dgv_Order";
            dgv_Order.ReadOnly = true;
            dgv_Order.RowHeadersWidth = 62;
            dgv_Order.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Order.Size = new Size(893, 420);
            dgv_Order.TabIndex = 7;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "order_id";
            ColId.HeaderText = "订单号";
            ColId.MinimumWidth = 8;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            // 
            // ColGoods
            // 
            ColGoods.DataPropertyName = "goods_title";
            ColGoods.HeaderText = "商品";
            ColGoods.MinimumWidth = 8;
            ColGoods.Name = "ColGoods";
            ColGoods.ReadOnly = true;
            // 
            // ColPrice
            // 
            ColPrice.DataPropertyName = "goods_price";
            ColPrice.HeaderText = "标价";
            ColPrice.MinimumWidth = 8;
            ColPrice.Name = "ColPrice";
            ColPrice.ReadOnly = true;
            // 
            // ColDealPrice
            // 
            ColDealPrice.DataPropertyName = "deal_price";
            ColDealPrice.HeaderText = "成交价";
            ColDealPrice.MinimumWidth = 8;
            ColDealPrice.Name = "ColDealPrice";
            ColDealPrice.ReadOnly = true;
            // 
            // ColTime
            // 
            ColTime.DataPropertyName = "order_time";
            ColTime.HeaderText = "时间";
            ColTime.MinimumWidth = 8;
            ColTime.Name = "ColTime";
            ColTime.ReadOnly = true;
            // 
            // ColStatus
            // 
            ColStatus.DataPropertyName = "order_status";
            ColStatus.HeaderText = "状态";
            ColStatus.MinimumWidth = 8;
            ColStatus.Name = "ColStatus";
            ColStatus.ReadOnly = true;
            // 
            // ColBuyer
            // 
            ColBuyer.DataPropertyName = "buyer_name";
            ColBuyer.HeaderText = "买家";
            ColBuyer.MinimumWidth = 8;
            ColBuyer.Name = "ColBuyer";
            ColBuyer.ReadOnly = true;
            // 
            // btn_Confirm
            // 
            btn_Confirm.BackColor = SystemColors.ActiveCaption;
            btn_Confirm.Location = new Point(352, 560);
            btn_Confirm.Margin = new Padding(5, 4, 5, 4);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(118, 32);
            btn_Confirm.TabIndex = 6;
            btn_Confirm.Text = "确认收货";
            btn_Confirm.UseVisualStyleBackColor = false;
            btn_Confirm.Click += btn_Confirm_Click;
            // 
            // btn_ModifyPrice
            // 
            btn_ModifyPrice.BackColor = SystemColors.ActiveCaption;
            btn_ModifyPrice.Location = new Point(490, 560);
            btn_ModifyPrice.Margin = new Padding(5, 4, 5, 4);
            btn_ModifyPrice.Name = "btn_ModifyPrice";
            btn_ModifyPrice.Size = new Size(118, 32);
            btn_ModifyPrice.TabIndex = 9;
            btn_ModifyPrice.Text = "修改价格";
            btn_ModifyPrice.UseVisualStyleBackColor = false;
            btn_ModifyPrice.Click += btn_ModifyPrice_Click;
            // 
            // btn_ModifyAddress
            // 
            btn_ModifyAddress.BackColor = SystemColors.ActiveCaption;
            btn_ModifyAddress.Location = new Point(490, 560);
            btn_ModifyAddress.Margin = new Padding(5, 4, 5, 4);
            btn_ModifyAddress.Name = "btn_ModifyAddress";
            btn_ModifyAddress.Size = new Size(118, 32);
            btn_ModifyAddress.TabIndex = 10;
            btn_ModifyAddress.Text = "修改地址";
            btn_ModifyAddress.UseVisualStyleBackColor = false;
            btn_ModifyAddress.Click += btn_ModifyAddress_Click;
            // 
            // rdo_Seller
            // 
            rdo_Seller.AutoSize = true;
            rdo_Seller.Location = new Point(583, 83);
            rdo_Seller.Margin = new Padding(5, 4, 5, 4);
            rdo_Seller.Name = "rdo_Seller";
            rdo_Seller.Size = new Size(89, 28);
            rdo_Seller.TabIndex = 5;
            rdo_Seller.Text = "我卖的";
            rdo_Seller.UseVisualStyleBackColor = true;
            rdo_Seller.CheckedChanged += rdo_Seller_CheckedChanged;
            // 
            // rdo_Buyer
            // 
            rdo_Buyer.AutoSize = true;
            rdo_Buyer.Checked = true;
            rdo_Buyer.Location = new Point(255, 83);
            rdo_Buyer.Margin = new Padding(5, 4, 5, 4);
            rdo_Buyer.Name = "rdo_Buyer";
            rdo_Buyer.Size = new Size(89, 28);
            rdo_Buyer.TabIndex = 4;
            rdo_Buyer.TabStop = true;
            rdo_Buyer.Text = "我买的";
            rdo_Buyer.UseVisualStyleBackColor = true;
            rdo_Buyer.CheckedChanged += rdo_Buyer_CheckedChanged;
            // 
            // lbl_Tip
            // 
            lbl_Tip.AutoSize = true;
            lbl_Tip.ForeColor = SystemColors.GrayText;
            lbl_Tip.Location = new Point(418, 598);
            lbl_Tip.Margin = new Padding(5, 0, 5, 0);
            lbl_Tip.Name = "lbl_Tip";
            lbl_Tip.Size = new Size(63, 24);
            lbl_Tip.TabIndex = 8;
            lbl_Tip.Text = "label1";
            // 
            // FrmMyOrder
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = DesignTimeSafe.LoadImage("Sys_images", "Backgrounds", "background_form.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(960, 720);
            Controls.Add(lbl_Tip);
            Controls.Add(dgv_Order);
            Controls.Add(btn_Confirm);
            Controls.Add(btn_ModifyPrice);
            Controls.Add(btn_ModifyAddress);
            Controls.Add(rdo_Seller);
            Controls.Add(rdo_Buyer);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmMyOrder";
            Text = "FrmMyOrder";
            Load += FrmMyOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Order).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_Order;
        private Button btn_Confirm;
        private Button btn_ModifyPrice;
        private Button btn_ModifyAddress;
        private RadioButton rdo_Seller;
        private RadioButton rdo_Buyer;
        private Label lbl_Tip;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColGoods;
        private DataGridViewTextBoxColumn ColPrice;
        private DataGridViewTextBoxColumn ColDealPrice;
        private DataGridViewTextBoxColumn ColTime;
        private DataGridViewTextBoxColumn ColStatus;
        private DataGridViewTextBoxColumn ColBuyer;
        private DataGridViewTextBoxColumn ColSeller;
    }
}
