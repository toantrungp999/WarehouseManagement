using ManagerWarehouses.DAL;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ManagerWarehouses.GUI
{
    /// <summary>
    /// Interaction logic for UserControlWarehousing.xaml
    /// </summary>
    public partial class UCWarehousingImport : UserControl
    {
        private List<int> Size = new List<int>();
        private List<Shoes> tmpListShoes = new List<Shoes>();//doi ten
        public UCWarehousingImport()
        {
            InitializeComponent();
            Global.UCWarehousingImport = this;
            Console.WriteLine("Tạo và hiển thị UserControl nhập kho");
            for (int i = 22; i < 44; i++)
                Size.Add(i);
            _cbSize.ItemsSource = Size;
            _cbColor.ItemsSource = Global.Color;
            Facade.ReadModelShoes();
            _cbModel.DisplayMemberPath = "NameShoese";
            _cbModel.SelectedValuePath = "ModelShoes_ID";
            int total = Global.ListModelShoes.Count - 1;
            for (int i = total; i >= 0; i--)
                _cbModel.Items.Add(Global.ListModelShoes[i]);
        }

        private void _btnAddWarehousing_Click(object sender, RoutedEventArgs e)
        {
            if (_dataGridListShoes.Items.Count < 0)
                return;
            MessageBoxResult result = MessageBox.Show("Bạn có đã kiểm tra kỹ thông tin?", "Xác nhận", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Facade.CreateImport(tmpListShoes, _txtContent.Text, Global.Employees.Employee_ID, DateTime.Now.ToString("dd/MM/yyyy"));
                MessageBox.Show("Nhập hàng thành công");
                tmpListShoes.Clear();
                _dataGridListShoes.Items.Clear();
            }
        }

        private void _btnAddNew_Click(object sender, RoutedEventArgs e)
        {
            string NameShoese = _cbModel.Text.Trim();
            if (_cbModel.SelectedIndex < 0 || _cbColor.SelectedIndex < 0 || _cbColor.SelectedIndex < 0 || NameShoese.Length == 0)
                return;  
            Shoes shoes = new Shoes();
            shoes.ModelShoes_ID = _cbModel.Items[_cbModel.SelectedIndex].GetPropertyValue("ModelShoes_ID").ToInt32();
            shoes.Size = _cbSize.Items[_cbSize.SelectedIndex].ToInt32();
            shoes.Color = _cbColor.Items[_cbColor.SelectedIndex].ToString();
            shoes.Amount = _txtAmount.Text.ToInt32();
            shoes.Status = 1;
            tmpListShoes.Add(shoes);
            _dataGridListShoes.Items.Add(new { shoes.ModelShoes_ID, NameShoese, shoes.Size, shoes.Color, shoes.Amount });
            Clean();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (_dataGridListShoes.SelectedIndex < 0)
                return;
            tmpListShoes.Remove(tmpListShoes[_dataGridListShoes.SelectedIndex]);
            _dataGridListShoes.Items.Remove(_dataGridListShoes.SelectedItem);
            Console.WriteLine("Xóa khỏi danh sách thành công!");
        }
        private void Clean()
        {
            _txtAmount.Text = "";
            _cbModel.SelectedIndex = _cbColor.SelectedIndex = _cbColor.SelectedIndex = -1;
        }
    }
}
