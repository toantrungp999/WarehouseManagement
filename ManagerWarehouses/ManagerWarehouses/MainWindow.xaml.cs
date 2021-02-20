using ManagerWarehouses.GUI;
using System.Windows;

namespace ManagerWarehouses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Global.MainWindow = this;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Global.UCPersonalInformation = new UCPersonalInformation();
            Global.MainWindow._PanelBody.Children.Add(Global.UCPersonalInformation);
        }

        private void _btnInformation_Click(object sender, RoutedEventArgs e)
        {
            Global.MainWindow._PanelBody.Children.Clear();
            Global.MainWindow._PanelBody.Children.Add(Global.UCPersonalInformation);
        }

        private void _btnExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void _btnManagerTypeShoes_Click(object sender, RoutedEventArgs e)
        {
            if (Global.UCManagerType == null)
                Global.UCManagerType = new UCManagerType();
            Global.MainWindow._PanelBody.Children.Clear();
            Global.MainWindow._PanelBody.Children.Add(Global.UCManagerType);
        }

        private void _btnManagerModelShoes_Click(object sender, RoutedEventArgs e)
        {
            if (Global.UCManagerModel == null)
                Global.UCManagerModel = new UCManagerModel();
            Global.MainWindow._PanelBody.Children.Clear();
            Global.MainWindow._PanelBody.Children.Add(Global.UCManagerModel);
        }

        private void _btnManagerCompany_Click(object sender, RoutedEventArgs e)
        {
            if (Global.UCManageCompany == null)
                Global.UCManageCompany = new UCManagerCompany();
            Global.MainWindow._PanelBody.Children.Clear();
            Global.MainWindow._PanelBody.Children.Add(Global.UCManageCompany);
        }

        private void _btnManagerImAndEx_Click(object sender, RoutedEventArgs e)
        {
            if (Global.UCManagerImAndEx == null)
                Global.UCManagerImAndEx = new UCManagerImAndEx();
            Global.MainWindow._PanelBody.Children.Clear();
            Global.MainWindow._PanelBody.Children.Add(Global.UCManagerImAndEx);
        }
    }
}
