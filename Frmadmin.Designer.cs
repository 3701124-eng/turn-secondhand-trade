namespace 转一转校园二手物品交易系统
{
    partial class Frmadmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tpUserManage = new TabPage();
            tpGoodsAudit = new TabPage();
            tpOrderDispute = new TabPage();
            tpAnnounceStat = new TabPage();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpUserManage);
            tabControl1.Controls.Add(tpGoodsAudit);
            tabControl1.Controls.Add(tpOrderDispute);
            tabControl1.Controls.Add(tpAnnounceStat);
            tabControl1.ItemSize = new Size(95, 50);
            tabControl1.Location = new Point(2, -3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(926, 615);
            tabControl1.TabIndex = 0;
            // 
            // tpUserManage
            // 
            tpUserManage.Location = new Point(4, 54);
            tpUserManage.Name = "tpUserManage";
            tpUserManage.Padding = new Padding(3);
            tpUserManage.Size = new Size(918, 557);
            tpUserManage.TabIndex = 0;
            tpUserManage.Text = "用户管理";
            tpUserManage.UseVisualStyleBackColor = true;
            // 
            // tpGoodsAudit
            // 
            tpGoodsAudit.Location = new Point(4, 54);
            tpGoodsAudit.Name = "tpGoodsAudit";
            tpGoodsAudit.Padding = new Padding(3);
            tpGoodsAudit.Size = new Size(918, 557);
            tpGoodsAudit.TabIndex = 1;
            tpGoodsAudit.Text = "商品审核";
            tpGoodsAudit.UseVisualStyleBackColor = true;
            tpGoodsAudit.Click += tabPage2_Click;
            // 
            // tpOrderDispute
            // 
            tpOrderDispute.Location = new Point(4, 54);
            tpOrderDispute.Name = "tpOrderDispute";
            tpOrderDispute.Padding = new Padding(3);
            tpOrderDispute.Size = new Size(918, 557);
            tpOrderDispute.TabIndex = 2;
            tpOrderDispute.Text = "订单纠纷处理";
            tpOrderDispute.UseVisualStyleBackColor = true;
            // 
            // tpAnnounceStat
            // 
            tpAnnounceStat.Location = new Point(4, 54);
            tpAnnounceStat.Name = "tpAnnounceStat";
            tpAnnounceStat.Padding = new Padding(3);
            tpAnnounceStat.Size = new Size(918, 557);
            tpAnnounceStat.TabIndex = 3;
            tpAnnounceStat.Text = "公告与数据统计";
            tpAnnounceStat.UseVisualStyleBackColor = true;
            // 
            // Frmadmin
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 679);
            Controls.Add(tabControl1);
            Name = "Frmadmin";
            Text = "管理员面板";
            Load += Frmadmin_Load;
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tpUserManage;
        private TabPage tpGoodsAudit;
        private TabPage tpOrderDispute;
        private TabPage tpAnnounceStat;
    }
}