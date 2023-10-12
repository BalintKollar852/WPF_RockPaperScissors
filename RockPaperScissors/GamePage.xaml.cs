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

namespace RockPaperScissors
{
    /// <summary>
    /// Interaction logic for GamePage.xaml
    /// </summary>
    public partial class GamePage : Page
    {
        public GamePage()
        {
            InitializeComponent();
            LabelPlayerName.Content = MainWindow.Name + " eddigi eredményei:";
            List<String> GameType1Shapes = new List<String>{"kő", "papír", "olló"};
            List<String> GameType2Shapes = new List<String>{"kő", "papír", "olló", "gyík", "Spock"};
            if(MainWindow.GameType == 1)
            {

                foreach(var item in GameType1Shapes)
                {
                    ListBoxShapes.Items.Add(item);
                }
            }
            if (MainWindow.GameType == 2)
            {
                foreach (var item in GameType2Shapes)
                {
                    ListBoxShapes.Items.Add(item);
                }
            }
        }
        private void ShapeOK(object sender, RoutedEventArgs e)
        {
            string selectedshape = ListBoxShapes.SelectedItem.ToString();
            Random rnd = new Random();

        }
        private void NavigationToResultPage(object sender, RoutedEventArgs e)
        {
            GameFrame.Content = new ResultPage();
        }
    }
}
