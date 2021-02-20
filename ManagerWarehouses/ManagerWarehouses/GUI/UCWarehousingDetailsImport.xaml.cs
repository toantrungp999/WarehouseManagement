using ManagerWarehouses.DAL;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ManagerWarehouses.GUI
{
    /// <summary>
    /// Interaction logic for UserControlWarehousingDetailsl.xaml
    /// </summary>
    public partial class UCWarehousingDetails : UserControl
    {
        bool isDelete;
        private long idImport;
        public UCWarehousingDetails(Import import)
        {
            InitializeComponent();
            Console.WriteLine("Tạo và hiển thị UserControl chi tiết nhập kho");
            idImport = import.Import_ID;
            _txtFullName.Text = Global.EmployeesBLL.GetEmployee(import.ImportBy).FullName;
            _txtEmployee_id.Text = import.ImportBy.ToString();
            _txtNote.Text = import.Note != null ? import.Note : "";
            _txtDate.Text = import.ImportDate;
            var items = import.Shoes.ToList();
            for (int j = items.Count - 1; j >= 0; j--)
            {
                if (items[j].Status == 1)
                    _dataGridListShoes.Items.Add(items[j]);
            }
        }

        private void _btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (!isDelete)
            {
                _btnDelete.Content = "Xác nhận";
                isDelete = true;
                _txtNoteDelete.IsEnabled = true;
                return;
            }
            Facade.DeleteImport(idImport, _txtNoteDelete.Text);
            Global.UCManagerListImport.DeleteDataGrid(idImport);
            MessageBox.Show("Xóa thành công");
            Global.MainWindow._PanelBody.Children.Remove(this);
            Global.MainWindow._PanelBody.Children.Add(Global.UCManagerImAndEx);
        }
    }
}
