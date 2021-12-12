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
using thuchanh.Models;
namespace thuchanh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLBanHanggContext db = new QLBanHanggContext();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Loaded(object sender, RoutedEventArgs e)
        {
            hienthi();
            var queryCombo = from lsp in db.LoaiSps
                             select lsp;
            cboLoai.ItemsSource = queryCombo.ToList();
        }
        private void hienthi()
        {
            var query = from sp in db.SanPhams
                             select sp;
            dgvSanPham.ItemsSource = query.ToList();
        }
        private void setOnClick_btnThem(object sender, RoutedEventArgs e)
        {
            SanPham spMoi = new SanPham();
            spMoi.MaSp = txtMa.Text;
            spMoi.TenSp = txtTen.Text;
            spMoi.SoLuongCo = int.Parse(txtSoLuongCo.Text);
            spMoi.DonGia = int.Parse(txtDonGia.Text);
            LoaiSp lspChon = (LoaiSp)cboLoai.SelectedItem;
            spMoi.MaLoai = lspChon.MaLoai;
            db.SanPhams.Add(spMoi);
            db.SaveChanges();
            hienthi();
        }
        private void setOnClick_btnSua(object sender, RoutedEventArgs e)
        {
            var query = from sp in db.SanPhams
                        where sp.MaSp == txtMa.Text
                        select sp;
            SanPham spSua = query.FirstOrDefault();
            spSua.TenSp = txtTen.Text;
            db.SaveChanges();
            hienthi();
        }
        private void setOnClick_btnXoa(object sender, RoutedEventArgs e)
        {
            var query = from sp in db.SanPhams
                        where sp.MaSp == txtMa.Text
                        select sp;
            SanPham spXoa = query.FirstOrDefault();
            db.SanPhams.Remove(spXoa);
            db.SaveChanges();
            hienthi();
        }
        private void setOnClick_btnTim(object sender, RoutedEventArgs e)
        {
            var query = from sp in db.SanPhams
                        where sp.DonGia > 1000
                        select sp;
            dgvSanPham.ItemsSource = query.ToList();
        }
    }
}
