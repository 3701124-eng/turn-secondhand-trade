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
    public partial class FrmGoodslist : FrmBase
    {
        private int _pageIndex = 1;
        private int _pageSize = 10;
        private int _totalCount = 0;
        private int _totalPages = 1;
        private string _keyword = "";
        private Dictionary<int, Image> _imageCache = new();

        public FrmGoodslist()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            dgv_Goods.CellFormatting += dgv_Goods_CellFormatting;
        }

        private void FrmGoodslist_Load(object sender, EventArgs e)
        {
            dgv_Goods.Columns["image_url"].DataPropertyName = null;
            BeginInvoke(() => LoadData());
        }

        private void LoadData()
        {
            string keyword = _keyword;

            string countSql = @"
    SELECT COUNT(*) FROM goods g
    JOIN categories c ON g.category_id = c.category_id
    JOIN users u ON g.seller_id = u.user_id
    WHERE g.status = '在售'
      AND (@k = '' OR g.title LIKE '%' + @k + '%')";

            _totalCount = (int)SQLHelper.Scalar(countSql, new[] { new SqlParameter("@k", keyword ?? "") });
            _totalPages = (int)Math.Ceiling((double)_totalCount / _pageSize);
            if (_totalPages == 0) _totalPages = 1;
            if (_pageIndex > _totalPages) _pageIndex = _totalPages;

            string sql = @"
    SELECT g.goods_id,
           (SELECT TOP 1 gi.image_url FROM goods_images gi WHERE gi.goods_id = g.goods_id ORDER BY gi.sort_order) AS image_url,
           g.title AS 商品名, g.price AS 价格,
           c.category_name AS 分类, u.username AS 卖家, g.status AS 状态
    FROM goods g
    JOIN categories c ON g.category_id = c.category_id
    JOIN users u ON g.seller_id = u.user_id
    WHERE g.status = '在售'
      AND (@k = '' OR g.title LIKE '%' + @k + '%')
    ORDER BY g.created_time DESC
    OFFSET @offset ROWS FETCH NEXT @pageSize ROWS ONLY";

            SqlParameter[] ps = {
                new SqlParameter("@k", keyword ?? ""),
                new SqlParameter("@offset", (_pageIndex - 1) * _pageSize),
                new SqlParameter("@pageSize", _pageSize)
            };
            DataTable dt = SQLHelper.Query(sql, ps);

            if (dt.Rows.Count == 0 && _pageIndex > 1)
            {
                _pageIndex--;
                LoadData();
                return;
            }

            _imageCache.Clear();
            string defaultImg = Path.Combine(Application.StartupPath, "Sys_images", "Placeholders", "Goods_img_default.png");
            Image? defaultImage = File.Exists(defaultImg) ? Image.FromFile(defaultImg) : null;
            foreach (DataRow row in dt.Rows)
            {
                int goodsId = Convert.ToInt32(row["goods_id"]);
                Image? img = null;
                string? path = row["image_url"]?.ToString();
                if (!string.IsNullOrEmpty(path))
                {
                    string fullPath = Path.Combine(Application.StartupPath, path);
                    if (File.Exists(fullPath))
                        img = Image.FromFile(fullPath);
                }
                _imageCache[goodsId] = img ?? defaultImage!;
            }

            dgv_Goods.DataSource = dt;
            UpdatePageInfo();
        }

        private void dgv_Goods_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_Goods.Columns[e.ColumnIndex].Name == "image_url" && e.RowIndex >= 0)
            {
                if (dgv_Goods.Rows[e.RowIndex].DataBoundItem is DataRowView drv)
                {
                    int goodsId = Convert.ToInt32(drv["goods_id"]);
                    if (_imageCache.TryGetValue(goodsId, out var img))
                    {
                        e.Value = img;
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void UpdatePageInfo()
        {
            if (_totalCount == 0)
            {
                lbl_PageInfo.Text = "暂无数据";
                btn_Prev.Enabled = false;
                btn_Next.Enabled = false;
                return;
            }
            lbl_PageInfo.Text = $"第 {_pageIndex}/{_totalPages} 页，共 {_totalCount} 条";
            btn_Prev.Enabled = _pageIndex > 1;
            btn_Next.Enabled = _pageIndex < _totalPages;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            _keyword = txt_Search.Text.Trim();
            _pageIndex = 1;
            LoadData();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            _keyword = "";
            _pageIndex = 1;
            LoadData();
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (_pageIndex > 1)
            {
                _pageIndex--;
                LoadData();
            }
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (_pageIndex < _totalPages)
            {
                _pageIndex++;
                LoadData();
            }
        }

        private void btn_ViewDetail_Click(object sender, EventArgs e)
        {
            if (dgv_Goods.CurrentRow == null)
            {
                ShowTip("请先选中一个商品");
                return;
            }

            int goodsId = Convert.ToInt32(dgv_Goods.CurrentRow.Cells["goods_id"].Value);
            FrmGoodsDetail frmDetail = new FrmGoodsDetail(goodsId);
            frmDetail.ShowDialog();

            LoadData();
        }

        private void dgv_Goods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ViewDetail_Click(sender, e);
        }
    }
}
