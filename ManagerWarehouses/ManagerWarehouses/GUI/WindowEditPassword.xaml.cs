using System.Windows;

namespace ManagerWarehouses.GUI
{
    /// <summary>
    /// Interaction logic for WindowEditPassword.xaml
    /// </summary>
    public partial class WindowEditPassword : Window
    {
        public WindowEditPassword()
        {
            InitializeComponent();
        }


        private void _btnChangePassword_Click(object sender, RoutedEventArgs e)
        {
            if(_txtNewPassword.Password.Trim().Length<6)
            {
                MessageBox.Show("Mật khẩu mới phải dài hơn 6 ký tự");
                return;
            }
            int check = Facade.ChangePassword(_txtOldPassword.Password.Trim(), _txtNewPassword.Password.Trim(), _txtConfirmPassowrd.Password.Trim());
            if (check == INIT.SUSSESS)
            {
                MessageBox.Show("Chỉnh sửa mật khẩu thành công");
                this.Close();
            }
            else if (check == INIT.FAIL)
                MessageBox.Show("Mật khẩu xác nhận sai");
            else
                MessageBox.Show("Nhập lại mật khẩu sai!");
        }
    }
}
