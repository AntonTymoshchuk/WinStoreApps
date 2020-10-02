using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Windows.Management.Deployment;

namespace WinStoreApps
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Windows.ApplicationModel.Package> packages;

        public MainWindow()
        {
            InitializeComponent();
            PackageManager packageManager = new PackageManager();
            packages = new ObservableCollection<Windows.ApplicationModel.Package>(packageManager.FindPackagesForUser(""));
        }
    }
}
