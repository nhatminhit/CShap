   M S B A M L   `   `   `  ����C  ?thuchanh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:thuchanhthuchanh  5   	       thuchanh.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:thuchanh     5   	     � Title$  Quản lý nhân viên��5      $	��450��6"   $	��800��6/   .��5	      � .+�5
   
   �� $��Quản lý nhân viên��6   $��Center=�6,   $��0,20,0,0q�6I   $	��Top=�6[   $��Times New Roman)�6s   $��30(�6�   $
��Bold"�6�   �� 5   
   $��Tên nhân viên: ��6   $
��Left=�6*   $��
173,70,0,0q�6E   $	��Top=�6Y   $��Times New Roman)�6q   $��15(�6�   �� 5   
   $��Phòng ban: ��6   $
��Left=�6&   $��195,100,0,0q�6A   $	��Top=�6V   $��Times New Roman)�6n   $��15(�6�   �� 5   
   $��Ngoại ngữ: ��6   $
��Left=�6&   $��195,130,0,0q�6A   $	��Top=�6V   $��Times New Roman)�6n   $��15(�6�   �� 5   
   $��Ngày sinh: ��6   $
��Left=�6&   $��198,160,0,0q�6A   $	��Top=�6V   $��Times New Roman)�6n   $��15(�6�   �� 5   
   $��Số ngày làm việc: ��6   $
��Left=�6-   $��155,190,0,0q�6H   $	��Top=�6]   $��Times New Roman)�6u   $��15(�6�   �� 5   
   -   5        $��txtTen��5      $
��Left=�6    $��
280,73,0,0q�6;   $�� ��6O    �� TextWrapping$
 Wrap=�6W   $	��Top=�6k   $	��180��6�   $��20��6�   $��15(�6�   $��Times New Roman)�6�   �� 5   
   -   5        $��	txtSoNgay��5      $
��Left=�6#   $��280,193,0,0q�6>   $�� ��6S   $
 Wrap=�6[   $	��Top=�6o   $	��180��6�   $��20��6�   $��15(�6�   $��Times New Roman)�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��dtpNgaySinh��5      $
��Left=�6(   $��280,163,0,0q�6C   $	��Top=�6X   $��20��6p   $��15(�6|   $	��180��6�   $��Times New Roman)�6�   �� 5   
   $��Danh sách nhân viên��6   $
��Left=�6.   $��144,220,0,0q�6I   $	��Top=�6^   $��Times New Roman)�6v   $��15(�6�   $��Italic$�6�   �� 5   
   -   5        $��	lbHienThi��5      $
��Left=�6#   $��93��6>   $��155,263,0,0q�6J   $	��Top=�6_   $	��450��6w   $��15(�6�   $��Times New Roman)�6�   .@�5      �� $��15(�6   .��6(   DBTrần Văn An - Tổ chức - Anh, Trung - 17/07/2000 - 2.000.0006e   5      �� 5   
   -   5        $��Thêm��5      $
��Left=�6    $��225,381,0,0q�6;   $	��Top=�6P   $��50��6h   $��25��6s   $��15(�6   $��Times New Roman)�6�   6�   �� 5   
   -   5        $
��Xóa��5      $
��Left=�6   $��325,381,0,0q�6:   $	��Top=�6O   $��50��6g   $��25��6r   $��15(�6~   $��Times New Roman)�6�   6�   �� 5   
   -   5        $��Window 2��5      $
��Left=�6&   $��424,381,0,0q�6A   $	��Top=�6V   $��77��6n   $��25��6y   $��15(�6�   $��Times New Roman)�6�   6�   �� 5   
   -   5        $��cboPhongBan��5      $
��Left=�6&   $��280,105,0,0q�6A   $	��Top=�6V   $	��120��6n   $��20��6z    �� SelectedIndex$ 0��6�   $��Times New Roman)�6�   .@�5      �� .��6   Tổ chức6$   �� 5      .��6   	Vật tư6#   �� 5      .��6   Tài chính6&   �� 5      .��6   
Kế toán6$   5      �� 5    
   -	   5        $��cbkAnh��5       $	��Anh��6!   $
��Left=�6/   $��280,135,0,0q�6J   $	��Top=�6_   $��Times New Roman)�6w   �� 5!   
   -
   5        $��cbkPhap��5!      $��Pháp��6"   $
��Left=�61   $��345,135,0,0q�6L   $	��Top=�6a   $��Times New Roman)�6y   �� 5"   
   -   5        $��cbkTrung��5"      $��Trung��6#   $
��Left=�63   $��416,135,0,0q�6N   $	��Top=�6c   $��Times New Roman)�6{   5#      5$      