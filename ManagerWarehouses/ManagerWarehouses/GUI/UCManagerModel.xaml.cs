using ManagerWarehouses.DAL;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ManagerWarehouses.GUI
{
    /// <summary>
    /// Interaction logic for UserControlManagerModel.xaml
    /// </summary>
    public partial class UCManagerModel : UserControl
    {
        public UCManagerModel()
        {
            InitializeComponent();
            Console.WriteLine("Tạo và hiển thị UserControlManagerModel");
            Facade.ReadTypeShoes();
            Facade.ReadModelShoes();
            Facade.ReadCompany();
            _cbType.DisplayMemberPath = "TypeName";
            _cbType.SelectedValuePath = "Type_ID";
            for (int i = Global.ListTypeShoe.Count - 1; i >= 0; i--)
                _cbType.Items.Add(Global.ListTypeShoe[i]);
            _cbCompany.DisplayMemberPath = "CompanyName";
            _cbCompany.SelectedValuePath = "Companny_ID";
            for (int i = Global.ListCompany.Count - 1; i >= 0; i--)
                _cbCompany.Items.Add(Global.ListCompany[i]);
            for (int i = Global.ListModelShoes.Count - 1; i >= 0; i--)
                _dataGridModelShoes.Items.Add(new { Global.ListModelShoes[i].ModelShoes_ID, Global.ListModelShoes[i].NameShoese, Global.ListModelShoes[i].TypeShoe.TypeName, Global.ListModelShoes[i].Company.CompanyName });

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            if (_dataGridModelShoes.SelectedIndex < 0)
                return;
            int id = _dataGridModelShoes.Items[_dataGridModelShoes.SelectedIndex].GetPropertyValue("ModelShoes_ID").ToInt32();
            Facade.DeleteModelShoes(id);
            _dataGridModelShoes.Items.Remove(_dataGridModelShoes.SelectedItem);
            MessageBox.Show("Xóa loại giày thành công");
        }

        private void _btnAddNewModel_Click(object sender, RoutedEventArgs e)
        {
            if (_cbCompany.SelectedIndex < 0 || _cbType.SelectedIndex < 0)
                return;
            int company_id = _cbCompany.Items[_cbCompany.SelectedIndex].GetPropertyValue("Companny_ID").ToInt32();
            int type_id = _cbType.Items[_cbType.SelectedIndex].GetPropertyValue("Type_ID").ToInt32();
            Facade.CreateModel(_txtName.Text.Trim(), company_id, type_id);
            _dataGridModelShoes.Items.Add(new { Global.ListModelShoes.Last().ModelShoes_ID, Global.ListModelShoes.Last().NameShoese, TypeName = _cbType.Text, CompanyName = _cbCompany.Text });
            MessageBox.Show("Thêm loại mẫu thành công");
        }

        private void _btnUpdateModel_Click(object sender, RoutedEventArgs e)
        {

        }

        public void RemoveComboboxCompany(int id)
        {
            for (int i = _cbCompany.Items.Count - 1; i >= 0; i--)
                if (_cbCompany.Items[i].GetPropertyValue("Companny_ID").ToInt32() == id)
                {
                    _cbCompany.Items.RemoveAt(i);
                    break;
                }
        }

        public void RemoveComboboxTypeShoes(int id)
        {
            for (int i = _cbType.Items.Count - 1; i >= 0; i--)
                if (_cbType.Items[i].GetPropertyValue("Type_ID").ToInt32() == id)
                {
                    _cbType.Items.RemoveAt(i);
                    break;
                }
        }

        public void AddComboboxCompany(Company company)
        {
            _cbCompany.Items.Add(company);
        }

        public void AddComboboxTypeShoes(TypeShoe typeShoe)
        {
            _cbType.Items.Add(typeShoe);
        }
    }
}
