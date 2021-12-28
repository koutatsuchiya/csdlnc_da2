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
    public partial class CTHD : Form
    {
        private int hd;
        //0: dn, 1: dx
        private int specifies;
        public CTHD(int hd, int specifies)
        {
            InitializeComponent();
            this.hd = hd;
            this.specifies = specifies;
        }

        private void CTHD_Load(object sender, EventArgs e)
        {
            ConCungShopEntities conCung = new ConCungShopEntities();
            List<SanPham> sps = conCung.SanPhams.ToList();
            if (specifies == 0)
            {
                List<CT_DN> ctdns = conCung.CT_DN.ToList();
                var spn = ctdns.Where(p => p.Ma_DN == hd).Select(p => new{ masp=p.Ma_SP, sl=p.SoLuong }).ToList();
                ctdgv.Rows.Clear();
                foreach (var item in spn)
                {
                    var sp = sps.Where(p => p.Ma_SP == item.masp).Select(p => new { ma=p.Ma_SP, ten=p.Ten_SP, gia=p.GiaNhap, exp=p.HanDung }).ToList();
                    int index = ctdgv.Rows.Add();
                    ctdgv.Rows[index].Cells[0].Value = sp[0].ma;
                    ctdgv.Rows[index].Cells[1].Value = sp[0].ten;
                    ctdgv.Rows[index].Cells[2].Value = sp[0].gia;
                    ctdgv.Rows[index].Cells[4].Value = sp[0].exp;
                    ctdgv.Rows[index].Cells[5].Value = item.sl;
                }
            }
            else if(specifies == 1)
            {
                List<CT_DX> ctdxs = conCung.CT_DX.ToList();
                var spx = ctdxs.Where(p => p.Ma_DX == hd).Select(p => new { masp = p.Ma_SP, sl = p.SoLuong }).ToList();
                ctdgv.Rows.Clear();
                foreach (var item in spx)
                {
                    var sp = sps.Where(p => p.Ma_SP == item.masp).Select(p => new { ma = p.Ma_SP, ten = p.Ten_SP, gia = p.GiaBan, exp = p.HanDung }).ToList();
                    int index = ctdgv.Rows.Add();
                    ctdgv.Rows[index].Cells[0].Value = sp[0].ma;
                    ctdgv.Rows[index].Cells[1].Value = sp[0].ten;
                    ctdgv.Rows[index].Cells[3].Value = sp[0].gia;
                    ctdgv.Rows[index].Cells[4].Value = sp[0].exp;
                    ctdgv.Rows[index].Cells[6].Value = item.sl;
                }
            }
        }
    }
}
