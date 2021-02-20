using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ManagerWarehouses.GUI
{
    /// <summary>
    /// Interaction logic for UserControlManagerImAndEx.xaml
    /// </summary>
    public partial class UCManagerImAndEx : UserControl
    {
        public UCManagerImAndEx()
        {
            InitializeComponent();
            string[] header = { "Nhập kho", "Quản lý nhập kho", "Xuất kho", "Nhật ký chỉnh sửa" };
            int index = 0;
            UserControl[] userControls = new UserControl[] { new UCWarehousingImport(), new UCManagerWarehousingListImport(), new UCManagerExport(), new UCLog() };
            foreach (UserControl uc in userControls)
            {
                TabItem tabItem = new TabItem();
                tabItem.Header = header[index++];
                tabItem.Content = uc;

                tabcontrol.Items.Add(tabItem);
            }
            
        }
    }
}
