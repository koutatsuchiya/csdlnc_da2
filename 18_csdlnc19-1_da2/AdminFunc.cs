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
    public partial class AdminFunc : Form
    {
        private int hd;
        public AdminFunc()
        {
            InitializeComponent();
        }

        private void findTenBut_Click(object sender, EventArgs e)
        {
            if (!tenspText.Text.Equals(""))
            {
                string find = tenspText.Text;
                ConCungShopEntities conCung = new ConCungShopEntities();
                List<SanPham> sps = conCung.SanPhams.ToList();
                tendgv.Rows.Clear();
                foreach (var item in sps)
                    if (item.Ten_SP.ToLower().Contains(find.ToLower()))
                    {
                        int index = tendgv.Rows.Add();
                        tendgv.Rows[index].Cells[0].Value = item.Ma_SP;
                        tendgv.Rows[index].Cells[1].Value = item.Ten_SP;
                        tendgv.Rows[index].Cells[2].Value = item.Ten_NhanHieu;
                        tendgv.Rows[index].Cells[3].Value = item.Ten_Loai;
                        tendgv.Rows[index].Cells[4].Value = item.SoLuongTon;
                    }
            }
        }

        private void seeDBut_Click(object sender, EventArgs e)
        {
            if (rbDn.Checked)
            {
                ConCungShopEntities conCung = new ConCungShopEntities();
                List<HoaDonNhap> dns = conCung.HoaDonNhaps.ToList();
                List<DoiTac> dts = conCung.DoiTacs.ToList();
                List<NhanVien> nvs = conCung.NhanViens.ToList();
                hddgv.Rows.Clear();
                foreach (var item in dns)
                {
                    var ncc = dts.Where(p => p.Ma_DT == item.Ma_NCC).Select(p => p.Ten_DT).ToList();
                    List<string> nv = new List<string>();
                    if (item.Ma_NV_Nhan != null)
                        nv = nvs.Where(p => p.Ma_NV == item.Ma_NV_Nhan).Select(p => p.Ten_NV).ToList();
                    else
                        nv.Add("");
                    int index = hddgv.Rows.Add();
                    hddgv.Rows[index].Cells[0].Value = item.Ma_DN;
                    hddgv.Rows[index].Cells[1].Value = item.NgayLap_DN;
                    hddgv.Rows[index].Cells[2].Value = ncc[0];
                    hddgv.Rows[index].Cells[5].Value = item.Ma_CN;
                    hddgv.Rows[index].Cells[6].Value = nv[0];
                    hddgv.Rows[index].Cells[8].Value = item.TinhTrang_DN;
                }
            }
            else if (rbDx.Checked)
            {
                ConCungShopEntities conCung = new ConCungShopEntities();
                List<HoaDonXuat> dxs = conCung.HoaDonXuats.ToList();
                List<NhanVien> nvs = conCung.NhanViens.ToList();
                hddgv.Rows.Clear();
                foreach (var item in dxs)
                {
                    var nv = nvs.Where(p => p.Ma_NV == item.Ma_NV_Lap).Select(p => p.Ten_NV).ToList();
                    int index = hddgv.Rows.Add();
                    hddgv.Rows[index].Cells[0].Value = item.Ma_DX;
                    hddgv.Rows[index].Cells[1].Value = item.NgayLap_DX;
                    hddgv.Rows[index].Cells[3].Value = item.Ten_KH;
                    hddgv.Rows[index].Cells[4].Value = item.DienThoai_KH;
                    hddgv.Rows[index].Cells[5].Value = item.Ma_CN;
                    hddgv.Rows[index].Cells[6].Value = nv[0];
                    hddgv.Rows[index].Cells[7].Value = item.Ten_CtyVC;
                    hddgv.Rows[index].Cells[8].Value = item.TinhTrang_DX;
                    hddgv.Rows[index].Cells[9].Value = item.TongTien;
                }
            }
        }

        private void hddgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            hddgv.CurrentRow.Selected = true;
            hd = Convert.ToInt32(hddgv.Rows[e.RowIndex].Cells[0].Value);
            if (rbDn.Checked)
            {
                CTHD cthd = new CTHD(hd, 0);
                cthd.Show();
            }
            else if(rbDx.Checked)
            {
                CTHD cthd = new CTHD(hd, 1);
                cthd.Show();
            }
        }
    }
}
