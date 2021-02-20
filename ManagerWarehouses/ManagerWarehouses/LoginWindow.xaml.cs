using ManagerWarehouses.Properties;
using System;
using System.Windows;

namespace ManagerWarehouses
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            //MyConsole.Start("log.txt");
            Console.WriteLine("Tạo và hiển thị Form Login");
            if (Settings.Default.Remember)
            {
                _txtUserName.Text = Settings.Default.User;
                _txtPassword.Password = Settings.Default.Password;
                _cbRememberme.IsChecked = true;
            }
        }

        private void _btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (Facade.Login(_txtUserName.Text.Trim(), _txtPassword.Password.Trim()) == false)
            {
                _txtPassword.Password = "";
                Console.WriteLine("Đăng nhập thất bại");
                MessageBox.Show("Đăng nhập thất bại! Sai tên đăng nhập hoặc mật khẩu.", "Thông báo!");
            }
            else
            {
                Console.WriteLine("Đăng nhập thành công");
                if (_cbRememberme.IsChecked.Value)
                {
                    Settings.Default.User = _txtUserName.Text;
                    Settings.Default.Password = _txtPassword.Password;
                    Settings.Default.Remember = _cbRememberme.IsChecked.Value;
                    Settings.Default.Save();
                }
                else
                    Settings.Default.Reset();
                if (Global.MainWindow == null)
                    Global.MainWindow = new MainWindow();
                Global.MainWindow.Show();
                Close();
            }
        }

        private void _btnRegisterClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
