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

namespace JBAMangaFlix
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Normal;
            WindowStyle = WindowStyle.SingleBorderWindow;
            Player.Visibility = Visibility.Hidden;
            Player.Source = new Uri("https://google.com");
            Menu.Visibility = Visibility.Visible;
            GridHost.Margin = new Thickness(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            Player.Source = new Uri("https://members.viewpure.com/videos/embed/OyN5zlVxHPg");
            Menu.Visibility = Visibility.Hidden;
            Player.Visibility = Visibility.Visible;
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            GridHost.Margin = new Thickness(7);
        }

        private void Chapter_2_Click(object sender, RoutedEventArgs e)
        {
            Player.Source = new Uri("https://www.youtube.com/embed/cZVzVgZTOos?list=PLQC7LpKc8MbkZklRZ3F3Hy6q65fwtqY6S");
            Menu.Visibility = Visibility.Hidden;
            Player.Visibility = Visibility.Visible;
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            GridHost.Margin = new Thickness(7);
        }

        private void Chapter_3_Click(object sender, RoutedEventArgs e)
        {
            Player.Source = new Uri("https://www.youtube.com/embed/-0cpLmrvFXc?list=PLQC7LpKc8MbkZklRZ3F3Hy6q65fwtqY6S");
            Menu.Visibility = Visibility.Hidden;
            Player.Visibility = Visibility.Visible;
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            GridHost.Margin = new Thickness(7);
        }

        private void Chapter_5_Click(object sender, RoutedEventArgs e)
        {
            Player.Source = new Uri("https://www.youtube.com/embed/sVl3u0_4nYk?list=PLQC7LpKc8MbkZklRZ3F3Hy6q65fwtqY6S");
            Menu.Visibility = Visibility.Hidden;
            Player.Visibility = Visibility.Visible;
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            GridHost.Margin = new Thickness(7);
        }

        private void Chapter_4_Click(object sender, RoutedEventArgs e)
        {
            Player.Source = new Uri("https://www.youtube.com/embed/bbI1JHHCric?list=PLQC7LpKc8MbkZklRZ3F3Hy6q65fwtqY6S");
            Menu.Visibility = Visibility.Hidden;
            Player.Visibility = Visibility.Visible;
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            GridHost.Margin = new Thickness(7);
        }

        private void Chapter_6_Click(object sender, RoutedEventArgs e)
        {
            Player.Source = new Uri("https://www.youtube.com/embed/tDPwqXP1fd8?list=PLQC7LpKc8MbkZklRZ3F3Hy6q65fwtqY6S");
            Menu.Visibility = Visibility.Hidden;
            Player.Visibility = Visibility.Visible;
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            GridHost.Margin = new Thickness(7);
        }

        private void Chapter_7_Click(object sender, RoutedEventArgs e)
        {
            Player.Source = new Uri("https://members.viewpure.com/videos/embed/pC5a14Glwfs");
            Menu.Visibility = Visibility.Hidden;
            Player.Visibility = Visibility.Visible;
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            GridHost.Margin = new Thickness(7);
        }

        private void Chapter_8_Click(object sender, RoutedEventArgs e)
        {
            Player.Source = new Uri("https://www.youtube.com/embed/6gmuzlaVh_s?list=PLQC7LpKc8MbkZklRZ3F3Hy6q65fwtqY6S");
            Menu.Visibility = Visibility.Hidden;
            Player.Visibility = Visibility.Visible;
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            GridHost.Margin = new Thickness(7);
        }

        private void Chapter_9_Click(object sender, RoutedEventArgs e)
        {
            Player.Source = new Uri("https://members.viewpure.com/videos/embed/Dq266BmPqpQ");
            Menu.Visibility = Visibility.Hidden;
            Player.Visibility = Visibility.Visible;
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            GridHost.Margin = new Thickness(7);
        }

        private void Chapter_10_Click(object sender, RoutedEventArgs e)
        {
            Player.Source = new Uri("https://members.viewpure.com/videos/embed/GWzdC6LQN4g");
            Menu.Visibility = Visibility.Hidden;
            Player.Visibility = Visibility.Visible;
            WindowState = WindowState.Maximized;
            WindowStyle = WindowStyle.None;
            GridHost.Margin = new Thickness(7);
        }
    }
}
