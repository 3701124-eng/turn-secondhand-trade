namespace 转一转校园二手物品交易系统
{
    partial class FrmGoodslist
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lbl_Search = new Label();
            txt_Search = new TextBox();
            btn_Search = new Button();
            btn_Refresh = new Button();
            dgv_Goods = new DataGridView();
            btn_Prev = new Button();
            lbl_PageInfo = new Label();
            btn_Next = new Button();
            btn_ViewDetail = new Button();
            image_url = new DataGridViewImageColumn();
            goods_id = new DataGridViewTextBoxColumn();
            商品名 = new DataGridViewTextBoxColumn();
            价格 = new DataGridViewTextBoxColumn();
            分类 = new DataGridViewTextBoxColumn();
            卖家 = new DataGridViewTextBoxColumn();
            状态 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv_Goods).BeginInit();
            SuspendLayout();
            // 
            // lbl_Search
            // 
            lbl_Search.AutoSize = true;
            lbl_Search.Location = new Point(47, 28);
            lbl_Search.Margin = new Padding(5, 0, 5, 0);
            lbl_Search.Name = "lbl_Search";
            lbl_Search.Size = new Size(64, 24);
            lbl_Search.TabIndex = 0;
            lbl_Search.Text = "搜索：";
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(126, 24);
            txt_Search.Margin = new Padding(5, 4, 5, 4);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(312, 30);
            txt_Search.TabIndex = 1;
            // 
            // btn_Search
            // 
            btn_Search.Location = new Point(471, 24);
            btn_Search.Margin = new Padding(5, 4, 5, 4);
            btn_Search.Name = "btn_Search";
            btn_Search.Size = new Size(118, 32);
            btn_Search.TabIndex = 2;
            btn_Search.Text = "搜索";
            btn_Search.UseVisualStyleBackColor = true;
            btn_Search.Click += btn_Search_Click;
            // 
            // btn_Refresh
            // 
            btn_Refresh.Location = new Point(613, 24);
            btn_Refresh.Margin = new Padding(5, 4, 5, 4);
            btn_Refresh.Name = "btn_Refresh";
            btn_Refresh.Size = new Size(118, 32);
            btn_Refresh.TabIndex = 3;
            btn_Refresh.Text = "全部";
            btn_Refresh.UseVisualStyleBackColor = true;
            btn_Refresh.Click += btn_Refresh_Click;
            // 
            // dgv_Goods
            // 
            dgv_Goods.AllowUserToAddRows = false;
            dgv_Goods.AutoGenerateColumns = false;
            dgv_Goods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Goods.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_Goods.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Goods.ColumnHeadersHeight = 30;
            dgv_Goods.Columns.AddRange(new DataGridViewColumn[] { image_url, goods_id, 商品名, 价格, 分类, 卖家, 状态 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv_Goods.DefaultCellStyle = dataGridViewCellStyle2;
            dgv_Goods.Dock = DockStyle.Fill;
            dgv_Goods.Location = new Point(0, 0);
            dgv_Goods.Margin = new Padding(5, 4, 5, 4);
            dgv_Goods.Name = "dgv_Goods";
            dgv_Goods.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft YaHei UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgv_Goods.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgv_Goods.RowHeadersVisible = false;
            dgv_Goods.RowHeadersWidth = 62;
            dgv_Goods.RowTemplate.Height = 60;
            dgv_Goods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Goods.Size = new Size(929, 679);
            dgv_Goods.TabIndex = 4;
            dgv_Goods.CellDoubleClick += dgv_Goods_CellDoubleClick;
            // 
            // btn_Prev
            // 
            btn_Prev.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Prev.Location = new Point(613, 621);
            btn_Prev.Margin = new Padding(5, 4, 5, 4);
            btn_Prev.Name = "btn_Prev";
            btn_Prev.Size = new Size(102, 35);
            btn_Prev.TabIndex = 5;
            btn_Prev.Text = "上一页";
            btn_Prev.UseVisualStyleBackColor = true;
            btn_Prev.Click += btn_Prev_Click;
            // 
            // lbl_PageInfo
            // 
            lbl_PageInfo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_PageInfo.AutoSize = true;
            lbl_PageInfo.Location = new Point(724, 628);
            lbl_PageInfo.Margin = new Padding(5, 0, 5, 0);
            lbl_PageInfo.Name = "lbl_PageInfo";
            lbl_PageInfo.Size = new Size(86, 24);
            lbl_PageInfo.TabIndex = 6;
            lbl_PageInfo.Text = "第 1/1 页";
            // 
            // btn_Next
            // 
            btn_Next.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_Next.Location = new Point(822, 621);
            btn_Next.Margin = new Padding(5, 4, 5, 4);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(102, 35);
            btn_Next.TabIndex = 7;
            btn_Next.Text = "下一页";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // btn_ViewDetail
            // 
            btn_ViewDetail.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_ViewDetail.BackColor = SystemColors.ActiveCaption;
            btn_ViewDetail.Location = new Point(412, 620);
            btn_ViewDetail.Margin = new Padding(5, 4, 5, 4);
            btn_ViewDetail.Name = "btn_ViewDetail";
            btn_ViewDetail.Size = new Size(157, 42);
            btn_ViewDetail.TabIndex = 8;
            btn_ViewDetail.Text = "查看详情";
            btn_ViewDetail.UseVisualStyleBackColor = false;
            btn_ViewDetail.Click += btn_ViewDetail_Click;
            // 
            // image_url
            // 
            image_url.DataPropertyName = "image_url";
            image_url.FillWeight = 200F;
            image_url.HeaderText = "图片";
            image_url.ImageLayout = DataGridViewImageCellLayout.Zoom;
            image_url.MinimumWidth = 8;
            image_url.Name = "image_url";
            image_url.ReadOnly = true;
            // 
            // goods_id
            // 
            goods_id.DataPropertyName = "goods_id";
            goods_id.FillWeight = 80F;
            goods_id.HeaderText = "商品 ID";
            goods_id.MinimumWidth = 8;
            goods_id.Name = "goods_id";
            goods_id.ReadOnly = true;
            // 
            // 商品名
            // 
            商品名.DataPropertyName = "商品名";
            商品名.FillWeight = 250F;
            商品名.HeaderText = "商品名";
            商品名.MinimumWidth = 8;
            商品名.Name = "商品名";
            商品名.ReadOnly = true;
            // 
            // 价格
            // 
            价格.DataPropertyName = "价格";
            价格.FillWeight = 80F;
            价格.HeaderText = "价格";
            价格.MinimumWidth = 8;
            价格.Name = "价格";
            价格.ReadOnly = true;
            // 
            // 分类
            // 
            分类.DataPropertyName = "分类";
            分类.FillWeight = 100F;
            分类.HeaderText = "分类";
            分类.MinimumWidth = 8;
            分类.Name = "分类";
            分类.ReadOnly = true;
            // 
            // 卖家
            // 
            卖家.DataPropertyName = "卖家";
            卖家.FillWeight = 100F;
            卖家.HeaderText = "卖家";
            卖家.MinimumWidth = 8;
            卖家.Name = "卖家";
            卖家.ReadOnly = true;
            // 
            // 状态
            // 
            状态.DataPropertyName = "状态";
            状态.FillWeight = 80F;
            状态.HeaderText = "状态";
            状态.MinimumWidth = 8;
            状态.Name = "状态";
            状态.ReadOnly = true;
            // 
            // FrmGoodslist
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 679);
            Controls.Add(btn_ViewDetail);
            Controls.Add(btn_Next);
            Controls.Add(lbl_PageInfo);
            Controls.Add(btn_Prev);
            Controls.Add(dgv_Goods);
            Controls.Add(btn_Refresh);
            Controls.Add(btn_Search);
            Controls.Add(txt_Search);
            Controls.Add(lbl_Search);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FrmGoodslist";
            Text = "Form1";
            Load += FrmGoodslist_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_Goods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_Search;
        private TextBox txt_Search;
        private Button btn_Search;
        private Button btn_Refresh;
        private DataGridView dgv_Goods;
        private Button btn_ViewDetail;
        private Button btn_Prev;
        private Label lbl_PageInfo;
        private Button btn_Next;
        private DataGridViewImageColumn image_url;
        private DataGridViewTextBoxColumn goods_id;
        private DataGridViewTextBoxColumn 商品名;
        private DataGridViewTextBoxColumn 价格;
        private DataGridViewTextBoxColumn 分类;
        private DataGridViewTextBoxColumn 卖家;
        private DataGridViewTextBoxColumn 状态;
    }
}
