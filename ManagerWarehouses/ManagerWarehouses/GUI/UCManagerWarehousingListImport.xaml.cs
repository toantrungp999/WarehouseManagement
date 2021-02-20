using System;
using System.Windows.Controls;

namespace ManagerWarehouses.GUI
{
    /// <summary>
    /// Interaction logic for UserControlManageSupplies.xaml
    /// </summary>
    public partial class UCManagerWarehousingListImport : UserControl
    {
        public UCManagerWarehousingListImport()
        {
            InitializeComponent();
            Console.WriteLine("Tạo và hiển thị UserControl danh sách nhập kho");
            Global.UCManagerListImport = this;
            Facade.ReadImport();
            for(int i= Global.ListImport.Count-1;i>=0;i--)
                _dataGridListImport.Items.Add(Global.ListImport[i]);
        }

        private void Detail(object sender, System.Windows.RoutedEventArgs e)
        {
            int id = _dataGridListImport.Items[_dataGridListImport.SelectedIndex].GetPropertyValue("Import_ID").ToInt32();
            for (int i = Global.ListImport.Count - 1; i >= 0; i--)
            {
                if (id == Global.ListImport[i].Import_ID)
                {
                    Global.MainWindow._PanelBody.Children.Clear();
                    UCWarehousingDetails userControlWarehousingDetailsl = new UCWarehousingDetails(Global.ListImport[i]);
                    Global.MainWindow._PanelBody.Children.Add(userControlWarehousingDetailsl);
                    break;
                }
            }
        }

        public void DeleteDataGrid(long id)
        {
            for (int i = _dataGridListImport.Items.Count - 1; i >= 0; i--)
                if (_dataGridListImport.Items[i].GetPropertyValue("Import_ID").ToInt32() == id)
                {
                    _dataGridListImport.Items.RemoveAt(i);
                    break;
                }
        }
    }
}
