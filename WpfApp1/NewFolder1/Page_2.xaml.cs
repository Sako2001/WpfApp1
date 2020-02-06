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
using System.Windows.Navigation;

namespace WpfApp1.NewFolder1
{
    /// <summary>
    /// Логика взаимодействия для Page_2.xaml
    /// </summary>
    public partial class Page_2 : Window
    {
        public Page_2()
        {
            InitializeComponent();
        }

        private void ButtonPage1_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this)?.Navigate(new Page_2());
        }

        private void ButtonPage2_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this)?.Navigate(new AuthPage());
        }

        private void ButtonPage3_OnClick(object sender, RoutedEventArgs e)
        {
            NavigationService.GetNavigationService(this)?.Navigate(new Menu());
        }
    }
}
