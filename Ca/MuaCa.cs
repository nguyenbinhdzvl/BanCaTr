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
    public partial class MuaCa : Form
    {
        public MuaCa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/BanCa/New%20folder/pngtree-blue-and-black-fighting-fish-is-shown-picture-image_2658478.jpg";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/New%20folder/unnamed.png";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            // Giá tiền của cá
            decimal giaTien = 30; // Thay thế bằng giá tiền thực tế

            // Thông tin chung về cá
            string thongTinChung = "Phần thân cá cũng nhỏ, lưng có phần hơi gù, xung quanh phần lưng cho đến phần bụng được bao phủ bởi một lớp vảy óng ánh mềm mại. Điểm nhấn đặc biệt mà ai cũng thích ở cá đá là phần đuôi khá dài, có đa dạng kiểu cách và màu sắc khác nhau. Bên cạnh đó, loài cá này còn có thêm một cơ quan hô hấp được gọi là labyrinth";

            // Tên cá
            string tenCa = "Cá Guppy"; // Thay thế bằng tên cá thực tế

            // Hiển thị giá tiền trong textBox19
            textBox20.Text = giaTien.ToString();

            // Hiển thị thông tin chung trong textBox18
            textBox18.Text = thongTinChung;

            // Hiển thị tên cá trong textBox17
            textBox17.Text = tenCa;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/Betta-Fish-Wallpapers.jpg";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            // Giá tiền của cá
            decimal giaTien = ; // Thay thế bằng giá tiền thực tế

            // Thông tin chung về cá
            string thongTinChung = "Phần thân cá cũng nhỏ, lưng có phần hơi gù, xung quanh phần lưng cho đến phần bụng được bao phủ bởi một lớp vảy óng ánh mềm mại. Điểm nhấn đặc biệt mà ai cũng thích ở cá đá là phần đuôi khá dài, có đa dạng kiểu cách và màu sắc khác nhau. Bên cạnh đó, loài cá này còn có thêm một cơ quan hô hấp được gọi là labyrinth";

            // Tên cá
            string tenCa = "Cá Diếc Anh Đào"; // Thay thế bằng tên cá thực tế

            // Hiển thị giá tiền trong textBox19
            textBox20.Text = giaTien.ToString();

            // Hiển thị thông tin chung trong textBox18
            textBox18.Text = thongTinChung;

            // Hiển thị tên cá trong textBox17
            textBox17.Text = tenCa;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/New%20folder/hinh-nen-ca-betta.jpg";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            // Giá tiền của cá
            decimal giaTien = 235; // Thay thế bằng giá tiền thực tế

            // Thông tin chung về cá
            string thongTinChung = "Phần thân cá cũng nhỏ, lưng có phần hơi gù, xung quanh phần lưng cho đến phần bụng được bao phủ bởi một lớp vảy óng ánh mềm mại. Điểm nhấn đặc biệt mà ai cũng thích ở cá đá là phần đuôi khá dài, có đa dạng kiểu cách và màu sắc khác nhau. Bên cạnh đó, loài cá này còn có thêm một cơ quan hô hấp được gọi là labyrinth";

            // Tên cá
            string tenCa = "Cá Ba Đuôi "; // Thay thế bằng tên cá thực tế

            // Hiển thị giá tiền trong textBox19
            textBox20.Text = giaTien.ToString();

            // Hiển thị thông tin chung trong textBox18
            textBox18.Text = thongTinChung;

            // Hiển thị tên cá trong textBox17
            textBox17.Text = tenCa;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/New%20folder/Hinh-nen-ca-Betta-dep-nhat-2-326x580.jpg";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            // Giá tiền của cá
            decimal giaTien = 345; // Thay thế bằng giá tiền thực tế

            // Thông tin chung về cá
            string thongTinChung = "Phần thân cá cũng nhỏ, lưng có phần hơi gù, xung quanh phần lưng cho đến phần bụng được bao phủ bởi một lớp vảy óng ánh mềm mại. Điểm nhấn đặc biệt mà ai cũng thích ở cá đá là phần đuôi khá dài, có đa dạng kiểu cách và màu sắc khác nhau. Bên cạnh đó, loài cá này còn có thêm một cơ quan hô hấp được gọi là labyrinth";

            // Tên cá
            string tenCa = "Cá Ông Tiên"; // Thay thế bằng tên cá thực tế

            // Hiển thị giá tiền trong textBox19
            textBox20.Text = giaTien.ToString();

            // Hiển thị thông tin chung trong textBox18
            textBox18.Text = thongTinChung;

            // Hiển thị tên cá trong textBox17
            textBox17.Text = tenCa;
        }

        private void button6_Click(object sender, EventArgs e)
        {

            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/New%20folder/hinh-nen-ca-betta-1.jpg";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            // Giá tiền của cá
            decimal giaTien = 100; // Thay thế bằng giá tiền thực tế

            // Thông tin chung về cá
            string thongTinChung = "Phần thân cá cũng nhỏ, lưng có phần hơi gù, xung quanh phần lưng cho đến phần bụng được bao phủ bởi một lớp vảy óng ánh mềm mại. Điểm nhấn đặc biệt mà ai cũng thích ở cá đá là phần đuôi khá dài, có đa dạng kiểu cách và màu sắc khác nhau. Bên cạnh đó, loài cá này còn có thêm một cơ quan hô hấp được gọi là labyrinth";

            // Tên cá
            string tenCa = "Cá Mún"; // Thay thế bằng tên cá thực tế

            // Hiển thị giá tiền trong textBox19
            textBox20.Text = giaTien.ToString();

            // Hiển thị thông tin chung trong textBox18
            textBox18.Text = thongTinChung;

            // Hiển thị tên cá trong textBox17
            textBox17.Text = tenCa;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/New%20folder/images%20(1).jfif";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            // Giá tiền của cá
            decimal giaTien = 456; // Thay thế bằng giá tiền thực tế

            // Thông tin chung về cá
            string thongTinChung = "Phần thân cá cũng nhỏ, lưng có phần hơi gù, xung quanh phần lưng cho đến phần bụng được bao phủ bởi một lớp vảy óng ánh mềm mại. Điểm nhấn đặc biệt mà ai cũng thích ở cá đá là phần đuôi khá dài, có đa dạng kiểu cách và màu sắc khác nhau. Bên cạnh đó, loài cá này còn có thêm một cơ quan hô hấp được gọi là labyrinth";

            // Tên cá
            string tenCa = "Cá Cánh Buồm"; // Thay thế bằng tên cá thực tế

            // Hiển thị giá tiền trong textBox19
            textBox20.Text = giaTien.ToString();

            // Hiển thị thông tin chung trong textBox18
            textBox18.Text = thongTinChung;

            // Hiển thị tên cá trong textBox17
            textBox17.Text = tenCa;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/6ea6f87bd1266879a59c6d133d861616.jpg";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            // Giá tiền của cá
            decimal giaTien = 785; // Thay thế bằng giá tiền thực tế

            // Thông tin chung về cá
            string thongTinChung = "Phần thân cá cũng nhỏ, lưng có phần hơi gù, xung quanh phần lưng cho đến phần bụng được bao phủ bởi một lớp vảy óng ánh mềm mại. Điểm nhấn đặc biệt mà ai cũng thích ở cá đá là phần đuôi khá dài, có đa dạng kiểu cách và màu sắc khác nhau. Bên cạnh đó, loài cá này còn có thêm một cơ quan hô hấp được gọi là labyrinth";

            // Tên cá
            string tenCa = "Cá Chuột"; // Thay thế bằng tên cá thực tế

            // Hiển thị giá tiền trong textBox19
            textBox20.Text = giaTien.ToString();

            // Hiển thị thông tin chung trong textBox18
            textBox18.Text = thongTinChung;

            // Hiển thị tên cá trong textBox17
            textBox17.Text = tenCa;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/images.jfif";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            // Giá tiền của cá
            decimal giaTien = 100; // Thay thế bằng giá tiền thực tế

            // Thông tin chung về cá
            string thongTinChung = "Phần thân cá cũng nhỏ, lưng có phần hơi gù, xung quanh phần lưng cho đến phần bụng được bao phủ bởi một lớp vảy óng ánh mềm mại. Điểm nhấn đặc biệt mà ai cũng thích ở cá đá là phần đuôi khá dài, có đa dạng kiểu cách và màu sắc khác nhau. Bên cạnh đó, loài cá này còn có thêm một cơ quan hô hấp được gọi là labyrinth";

            // Tên cá
            string tenCa = "Cá Trân Châu"; // Thay thế bằng tên cá thực tế

            // Hiển thị giá tiền trong textBox19
            textBox20.Text = giaTien.ToString();

            // Hiển thị thông tin chung trong textBox18
            textBox18.Text = thongTinChung;

            // Hiển thị tên cá trong textBox17
            textBox17.Text = tenCa;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/images%20(2).jfif";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            // Giá tiền của cá
            decimal giaTien = 68; // Thay thế bằng giá tiền thực tế

            // Thông tin chung về cá
            string thongTinChung = "Phần thân cá cũng nhỏ, lưng có phần hơi gù, xung quanh phần lưng cho đến phần bụng được bao phủ bởi một lớp vảy óng ánh mềm mại. Điểm nhấn đặc biệt mà ai cũng thích ở cá đá là phần đuôi khá dài, có đa dạng kiểu cách và màu sắc khác nhau. Bên cạnh đó, loài cá này còn có thêm một cơ quan hô hấp được gọi là labyrinth";

            // Tên cá
            string tenCa = "Cá Molly"; // Thay thế bằng tên cá thực tế

            // Hiển thị giá tiền trong textBox19
            textBox20.Text = giaTien.ToString();

            // Hiển thị thông tin chung trong textBox18
            textBox18.Text = thongTinChung;

            // Hiển thị tên cá trong textBox17
            textBox17.Text = tenCa;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/images%20(3).jfif";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            // Giá tiền của cá
            decimal giaTien = 100000; // Thay thế bằng giá tiền thực tế

            // Thông tin chung về cá
            string thongTinChung = "Phần thân cá cũng nhỏ, lưng có phần hơi gù, xung quanh phần lưng cho đến phần bụng được bao phủ bởi một lớp vảy óng ánh mềm mại. Điểm nhấn đặc biệt mà ai cũng thích ở cá đá là phần đuôi khá dài, có đa dạng kiểu cách và màu sắc khác nhau. Bên cạnh đó, loài cá này còn có thêm một cơ quan hô hấp được gọi là labyrinth";

            // Tên cá
            string tenCa = "Cá Sặc Gấm"; // Thay thế bằng tên cá thực tế

            // Hiển thị giá tiền trong textBox19
            textBox20.Text = giaTien.ToString();

            // Hiển thị thông tin chung trong textBox18
            textBox18.Text = thongTinChung;

            // Hiển thị tên cá trong textBox17
            textBox17.Text = tenCa;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/New%20folder/download%20(2).jfif";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            // Giá tiền của cá
            decimal giaTien = 843; // Thay thế bằng giá tiền thực tế

            // Thông tin chung về cá
            string thongTinChung = "Phần thân cá cũng nhỏ, lưng có phần hơi gù, xung quanh phần lưng cho đến phần bụng được bao phủ bởi một lớp vảy óng ánh mềm mại. Điểm nhấn đặc biệt mà ai cũng thích ở cá đá là phần đuôi khá dài, có đa dạng kiểu cách và màu sắc khác nhau. Bên cạnh đó, loài cá này còn có thêm một cơ quan hô hấp được gọi là labyrinth";

            // Tên cá
            string tenCa = "Cá Rồng"; // Thay thế bằng tên cá thực tế

            // Hiển thị giá tiền trong textBox19
            textBox20.Text = giaTien.ToString();

            // Hiển thị thông tin chung trong textBox18
            textBox18.Text = thongTinChung;

            // Hiển thị tên cá trong textBox17
            textBox17.Text = tenCa;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/New%20folder/hinh-nen-ca-betta-1.jpg";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            // Giá tiền của cá
            decimal giaTien = 325; // Thay thế bằng giá tiền thực tế

            // Thông tin chung về cá
            string thongTinChung = "Phần thân cá cũng nhỏ, lưng có phần hơi gù, xung quanh phần lưng cho đến phần bụng được bao phủ bởi một lớp vảy óng ánh mềm mại. Điểm nhấn đặc biệt mà ai cũng thích ở cá đá là phần đuôi khá dài, có đa dạng kiểu cách và màu sắc khác nhau. Bên cạnh đó, loài cá này còn có thêm một cơ quan hô hấp được gọi là labyrinth";

            // Tên cá
            string tenCa = "Cá Neon"; // Thay thế bằng tên cá thực tế

            // Hiển thị giá tiền trong textBox19
            textBox20.Text = giaTien.ToString();

            // Hiển thị thông tin chung trong textBox18
            textBox18.Text = thongTinChung;

            // Hiển thị tên cá trong textBox17
        }

        private void button14_Click(object sender, EventArgs e)
        {

            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/download.jfif";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            // Giá tiền của cá
            decimal giaTien = 100; // Thay thế bằng giá tiền thực tế

            // Thông tin chung về cá
            string thongTinChung = "Phần thân cá cũng nhỏ, lưng có phần hơi gù, xung quanh phần lưng cho đến phần bụng được bao phủ bởi một lớp vảy óng ánh mềm mại. Điểm nhấn đặc biệt mà ai cũng thích ở cá đá là phần đuôi khá dài, có đa dạng kiểu cách và màu sắc khác nhau. Bên cạnh đó, loài cá này còn có thêm một cơ quan hô hấp được gọi là labyrinth";

            // Tên cá
            string tenCa = "Tên cá của bạn"; // Thay thế bằng tên cá thực tế

            // Hiển thị giá tiền trong textBox19
            textBox20.Text = giaTien.ToString();

            // Hiển thị thông tin chung trong textBox18
            textBox18.Text = thongTinChung;

            // Hiển thị tên cá trong textBox17
            textBox17.Text = tenCa;
        }

        private void button15_Click(object sender, EventArgs e)
        {

            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/BanCa/New%20folder/pngtree-blue-and-black-fighting-fish-is-shown-picture-image_2658478.jpg";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            // Giá tiền của cá
            decimal giaTien = 654; // Thay thế bằng giá tiền thực tế

            // Thông tin chung về cá
            string thongTinChung = "Phần thân cá cũng nhỏ, lưng có phần hơi gù, xung quanh phần lưng cho đến phần bụng được bao phủ bởi một lớp vảy óng ánh mềm mại. Điểm nhấn đặc biệt mà ai cũng thích ở cá đá là phần đuôi khá dài, có đa dạng kiểu cách và màu sắc khác nhau. Bên cạnh đó, loài cá này còn có thêm một cơ quan hô hấp được gọi là labyrinth";

            // Tên cá
            string tenCa = "Cá Bút Chì Thái"; // Thay thế bằng tên cá thực tế

            // Hiển thị giá tiền trong textBox19
            textBox20.Text = giaTien.ToString();

            // Hiển thị thông tin chung trong textBox18
            textBox18.Text = thongTinChung;

            // Hiển thị tên cá trong textBox17
            textBox17.Text = tenCa;
        }

        private void button16_Click(object sender, EventArgs e)
        {

            string imageUrl = "file:///C:/Users/DZ/OneDrive/Desktop/New%20folder/images%20(4).jfif";

            try
            {
                Uri uri = new Uri(imageUrl);

                // Kiểm tra xem URL có đúng là đường dẫn cục bộ hay không
                if (uri.IsFile)
                {
                    // Lấy đường dẫn cục bộ từ URL
                    string localPath = uri.LocalPath;

                    // Hiển thị hình ảnh từ đường dẫn cục bộ trong pictureBox5
                    pictureBox5.Image = Image.FromFile(localPath);
                }
                else
                {
                    MessageBox.Show("Không phải là đường dẫn cục bộ.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message);
            }
            // Giá tiền của cá
            decimal giaTien = 436; // Thay thế bằng giá tiền thực tế

            // Thông tin chung về cá
            string thongTinChung = "Phần thân cá cũng nhỏ, lưng có phần hơi gù, xung quanh phần lưng cho đến phần bụng được bao phủ bởi một lớp vảy óng ánh mềm mại. Điểm nhấn đặc biệt mà ai cũng thích ở cá đá là phần đuôi khá dài, có đa dạng kiểu cách và màu sắc khác nhau. Bên cạnh đó, loài cá này còn có thêm một cơ quan hô hấp được gọi là labyrinth";

            // Tên cá
            string tenCa = "Sọc Ngựa Cánh Tiên"; // Thay thế bằng tên cá thực tế

            // Hiển thị giá tiền trong textBox19
            textBox20.Text = giaTien.ToString();

            // Hiển thị thông tin chung trong textBox18
            textBox18.Text = thongTinChung;

            // Hiển thị tên cá trong textBox17
            textBox17.Text = tenCa;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            {
                // Đường dẫn đến tệp văn bản để lưu thông tin
                string filePath = "D:\\luu.txt"; // Thay thế bằng đường dẫn và tên tệp thực tế

                // Nội dung cần lưu, bao gồm hình ảnh từ pictureBox5, và các thông tin từ textBox17, textBox18, và textBox20

                string info17 = textBox17.Text;
                string info18 = textBox18.Text;
                string info20 = textBox20.Text;

                // Tạo một mảng các dòng nội dung để lưu vào tệp
                string[] linesToWrite = new string[]
                {

": " + info17,
" " + info18,
" " + info20
                };
                try
                {
                    File.WriteAllLines(filePath, linesToWrite);
                    MessageBox.Show("Đã đặt hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }

            DiaChiGiaoHang hello = new DiaChiGiaoHang();
            hello.Show();

            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {

            Form1 hello = new Form1();
            hello.Show();

            this.Hide();
        }
    }
}
