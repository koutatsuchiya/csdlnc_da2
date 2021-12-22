using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_csdlnc19_1_da2
{
    public partial class KhachHangFind : Form
    {
        private int loai = 0;
        private int dt = 0;
        public KhachHangFind()
        {
            InitializeComponent();
        }

        private void KhachHangFind_Load(object sender, EventArgs e)
        {
            ConCungShopEntities conCung = new ConCungShopEntities();
            List<Loai> types = conCung.Loais.ToList();
            List<DoiTac> dts = conCung.DoiTacs.ToList();
            List<DiaChi> dcs = conCung.DiaChis.ToList();
            loaidgv.Rows.Clear();
            foreach (var item in types)
            {
                int index = loaidgv.Rows.Add();
                loaidgv.Rows[index].Cells[0].Value = item.Ma_Loai;
                loaidgv.Rows[index].Cells[1].Value = item.Ten_Loai;
                loaidgv.Rows[index].Cells[2].Value = item.mota;
            }
            foreach (var item in dts)
            {
                var addressDt = dcs.Where(p => p.Ma_DC == item.DiaChi_DT).Select(p => new { sonha = p.SoNha, duong = p.Duong, px = p.Phuong_Xa, qh = p.Quan_Huyen, tp = p.Tinh_TP }).ToList();
                int index = dtdgv.Rows.Add();
                dtdgv.Rows[index].Cells[0].Value = item.Ma_DT;
                dtdgv.Rows[index].Cells[1].Value = item.Ten_DT;
                dtdgv.Rows[index].Cells[2].Value = item.DienThoai_DT;
                dtdgv.Rows[index].Cells[3].Value = item.Email_DT;
                dtdgv.Rows[index].Cells[4].Value = addressDt[0].sonha;
                dtdgv.Rows[index].Cells[5].Value = addressDt[0].duong;
                dtdgv.Rows[index].Cells[6].Value = addressDt[0].px;
                dtdgv.Rows[index].Cells[7].Value = addressDt[0].qh;
                dtdgv.Rows[index].Cells[8].Value = addressDt[0].tp;
            }
        }

        private void findTenBut_Click(object sender, EventArgs e)
        {
            if (!tenspText.Text.Equals(""))
            {
                string find = tenspText.Text;
                ConCungShopEntities conCung = new ConCungShopEntities();
                List<SanPham> sps = conCung.SanPhams.ToList();
                List<DoiTac> dts = conCung.DoiTacs.ToList();
                List<Loai> types = conCung.Loais.ToList();
                tendgv.Rows.Clear();
                int tt = 0;
                foreach (var item in sps)
                    if (item.Ten_SP.ToLower().Contains(find.ToLower()))
                    {
                        tt++;
                        var nhanHieu = dts.Where(p => p.Ma_DT == item.NhanHieu).Select(p => p.Ten_DT).ToList();
                        var loai = types.Where(p => p.Ma_Loai == item.Loai).Select(p => p.Ten_Loai).ToList();
                        int index = tendgv.Rows.Add();
                        tendgv.Rows[index].Cells[0].Value = item.Ma_SP;
                        tendgv.Rows[index].Cells[1].Value = item.Ten_SP;
                        tendgv.Rows[index].Cells[2].Value = item.GiaBan;
                        tendgv.Rows[index].Cells[3].Value = item.HanDung;
                        tendgv.Rows[index].Cells[4].Value = nhanHieu[0];
                        tendgv.Rows[index].Cells[5].Value = loai[0];
                        tendgv.Rows[index].Cells[6].Value = item.SoLuongTon;
                        tendgv.Rows[index].Cells[7].Value = item.CTKH;
                    }
                ttTenNoLab.Text = tt.ToString();
            }
        }

        private void loaidgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loaidgv.CurrentRow.Selected = true;
            loai = Convert.ToInt32(loaidgv.Rows[e.RowIndex].Cells[0].Value);
            ShowProduct sp = new ShowProduct(loai, 0);
            sp.Show();
        }

        private void dtdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtdgv.CurrentRow.Selected = true;
            dt = Convert.ToInt32(dtdgv.Rows[e.RowIndex].Cells[0].Value);
            ShowProduct sp = new ShowProduct(dt, 1);
            sp.Show();
        }
    }
}
