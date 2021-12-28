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
    public partial class ShowProduct : Form
    {
        private int find;
        //0: tim theo loai, 1: tim theo nhan hieu
        private int specifies;
        public ShowProduct(int find, int specifies)
        {
            InitializeComponent();
            this.find = find;
            this.specifies = specifies;
        }

        private void ShowProduct_Load(object sender, EventArgs e)
        {
            ConCungShopEntities conCung = new ConCungShopEntities();
            List<SanPham> sps = conCung.SanPhams.ToList();
            tendgv.Rows.Clear();
            int tt = 0;
            bool flag = false;
            foreach (var item in sps)
            {
                switch (specifies)
                {
                    case 0:
                        if (item.Loai == find)
                            flag = true;
                        break;
                    case 1:
                        if (item.NhanHieu == find)
                            flag = true;
                        break;
                    default:
                        break;
                }
                if (flag)
                {
                    tt++;
                    int index = tendgv.Rows.Add();
                    tendgv.Rows[index].Cells[0].Value = item.Ma_SP;
                    tendgv.Rows[index].Cells[1].Value = item.Ten_SP;
                    tendgv.Rows[index].Cells[2].Value = item.GiaBan;
                    tendgv.Rows[index].Cells[3].Value = item.HanDung;
                    tendgv.Rows[index].Cells[4].Value = item.Ten_NhanHieu;
                    tendgv.Rows[index].Cells[5].Value = item.Ten_Loai;
                    tendgv.Rows[index].Cells[6].Value = item.SoLuongTon;
                    tendgv.Rows[index].Cells[7].Value = item.CTKH;
                    flag = false;
                }
            }
            ttTenNoLab.Text = tt.ToString();
        }
    }
}
