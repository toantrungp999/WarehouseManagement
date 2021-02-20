using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ManagerWarehouses.GUI
{
    /// <summary>
    /// Interaction logic for UserControlManagerType.xaml
    /// </summary>
    public partial class UCManagerType : UserControl
    {
        public UCManagerType()
        {
            InitializeComponent();
            Console.WriteLine("Tạo và hiển thị UserControlManagerType");
            Facade.ReadTypeShoes();
            for (int i = Global.ListTypeShoe.Count - 1; i >= 0; i--)
                _dataGridTypeShoes.Items.Add(Global.ListTypeShoe[i]);
        }

        private void _btnAddNewModel_Click(object sender, RoutedEventArgs e)
        {
            string name = _txtName.Text.Trim();
            if (name.Length == 0)
                return;
            Facade.CreateTypeShoes(name);
            _dataGridTypeShoes.Items.Add(Global.ListTypeShoe.Last());
            if (Global.UCManagerModel != null)
            {
                Global.UCManagerModel.AddComboboxTypeShoes(Global.ListTypeShoe.Last());
            }
            MessageBox.Show("Thêm loại giày thành công");
        }

        private void _btnUpdateModel_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (_dataGridTypeShoes.SelectedIndex < 0)
                return;
            int id = _dataGridTypeShoes.Items[_dataGridTypeShoes.SelectedIndex].GetPropertyValue("Type_ID").ToInt32();
            Facade.DeleteTypeShoes(id);
            _dataGridTypeShoes.Items.Remove(_dataGridTypeShoes.SelectedItem);
            if (Global.UCManagerModel != null)
                Global.UCManagerModel.RemoveComboboxTypeShoes(id);
            MessageBox.Show("Xóa loại giày thành công");
        }
    }
}
