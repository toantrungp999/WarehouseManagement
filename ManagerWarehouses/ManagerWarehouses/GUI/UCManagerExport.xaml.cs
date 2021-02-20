using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ManagerWarehouses.GUI
{
    /// <summary>
    /// Interaction logic for UserControlManagerExport.xaml
    /// </summary>
    public partial class UCManagerExport : UserControl
    {
        private bool isFocus;
        public UCManagerExport()
        {
            InitializeComponent();
            Console.WriteLine("Tạo và hiển thị UserControl xuất kho");
            Global.UCManagerExport = this;
            Load();
            //test();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            int index = _dataGridListShoes.SelectedIndex;
            if (index < 0)
                return;
            object item = _dataGridListShoes.SelectedItem;
            int shoes_ID = (_dataGridListShoes.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text.ToInt32();
            int amount = (_dataGridListShoes.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text.ToInt32();
            WindowEditShoes editShoes = new WindowEditShoes(shoes_ID, amount, index);
            editShoes.Show();
        }

        private void _btnExport_Click(object sender, RoutedEventArgs e)
        {
            int index = _dataGridListShoes.SelectedIndex;
            if (index < 0)
                return;
            object item = _dataGridListShoes.SelectedItem;
            int shoes_ID = (_dataGridListShoes.SelectedCells[2].Column.GetCellContent(item) as TextBlock).Text.ToInt32();
            int amount = (_dataGridListShoes.SelectedCells[6].Column.GetCellContent(item) as TextBlock).Text.ToInt32();
            WindowExportShoes exportShoes = new WindowExportShoes(shoes_ID, amount, index);
            exportShoes.Show();
        }

        //System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
        //private void test()
        //{
        //    dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
        //    dispatcherTimer.Interval = new TimeSpan(0, 0, 10);
        //    dispatcherTimer.Start();
        //}
        //private void dispatcherTimer_Tick(object sender, EventArgs e)
        //{
        //    if (isFocus)
        //    {
        //        _dataGridListShoes.Items.Clear();
        //        Load();
        //    }
        //}

        public void Load()
        {
            Facade.ReadImport();
            _dataGridListShoes.Items.Clear();
            for (int i = Global.ListImport.Count - 1; i >= 0; i--)
            {
                var items = Global.ListImport[i].Shoes.ToList();
                for (int j = items.Count - 1; j >= 0; j--)
                {
                    if (items[j].Status == 1)
                        _dataGridListShoes.Items.Add(new
                        {
                            items[j].Shoes_ID,
                            items[j].ModelShoes_ID,
                            items[j].Size,
                            items[j].Color,
                            items[j].Amount,
                            Global.ListImport[i].ImportDate
                        });
                }
            }
        }

        public void DeleteDataGrid(long id)
        {
            for (int i = _dataGridListShoes.Items.Count - 1; i >= 0; i--)
                if (_dataGridListShoes.Items[i].GetPropertyValue("Shoes_ID").ToInt32() == id)
                {
                    _dataGridListShoes.Items.RemoveAt(i);
                    break;
                }
        }

        private void Grid_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            isFocus = !isFocus;
            if (isFocus)
                Load();
        }
    }
}
