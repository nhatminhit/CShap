using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Reflection;
using btvn.Models;

namespace btvn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class QuanLyBanHang : Window
    {
        QLBanHangContext database;

        public QuanLyBanHang()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            database = new QLBanHangContext();
        }

        private void OnLoadingForm(object sender, RoutedEventArgs e)
        {
            txtNgayLap.Text = DateTime.Now.ToShortDateString();
        }

        //Khi chữ thay đổi sẽ thực hiện 1 truy vấn lên CSDL
        private void txtSoDienThoai_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = (from customer in database.KhachHangs
                         where customer.SoDT.Equals(txtSoDienThoai.Text)
                         select customer).FirstOrDefault();
            if (query != null)
            {
                txtHoTen.Text = query.TenKH;
            }
            else
            {
                txtHoTen.Clear();
            }
        }

        //Khi chữ thay đổi sẽ thực hiện 1 truy vấn lên CSDL
        private void txtMaHang_TextChanged(object sender, TextChangedEventArgs e)
        {
            var query = (from product in database.SanPhams
                         where product.MaSP.Equals(txtMaHang.Text)
                         select product).FirstOrDefault();

            if (query != null)
            {
                txtTenHang.Text = query.TenSP;
                txtĐonGia.Text = query.DonGia.ToString();
            }
            else
            {
                txtTenHang.Clear();
                txtĐonGia.Clear();
            }
        }

        private void setOnClick_btnThemHang(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHang.Text) ||
               string.IsNullOrWhiteSpace(txtTenHang.Text) ||
               string.IsNullOrWhiteSpace(txtĐonGia.Text) ||
               string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                return;
            }
            var ResSanPham = new
            {
                MaHang = txtMaHang.Text,
                TenHang = txtTenHang.Text,
                DonGia = txtĐonGia.Text,
                SoLuong = txtSoLuong.Text,
                ThanhTien = int.Parse(txtĐonGia.Text) * int.Parse(txtSoLuong.Text)
            };

            dataGridSanPham.Items.Add(ResSanPham);
            txtMaHang.Clear();
            txtSoLuong.Clear();
            txtMaHang.Focus();
        }

        private void setOnClick_btnLuuHoaDon(object sender, RoutedEventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.MaHd = txtSoHoaDon.Text;
            hoaDon.NgayLap = DateTime.Now;

            database.HoaDons.Add(hoaDon);

            foreach (var item in dataGridSanPham.Items)
            {
                Type type = item.GetType();
                PropertyInfo[] propertyInfos = type.GetProperties();

                HoaDonChiTiet hoaDonChiTiet = new HoaDonChiTiet();
                hoaDonChiTiet.MaHd = txtSoHoaDon.Text;
                hoaDonChiTiet.MaSp = propertyInfos[0].GetValue(item).ToString();
                hoaDonChiTiet.SoLuongMua = int.Parse(propertyInfos[2].GetValue(item).ToString());

                database.HoaDonChiTiets.Add(hoaDonChiTiet);
            }

            database.SaveChanges();
            MessageBox.Show("Đã Lưu Hóa Đơn Vào CSDL", "Lưu Hóa Đơn", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
