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
            lbl_Title.Location = new Point(30, 20);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(100, 25);
            lbl_Title.TabIndex = 0;
            lbl_Title.Text = "发布商品";
            // 
            // lbl_GoodsTitle
            // 
            lbl_GoodsTitle.Location = new Point(30, 60);
            lbl_GoodsTitle.Name = "lbl_GoodsTitle";
            lbl_GoodsTitle.Size = new Size(80, 25);
            lbl_GoodsTitle.TabIndex = 1;
            lbl_GoodsTitle.Text = "商品名称：";
            // 
            // txt_GoodsTitle
            // 
            txt_GoodsTitle.Location = new Point(120, 58);
            txt_GoodsTitle.MaxLength = 100;
            txt_GoodsTitle.Name = "txt_GoodsTitle";
            txt_GoodsTitle.Size = new Size(200, 23);
            txt_GoodsTitle.TabIndex = 2;
            // 
            // lbl_Price
            // 
            lbl_Price.Location = new Point(30, 100);
            lbl_Price.Name = "lbl_Price";
            lbl_Price.Size = new Size(80, 25);
            lbl_Price.TabIndex = 3;
            lbl_Price.Text = "价格（元）：";
            // 
            // nud_Price
            // 
            nud_Price.DecimalPlaces = 2;
            nud_Price.Location = new Point(120, 98);
            nud_Price.Maximum = new decimal(new int[] { 99999, 0, 0, 0 });
            nud_Price.Name = "nud_Price";
            nud_Price.Size = new Size(120, 23);
            nud_Price.TabIndex = 4;
            // 
            // lbl_Category
            // 
            lbl_Category.Location = new Point(30, 140);
            lbl_Category.Name = "lbl_Category";
            lbl_Category.Size = new Size(80, 25);
            lbl_Category.TabIndex = 5;
            lbl_Category.Text = "分类：";
            // 
            // cbo_Category
            // 
            cbo_Category.DropDownStyle = ComboBoxStyle.DropDownList;
            cbo_Category.Location = new Point(120, 138);
            cbo_Category.Name = "cbo_Category";
            cbo_Category.Size = new Size(150, 25);
            cbo_Category.TabIndex = 6;
            // 
            // lbl_Desc
            // 
            lbl_Desc.Location = new Point(30, 180);
            lbl_Desc.Name = "lbl_Desc";
            lbl_Desc.Size = new Size(80, 25);
            lbl_Desc.TabIndex = 7;
            lbl_Desc.Text = "描述：";
            // 
            // rtb_Desc
            // 
            rtb_Desc.Location = new Point(30, 210);
            rtb_Desc.Name = "rtb_Desc";
            rtb_Desc.Size = new Size(300, 80);
            rtb_Desc.TabIndex = 8;
            rtb_Desc.Text = "";
            // 
            // pic_Goods
            // 
            pic_Goods.BorderStyle = BorderStyle.FixedSingle;
            pic_Goods.Location = new Point(360, 58);
            pic_Goods.Name = "pic_Goods";
            pic_Goods.Size = new Size(179, 202);
            pic_Goods.SizeMode = PictureBoxSizeMode.Zoom;
            pic_Goods.TabIndex = 9;
            pic_Goods.TabStop = false;
            // 
            // btn_SelectImage
            // 
            btn_SelectImage.BackColor = SystemColors.ActiveCaption;
            btn_SelectImage.Location = new Point(409, 266);
            btn_SelectImage.Name = "btn_SelectImage";
            btn_SelectImage.Size = new Size(90, 30);
            btn_SelectImage.TabIndex = 10;
            btn_SelectImage.Text = "选择图片";
            btn_SelectImage.UseVisualStyleBackColor = false;
            btn_SelectImage.Click += btn_SelectImage_Click;
            // 
            // btn_Publish
            // 
            btn_Publish.BackColor = SystemColors.ActiveCaption;
            btn_Publish.Location = new Point(235, 349);
            btn_Publish.Name = "btn_Publish";
            btn_Publish.Size = new Size(120, 35);
            btn_Publish.TabIndex = 11;
            btn_Publish.Text = "发布商品";
            btn_Publish.UseVisualStyleBackColor = false;
            btn_Publish.Click += btn_Publish_Click;
            // 
            // FrmPublishGoods
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath, "Sys_images", "Backgrounds", "background_form.png"));
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(591, 481);
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
