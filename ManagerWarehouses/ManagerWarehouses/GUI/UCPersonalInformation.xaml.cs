using System;
using System.Windows;
using System.Windows.Controls;

namespace ManagerWarehouses.GUI
{
    /// <summary>
    /// Interaction logic for UserControlPersonalInformation.xaml
    /// </summary>
    public partial class UCPersonalInformation : UserControl
    {
        public UCPersonalInformation()
        {
            InitializeComponent();
            _CbSex.Items.Add("Nam");
            _CbSex.Items.Add("Nữ");
            _txtFullName.Text = Global.Employees.FullName;
            _txtPersonalCard.Text = Global.Employees.PersonalCard;
            _txtPhoneNumber.Text = Global.Employees.PhoneNumber;
            _txtParts.Text = Global.Employees.Parts;
            if (Convert.ToBoolean(Global.Employees.Sex))
                _CbSex.SelectedIndex = 0;
            else
                _CbSex.SelectedIndex = 1;
        }

        private void _btnSavaInformation_Click(object sender, RoutedEventArgs e)
        {
            int sex = _CbSex.SelectedIndex == 0 ? 1 : 0;
            Facade.UpdateEmployee(_txtFullName.Text.Trim(), _txtPersonalCard.Text.Trim(), _txtPhoneNumber.Text.Trim(), Convert.ToByte(sex));
            MessageBox.Show("Chỉnh sửa thông tin thành công!");

        }

        private void _editPassword_Click(object sender, RoutedEventArgs e)
        {
            WindowEditPassword windowEditPassword = new WindowEditPassword();
            windowEditPassword.ShowDialog();
        }
    }
}
