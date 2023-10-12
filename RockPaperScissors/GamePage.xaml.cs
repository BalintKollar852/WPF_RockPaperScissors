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
        private int round;
        private int maxround;
        private string asd = "GameType1Shapes";
        private List<String> GameType1Shapes = new List<String> { "kő", "papír", "olló" };
        private List<String> GameType2Shapes = new List<String> { "kő", "papír", "olló", "gyík", "Spock" };
        public GamePage()
        {
            InitializeComponent();
            LabelPlayerName.Content = MainWindow.Name + " eddigi eredményei:";
            if(MainWindow.GameType == 1)
            {
                maxround = GameType1Shapes.Count();
                foreach(var item in GameType1Shapes)
                {
                    ListBoxShapes.Items.Add(item);
                }
            }
            if (MainWindow.GameType == 2)
            {
                maxround = GameType2Shapes.Count();
                foreach (var item in GameType2Shapes)
                {
                    ListBoxShapes.Items.Add(item);
                }
            }
            OKButton.IsEnabled = false;
            OKButton.Content = $"OK {round}/{maxround}";
        }
        private void ListBoxShapes_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if (item != null && round != maxround)
            {
                OKButton.IsEnabled = true;
            }
        }
        private void ShapeOK(object sender, RoutedEventArgs e)
        {
            if(ListBoxShapes.SelectedItem != null)
            {
                round++;
                OKButton.Content = $"OK {round}/{maxround}";
                if (round != maxround)
                {
                    string selectedshape = ListBoxShapes.SelectedItem.ToString();
                    LabelPlayerName.Content = selectedshape;
                    int randomindex;
                    string randomshape = "";
                    Random rnd = new Random();
                    if (MainWindow.GameType == 1)
                    {
                        randomindex = rnd.Next(0, GameType1Shapes.Count());
                        randomshape = GameType1Shapes[randomindex];
                    }
                    if (MainWindow.GameType == 2)
                    {
                        randomindex = rnd.Next(0, GameType2Shapes.Count());
                        randomshape = GameType2Shapes[randomindex];
                    }
                }
                else
                {
                    OKButton.IsEnabled = false;
                }
            }

        }
        private void NavigationToResultPage(object sender, RoutedEventArgs e)
        {
            GameFrame.Content = new ResultPage();
        }
    }
}
