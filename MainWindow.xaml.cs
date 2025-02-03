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
using System.Windows.Shapes;
using iNKORE.UI.WPF.Modern.Controls;
using Page = iNKORE.UI.WPF.Modern.Controls.Page;

namespace HVKLv2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public Pages.HomePage Page_Home = new Pages.HomePage();

        private void Nav_Root_SelectionChanged(Nav_Root sender, NavigationViewSelectionChangedEventArgs args)
        {
            var item = sender.SelectedItem;
            Page? page = null;

            if (item == NavigationViewItem_Home)
            {
                page = Page_Home;
            }


            if (page != null)
            {
                Nav_Root.Header = page.Title;
                Frame_Main.Navigate(page);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Nav_Root.SelectedItem = NavigationViewItem_Home;
        }
    }
}
