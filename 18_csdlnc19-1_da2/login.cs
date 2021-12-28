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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void khfBut_Click(object sender, EventArgs e)
        {
            KhachHangFind khf = new KhachHangFind();
            khf.Show();
        }

        private void adBut_Click(object sender, EventArgs e)
        {
            AdminFunc adf = new AdminFunc();
            adf.Show();
        }
    }
}
