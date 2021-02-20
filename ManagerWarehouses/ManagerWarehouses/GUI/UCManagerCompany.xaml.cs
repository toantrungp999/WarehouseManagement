using System;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ManagerWarehouses.GUI
{
    /// <summary>
    /// Interaction logic for UserControlManagerModel.xaml
    /// </summary>
    public partial class UCManagerCompany : UserControl
    {
        public UCManagerCompany()
        {
            InitializeComponent();
            Console.WriteLine("Tạo và hiển thị UserControlManagerCompany");
            Facade.ReadCompany();
            for (int i = Global.ListCompany.Count - 1; i >= 0; i--)
                _dataGridCompany.Items.Add(Global.ListCompany[i]);
        }

        private void _btnAddNewModel_Click(object sender, RoutedEventArgs e)
        {
            string companyName = _txtName.Text.Trim();
            if (companyName.Length == 0)
                return;
            Facade.CreateCompany(companyName);
            _dataGridCompany.Items.Add(Global.ListCompany.Last());
            if (Global.UCManagerModel != null)
            {
                Global.UCManagerModel.AddComboboxCompany(Global.ListCompany.Last());
            }
            MessageBox.Show("Thêm hãng thành công");
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (_dataGridCompany.SelectedIndex < 0)
                return;
            int id = _dataGridCompany.Items[_dataGridCompany.SelectedIndex].GetPropertyValue("Companny_ID").ToInt32();
            Facade.DeleteCompany(id);
            _dataGridCompany.Items.Remove(_dataGridCompany.SelectedItem);
            if (Global.UCManagerModel != null)
                Global.UCManagerModel.RemoveComboboxCompany(id);
            MessageBox.Show("Xóa hãng thành công");
        }
    }
}
