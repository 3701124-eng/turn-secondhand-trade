namespace 转一转校园二手物品交易系统
{
    partial class FrmPublishGoods
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
            lbl_GoodsTitle = new Label();
            txt_GoodsTitle = new TextBox();
            lbl_Price = new Label();
            nud_Price = new NumericUpDown();
            lbl_Category = new Label();
            cbo_Category = new ComboBox();
            lbl_Desc = new Label();
            rtb_Desc = new RichTextBox();
            pic_Goods = new PictureBox();
            btn_SelectImage = new Button();
            btn_Publish = new Button();
            ((System.ComponentModel.ISupportInitialize)nud_Price).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Goods).BeginInit();
            SuspendLayout();
            // 
            // lbl_Title
            // 
            lbl_Title.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold);
            lbl_Title.Location = new Point(47, 28);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(157, 35);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "发布商品";
            // 
            // lbl_GoodsTitle
            // 
            lbl_GoodsTitle.Location = new Point(47, 85);
            lbl_GoodsTitle.Name = "lbl_GoodsTitle";
            lbl_GoodsTitle.Size = new Size(126, 35);
            lbl_GoodsTitle.TabIndex = 1;
            lbl_GoodsTitle.Text = "商品名称：";
            // 
            // txt_GoodsTitle
            // 
            txt_GoodsTitle.Location = new Point(189, 82);
            txt_GoodsTitle.MaxLength = 100;
            txt_GoodsTitle.Name = "txt_GoodsTitle";
            txt_GoodsTitle.Size = new Size(314, 32);
            txt_GoodsTitle.TabIndex = 2;
            // 
            // lbl_Price
            // 
            lbl_Price.Location = new Point(47, 141);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(126, 35);
            lbl_Price.TabIndex = 3;
            lbl_Price.Text = "价格（元）：";
            // 
            // nud_Price
            // 
            nud_Price.DecimalPlaces = 2;
            nud_Price.Location = new Point(189, 138);
            nud_Price.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nud_Price.Name = "nud_Price";
            nud_Price.Size = new Size(189, 32);
            nud_Price.TabIndex = 4;
            // 
            // lbl_Category
            // 
            lbl_Category.Location = new Point(47, 198);
            lbl_Category.Name = "lbl_Category";
            lbl_Category.Size = new Size(126, 35);
            lbl_Category.TabIndex = 5;
            lbl_Category.Text = "分类：";
            // 
            // cbo_Category
            // 
            cbo_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Category.Location = new Point(189, 195);
            cbo_Category.Name = "cbo_Category";
            cbo_Category.Size = new Size(236, 35);
            cbo_Category.TabIndex = 6;
            // 
            // lbl_Desc
            // 
            lbl_Desc.Location = new Point(47, 254);
            lbl_Desc.Name = "lbl_Desc";
            lbl_Desc.Size = new Size(126, 35);
            lbl_Desc.TabIndex = 7;
            lbl_Desc.Text = "描述：";
            // 
            // rtb_Desc
            // 
            rtb_Desc.Location = new Point(47, 296);
            rtb_Desc.Name = "rtb_Desc";
            rtb_Desc.Size = new Size(471, 113);
            rtb_Desc.TabIndex = 8;
            rtb_Desc.Text = "";
            // 
            // pic_Goods
            // 
            pic_Goods.BorderStyle = BorderStyle.FixedSingle;
            pic_Goods.Location = new Point(566, 82);
            pic_Goods.Name = "pic_Goods";
            pic_Goods.Size = new Size(281, 285);
            pic_Goods.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Goods.TabIndex = 9;
            pic_Goods.TabStop = false;
            // 
            // btn_SelectImage
            // 
            btn_SelectImage.BackColor = SystemColors.ActiveCaption;
            btn_SelectImage.Location = new Point(643, 376);
            btn_SelectImage.Name = "btn_SelectImage";
            btn_SelectImage.Size = new Size(141, 42);
            btn_SelectImage.TabIndex = 10;
            btn_SelectImage.Text = "选择图片";
            btn_SelectImage.UseVisualStyleBackColor = false;
            btn_SelectImage.Click += btn_SelectImage_Click;
            // 
            // btn_Publish
            // 
            btn_Publish.BackColor = SystemColors.ActiveCaption;
            btn_Publish.Location = new Point(369, 493);
            btn_Publish.Name = "btn_Publish";
            btn_Publish.Size = new Size(189, 49);
            btn_Publish.TabIndex = 11;
            btn_Publish.Text = "发布商品";
            btn_Publish.UseVisualStyleBackColor = false;
            btn_Publish.Click += btn_Publish_Click;
            // 
            // FrmPublishGoods
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = DesignTimeSafe.LoadImage("Sys_images", "Backgrounds", "background_form.png");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(960, 720);
            Controls.Add(lbl_Title);
            Controls.Add(lbl_GoodsTitle);
            Controls.Add(txt_GoodsTitle);
            Controls.Add(lbl_Price);
            Controls.Add(nud_Price);
            Controls.Add(lbl_Category);
            Controls.Add(cbo_Category);
            Controls.Add(lbl_Desc);
            Controls.Add(rtb_Desc);
            Controls.Add(pic_Goods);
            Controls.Add(btn_SelectImage);
            Controls.Add(btn_Publish);
            Name = "FrmPublishGoods";
            Text = "发布商品";
            Load += FrmPublishGoods_Load;
            ((System.ComponentModel.ISupportInitialize)nud_Price).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Goods).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lbl_Title;
        private Label lbl_GoodsTitle;
        private TextBox txt_GoodsTitle;
        private Label lbl_Price;
        private NumericUpDown nud_Price;
        private Label lbl_Category;
        private ComboBox cbo_Category;
        private Label lbl_Desc;
        private RichTextBox rtb_Desc;
        private PictureBox pic_Goods;
        private Button btn_SelectImage;
        private Button btn_Publish;
    }
}
