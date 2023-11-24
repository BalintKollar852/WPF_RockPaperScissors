using System;
using System.Collections.Generic;
using System.IO;
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
    public partial class GamePage : Page
    {
        public static int DrawNumber = 0;
        public static int WonNumber = 0;
        public static int LossNumber = 0;
        private int round = 1;
        private int maxround;
        private List<String> GameType1Shapes = new List<String> { "kő", "papír", "olló" };
        private List<String> GameType2Shapes = new List<String> { "kő", "papír", "olló", "gyík", "Spock" };
        public GamePage()
        {
            InitializeComponent();
            LabelPlayerName.Content = MainWindow.Name + " eddigi eredményei:";
            List<Jatekosok> jatekosoklist = new List<Jatekosok>();
            string fullPath = $"jatekosok.txt";
            foreach (string sor in File.ReadAllLines(@"jatekosok.txt"))
            {
                jatekosoklist.Add(new Jatekosok(sor));
            }
            if (Convert.ToInt32(jatekosoklist.Where(a => a.Nev == MainWindow.Name).Count()) >= 1)
            {
                PlayerPreviousResults.Text = $" Nyert játékok száma: {jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.WonGame).SingleOrDefault()}\n Vesztett játékok száma: {jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.LostGame).SingleOrDefault()}\n Döntetlen játékok száma: {jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.DrawGame).SingleOrDefault()}";
            }
            if (MainWindow.GameType == 1)
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
            ResultsButton.IsEnabled = false;
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
                
                if (round <= maxround)
                {
                    string results = "";
                    string selectedshape = ListBoxShapes.SelectedItem.ToString();
                    int randomindex;
                    string randomshape = "";
                    Random rnd = new Random();

                    // Sima kő papír olló
                    if (MainWindow.GameType == 1)
                    {
                        randomindex = rnd.Next(0, GameType1Shapes.Count());
                        randomshape = GameType1Shapes[randomindex]; 
                        if (selectedshape == randomshape)
                        {
                            results = "Döntetlen";
                        }
                        else if ((selectedshape == "kő" && randomshape == "olló") ||
                                 (selectedshape == "papír" && randomshape == "kő") ||
                                 (selectedshape == "olló" && randomshape == "papír"))
                        {
                            results = "Győzelem";
                        }
                        else
                        {
                            results = "Veszteség";
                        }
                        string uribegin2 = "C:\\Users\\nemeth.csaba_csany-z\\Documents\\GitHub\\WPF_RockPaperScissors\\RockPaperScissors\\bin\\Debug\\Images\\";
                        selectedImage.Source = new BitmapImage(new Uri($"{uribegin2}{selectedshape}.png"));
                        randomImage.Source = new BitmapImage(new Uri($"{uribegin2}{randomshape}.png"));
                        vsImage.Source = new BitmapImage(new Uri($"{uribegin2}vs.png"));

                    }

                    // Kiegészített kő papír olló
                    if (MainWindow.GameType == 2)
                    {
                        randomindex = rnd.Next(0, GameType2Shapes.Count());
                        randomshape = GameType2Shapes[randomindex]; 
                        if (selectedshape == randomshape)
                        {
                            results = "Döntetlen";
                        }
                        else if (selectedshape == "kő")
                        {
                            if (randomshape == "olló" || randomshape == "gyík")
                            {
                                results = $"Győzelem";
                            }
                            else
                            {
                                results = "Veszteség";
                            }
                        }
                        else if (selectedshape == "papír")
                        {
                            if (randomshape == "kő" || randomshape == "Spock")
                            {
                                results = $"Győzelem";
                            }
                            else
                            {
                                results = "Veszteség";
                            }
                        }
                        else if (selectedshape == "olló")
                        {
                            if (randomshape == "papír" || randomshape == "gyík")
                            {
                                results = $"Győzelem";
                            }
                            else
                            {
                                results = "Veszteség";
                            }
                        }
                        else if (selectedshape == "gyík")
                        {
                            if (randomshape == "papír" || randomshape == "Spock")
                            {
                                results = $"Győzelem";
                            }
                            else
                            {
                                results = "Veszteség";
                            }
                        }
                        else if (selectedshape == "Spock")
                        {
                            if (randomshape == "kő" || randomshape == "olló")
                            {
                                results = $"Győzelem";
                            }
                            else
                            {
                                results = "Veszteség";
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(ResultsBlock.Text))
                    {
                        ResultsBlock.Text += "\n";
                    }
                    selectedImage.Source = new BitmapImage(new Uri($"{selectedshape}.png", UriKind.RelativeOrAbsolute));
                    randomImage.Source = new BitmapImage(new Uri($"{randomshape}.png", UriKind.RelativeOrAbsolute));
                    vsImage.Source = new BitmapImage(new Uri($"vs.png", UriKind.RelativeOrAbsolute));
                    switch (results)
                    {
                        case "Döntetlen":
                            ResultsBlock.Text += $" {round}.kör - {MainWindow.Name}: {selectedshape}, Gép: {randomshape} - Döntetlen.";
                            winLabel.Content = $"A kör eredménye {results}.";
                            DrawNumber++;
                            break;
                        case "Győzelem":
                            ResultsBlock.Text += $" {round}.kör - {MainWindow.Name}: {selectedshape}, Gép: {randomshape} - {MainWindow.Name} nyert.";
                            winLabel.Content = $"A kört nyerte {selectedshape}({MainWindow.Name}).";
                            loseImage.Source = new BitmapImage(new Uri($"lose.png", UriKind.RelativeOrAbsolute));
                            loseImage.Margin = selectedImage.Margin;
                            WonNumber++;
                            break;
                        case "Veszteség":
                            ResultsBlock.Text += $" {round}.kör - {MainWindow.Name}: {selectedshape}, Gép: {randomshape} - Gép nyert.";
                            winLabel.Content = $"A kört nyerte {randomshape} (Gép).";
                            loseImage.Source = new BitmapImage(new Uri($"lose.png", UriKind.RelativeOrAbsolute));
                            loseImage.Margin = randomImage.Margin;
                            LossNumber++;
                            break;
                        default:
                            break;
                    }
                }
                if(round < maxround)
                {
                    round++;
                    OKButton.Content = $"OK {round}/{maxround}";
                }
                else
                {
                    OKButton.IsEnabled = false;
                    ResultsButton.IsEnabled = true;
                }
            }
        }
        private void NavigationToResultPage(object sender, RoutedEventArgs e)
        {
            GameFrame.Content = new ResultPage();
        }
    }
}
