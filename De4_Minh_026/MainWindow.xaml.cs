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

namespace De4_Minh_026
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
            nv.Add(new NhanVien("Trần Trung Đức", "Tổ chức",DateTime.Parse("03 / 23 / 2000"), 200, 20000));
        }

        private void Button_Click(object sender, RoutedEventArgs e)

        {
            try
            {
                if (txtTen.Text != null || cboPhongBan.SelectedIndex >= 0 || dtpNgayTuyen.SelectedDate != null || txtSlBan != null)
                {
                    string strText;
                    int hoahong;
                    int soLB = int.Parse(txtSlBan.Text);
                    if(soLB<0)
                    {
                        throw new Exception("Số lượng phải là số nguyên >0");
                    }
                    if (soLB < 100)
                    {
                        hoahong = 1000;
                    }
                    else if (soLB > 100 && soLB < 500)
                    {
                        hoahong = 2000;
                    }
                    else
                    {
                        hoahong = 3000;
                    }
                    nv.Add(new NhanVien(txtTen.Text, cboPhongBan.Text, dtpNgayTuyen.SelectedDate.Value, soLB, hoahong));
                    strText = txtTen + " - " + cboPhongBan.Text + " - " + dtpNgayTuyen.Text + " - Số lượng bán: " + soLB + " - Hoa Hồng: " + hoahong;
                    lbHienThi.Items.Add(strText.Substring(33));
                }
                else
                {
                    throw new Exception("bạn cần phải điền đầy đủ thông tin");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtTen.Text = "";
            txtTen.Focus();
            cboPhongBan.SelectedIndex = -1;
            txtSlBan.Text = "";
            dtpNgayTuyen.SelectedDate = DateTime.Now.AddDays(0);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window2 myWindow = new Window2();
            int length = nv.Count() - 1;
            myWindow.lblTen2.Text = nv[length].Ten;
            myWindow.cboPhongBan2.Text = nv[length].PhongBan;
            myWindow.dtpNgayTuyen2.SelectedDate = nv[length].NgayTuyen;
            myWindow.txtSlBan2.Text = nv[length].SLB.ToString();
            myWindow.txthoahong.Text = nv[length].HoaHong.ToString();
            myWindow.Show();
        }
    }
    public class NhanVien
    {
        public string Ten { set; get; }
        public string PhongBan { set; get; }
        public DateTime NgayTuyen { set; get; }
        public int SLB { set; get; }
        public int HoaHong { set; get; }
        public NhanVien()
        {

        }
        public NhanVien(string ten, string phong, DateTime nt, int solb, int hoahong)
        {
            this.Ten = ten;
            this.PhongBan = phong;
            this.NgayTuyen = nt;
            this.SLB = solb;
            this.HoaHong = hoahong;
        }
    }
}


