using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void muaCaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void hellobtn_Click(object sender, EventArgs e)
        {
            MuaCa hello = new MuaCa();
            hello.Show();

            this.Hide();
        }

        private void kiểmTraHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kiemtrahang ka = new Kiemtrahang();
            ka.Show();
            this.Hide();
        }

        private void tưVấnVềCáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy gọi SDT: 49823498234 Để Được Tư Vấn.", "Thông báo", MessageBoxButtons.OK);
        }

        private void cậpNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chưa Có Bản Cập Nhập.", "Thông báo", MessageBoxButtons.OK);
        }

        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
