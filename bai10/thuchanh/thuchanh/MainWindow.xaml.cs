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

namespace thuchanh
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<NhanVien> nv = new List<NhanVien>();
        public MainWindow()
        {
            InitializeComponent();
            nv.Add(new NhanVien("Trần Văn An","Tổ chức", "Anh, Trung", DateTime.Parse("12 / 12 / 2000"),20, 2000000)) ;
        }

        private void Button_Click(object sender, RoutedEventArgs e)

        {
            if (txtTen.Text == null || cboPhongBan.SelectedIndex < 0 || dtpNgaySinh.SelectedDate == null || txtSoNgay == null)
            {
                MessageBox.Show("Phải nhập vào tất cả dữ liệu (trừ checkbox)");
            }
            else
            {
                string strText, strNgoaiNgu = "";
                int luong;
                int soNgay = int.Parse(txtSoNgay.Text);
                if (soNgay <= 20)
                {
                    luong = soNgay * 100000;
                }
                else
                {
                    luong = 2000000 + (soNgay - 20) * 200000;
                }
                if (cbkAnh.IsChecked == true)
                {
                    strNgoaiNgu = (strNgoaiNgu.Length == 0) ? "Anh" : ("Anh, " + strNgoaiNgu);
                }
                if (cbkPhap.IsChecked == true)
                {
                    strNgoaiNgu = (strNgoaiNgu.Length == 0) ? "Pháp" : (strNgoaiNgu + ", Pháp");
                }
                if (cbkTrung.IsChecked == true)
                {
                    strNgoaiNgu = (strNgoaiNgu.Length == 0) ? "Trung" : (strNgoaiNgu + ", Trung");
                }
                nv.Add(new NhanVien(txtTen.Text, cboPhongBan.Text, strNgoaiNgu, dtpNgaySinh.SelectedDate.Value, soNgay, luong));
                strText = txtTen + " - " + cboPhongBan.Text + " - " + strNgoaiNgu + " - " + dtpNgaySinh.Text + " - " + luong;
                lbHienThi.Items.Add(strText.Substring(33));
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtTen.Text = "";
            txtTen.Focus();
            cboPhongBan.SelectedIndex = -1;
            cbkAnh.IsChecked = false;
            cbkPhap.IsChecked = false;
            cbkTrung.IsChecked = false;
            txtSoNgay.Text = "";
            dtpNgaySinh.SelectedDate = DateTime.Now.AddDays(0);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 myWindow = new Window2();
            int length = nv.Count() - 1;
            myWindow.lblTen2.Text = nv[length].Ten;
            myWindow.cboPhongBan2.Text = nv[length].PhongBan;
            string[] ngoaiNgu = nv[length].NgoaiNgu.Split(", ");
            foreach (var item in ngoaiNgu)
            {
                if (item == "Anh") myWindow.cbkAnh2.IsChecked = true;
                if (item == "Pháp") myWindow.cbkPhap2.IsChecked = true;
                if (item == "Trung") myWindow.cbkTrung2.IsChecked = true;
            }
            myWindow.dtpNgaySinh2.SelectedDate = nv[length].NgaySinh;
            myWindow.txtSoNgay2.Text = nv[length].SoNgay.ToString();
            myWindow.txtluong.Text = nv[length].Luong.ToString();
            myWindow.Show();
        }
    }
    public class NhanVien
    {
        public string Ten { set; get; }
        public string PhongBan { set; get; }
        public string NgoaiNgu { set; get; }
        public DateTime NgaySinh { set; get; }
        public int SoNgay { set; get; }
        public int Luong { set; get; }
        public NhanVien()
        {

        }
        public NhanVien(string ten, string phong, string ngoaingu, DateTime ns, int songay, int luong)
        {
            this.Ten = ten;
            this.PhongBan = phong;
            this.NgoaiNgu = ngoaingu;
            this.NgaySinh = ns;
            this.SoNgay = songay;
            this.Luong = luong;
        }
    }
}

