using System.Runtime.CompilerServices;
using System.Windows;

namespace ManagerWarehouses.GUI
{
    /// <summary>
    /// Interaction logic for ExportShoes.xaml
    /// </summary>
    public partial class WindowExportShoes : Window
    {
        private long shoes_id;
        private int export_amount = 0;
        private int amount_max;
        private int index;
        public WindowExportShoes(long shoes_id, int amount, int index)
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.shoes_id = shoes_id;
            this.amount_max = amount;
            this.index = index;
            _txtMax.Text = amount.ToString();

        }

        private void _btnExport_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn chắc chắn thực hiện hành động này?", "Xác nhận", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {

                Facade.ExportShoes(shoes_id, amount_max - export_amount, index);
                Close();
            }
        }

        private void _btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            if (export_amount < amount_max)
            {
                export_amount++;
                txtNum.Text = export_amount.ToString();
            }
        }
    }
}
