using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
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
    public partial class MainWindow : Window
    {
        public static string Name;

        public static int GameType;
        public MainWindow()
        {
            InitializeComponent();
            GameButton.IsEnabled = false;
            string fullPath = $"jatekosok.txt";
            foreach (string sor in File.ReadAllLines(@"jatekosok.txt"))
            {
                string[] s = sor.Split(';');
                ComboBoxName.Items.Add(s[0]);
            }
        }
        private void ComboBoxName_TextChanged(object sender, EventArgs e)
        {
          if (ComboBoxName.Text.Length > 0 && Regex.IsMatch(ComboBoxName.Text, @"^[a-zA-Z]+$"))
            {
                GameButton.IsEnabled = true;
            }
            else
            {
                GameButton.IsEnabled = false;
            }
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
            Height = 500;
            MainFrame.Content = new GamePage();
        }
    }
}
