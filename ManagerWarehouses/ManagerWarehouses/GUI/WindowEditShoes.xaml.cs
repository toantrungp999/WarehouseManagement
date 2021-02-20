using System;
using System.Windows;

namespace ManagerWarehouses.GUI
{
    /// <summary>
    /// Interaction logic for EditShoes.xaml
    /// </summary>
    public partial class WindowEditShoes : Window
    {
        private long shoes_id;
        private int amount;
        private int index;
        public WindowEditShoes(long shoes_id, int amount, int index)
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.shoes_id = shoes_id;
            this.amount = amount;
            txtNum.Text = amount.ToString();
            this.index = index;
        }

        private void _btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Bạn chắc chắn thực hiện hành động này?", "Xác nhận", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                Facade.EditShoes(shoes_id, amount, _txtNote.Text, index);
                Close();
            }
        }

        private void _btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            if (amount > 0)
            { 
                amount--;
                txtNum.Text = amount.ToString();
            }
        }
    }
}
