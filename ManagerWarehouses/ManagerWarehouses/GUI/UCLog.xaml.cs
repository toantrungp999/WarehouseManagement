using System.Windows.Controls;

namespace ManagerWarehouses.GUI
{
    /// <summary>
    /// Interaction logic for UserControlLog.xaml
    /// </summary>
    public partial class UCLog : UserControl
    {
        public UCLog()
        {
            InitializeComponent();
            Global.UCLog = this;
            Facade.ReadLog();
            foreach (var log in Global.ListLog)
            {
                _dataGridListLog.Items.Add(log);
            }
        }
    }
}
