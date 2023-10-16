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
    public partial class Kiemtrahang : Form
    {
        public Kiemtrahang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Đường dẫn đến tệp văn bản bên ngoài
            string filePath = "D:\\luu.txt"; // Thay thế bằng đường dẫn và tên tệp thực tế

            try
            {
                // Đọc nội dung từ tệp văn bản
                string fileContent = File.ReadAllText(filePath);

                // Chia nội dung thành các dòng (nếu cần)
                string[] lines = fileContent.Split('\n');

                // Kiểm tra số dòng và gán thông tin lần lượt vào các TextBox
                if (lines.Length >= 3)
                {
                    textBox1.Text = lines[0];
                    textBox2.Text = lines[1];
                    textBox3.Text = lines[2];
                }
                else
                {
                    MessageBox.Show("Tệp văn bản không chứa đủ thông tin để gán vào các TextBox.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc tệp văn bản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {

            // Đường dẫn đến tệp văn bản bên ngoài
            string filePath = "D:\\diachi.txt"; // Thay thế bằng đường dẫn và tên tệp thực tế

            try
            {
                // Đọc nội dung từ tệp văn bản
                string fileContent = File.ReadAllText(filePath);

                // Chia nội dung thành các dòng (nếu cần)
                string[] lines = fileContent.Split('\n');

                // Kiểm tra số dòng và gán thông tin lần lượt vào các TextBox
                if (lines.Length >= 3)
                {
                    textBox5.Text = lines[0];
                    textBox4.Text = lines[1];
                    textBox6.Text = lines[2];
                }
                else
                {
                    MessageBox.Show("Tệp văn bản không chứa đủ thông tin để gán vào các TextBox.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc tệp văn bản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }
    }
}
