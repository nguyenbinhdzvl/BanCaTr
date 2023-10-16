using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ca
{
    public partial class DiaChiGiaoHang : Form
    {
        public DiaChiGiaoHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                // Đường dẫn đến tệp văn bản để lưu thông tin
                string filePath = "D:\\diachi.txt"; // Thay thế bằng đường dẫn và tên tệp thực tế



                string info1 = textBox1.Text;
                string info3 = textBox3.Text;
                string info2 = textBox2.Text;

                // Tạo một mảng các dòng nội dung để lưu vào tệp
                string[] linesToWrite = new string[]
                {

" " + info1,
": " + info3,
" " + info2
                };
                try
                {
                    File.WriteAllLines(filePath, linesToWrite);
                    MessageBox.Show("Đã đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Không có quyền truy cập vào tệp văn bản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (IOException)
                {
                    MessageBox.Show("Lỗi khi ghi tệp văn bản. Tệp có thể đang bị khóa bởi ứng dụng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Kiemtrahang j = new Kiemtrahang();
                j.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 hello = new Form1();
            hello.Show();

            this.Hide();
        }
    }
}
