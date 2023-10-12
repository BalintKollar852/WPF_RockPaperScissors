using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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

namespace RockPaperScissors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string Name;

        public static int GameType;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void NavigationToGamePage(object sender, RoutedEventArgs e)
        {
            Name = ComboBoxName.Text.ToString();
            if(GameType1.IsChecked == true)
            {
                GameType = 1;
            }
            if(GameType2.IsChecked == true)
            {
                GameType = 2;
            }
            MainFrame.Content = new GamePage();
        }
    }
}
