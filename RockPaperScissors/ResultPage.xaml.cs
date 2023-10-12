using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
using Path = System.IO.Path;

namespace RockPaperScissors
{
    class Jatekosok
    {
        public string Nev { get; private set; }
        public int WonGame { get; private set; }
        public int LostGame { get; private set; }
        public int DrawGame { get; private set; }
        public Jatekosok(string sor)
        {
            string[] s = sor.Split(';');
            Nev = s[0];
            WonGame = Convert.ToInt32(s[1]);
            LostGame = Convert.ToInt32(s[2]);
            DrawGame = Convert.ToInt32(s[3]);
        }
    }
    public partial class ResultPage : Page
    {
        private string result = "";
        public ResultPage()
        {
            InitializeComponent();
            PlayerLabel.Content = MainWindow.Name + " eddigi eredményei:";
            GameResults.Text = $" {MainWindow.Name} győztes körei: {GamePage.WonNumber}\n Gép győztes körei: {GamePage.LossNumber}\n Döntetlen körök száma: {GamePage.DrawNumber}\n A játék abszolút győztese: ";
            if (GamePage.WonNumber == GamePage.LossNumber)
            {
                result = "Döntetlen";
                GameResults.Text += "Döntetlen";
            }
            else
            {
                if (GamePage.WonNumber > GamePage.LossNumber)
                {
                    result = "Nyert";
                    GameResults.Text += MainWindow.Name;
                }
                else
                {
                    result = "Vesztett";
                    GameResults.Text += "Gép";
                }
            }


            
            
            List<Jatekosok> jatekosoklist = new List<Jatekosok>();
            string fullPath = $"jatekosok.txt";
            foreach (string sor in File.ReadAllLines(@"jatekosok.txt")) {
                jatekosoklist.Add(new Jatekosok(sor));
            }
            if (Convert.ToInt32(jatekosoklist.Where(a => a.Nev == MainWindow.Name).Count()) >= 1)
            {
                List<string> sorok = new List<string>();
                jatekosoklist.Where(j => j.Nev != MainWindow.Name).ToList().ForEach(j => { sorok.Add($"{j.Nev};{j.WonGame};{j.LostGame};{j.DrawGame}"); }); 
                switch (result)
                {
                    case "Döntetlen":
                        sorok.Add($"{MainWindow.Name};{jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.WonGame).SingleOrDefault()};{jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.LostGame).SingleOrDefault()};{jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.DrawGame).SingleOrDefault() + 1}");
                        PlayerPreviousResults.Text = $"Nyert játékok száma: {jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.WonGame).SingleOrDefault()}\n Vesztett játékok száma: {jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.LostGame).SingleOrDefault()}\n Döntetlen játékok száma: {jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.DrawGame).SingleOrDefault() + 1}";
                        break;
                    case "Nyert":
                        sorok.Add($"{MainWindow.Name};{jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.WonGame).SingleOrDefault() + 1};{jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.LostGame).SingleOrDefault()};{jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.DrawGame).SingleOrDefault()}");
                        PlayerPreviousResults.Text = $"Nyert játékok száma: {jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.WonGame).SingleOrDefault() + 1}\n Vesztett játékok száma: {jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.LostGame).SingleOrDefault()}\n Döntetlen játékok száma: {jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.DrawGame).SingleOrDefault()}";
                        break;
                    case "Vesztett":
                        sorok.Add($"{MainWindow.Name};{jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.WonGame).SingleOrDefault()};{jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.LostGame).SingleOrDefault() + 1};{jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.DrawGame).SingleOrDefault()}");
                        PlayerPreviousResults.Text = $"Nyert játékok száma: {jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.WonGame).SingleOrDefault()}\n Vesztett játékok száma: {jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.LostGame).SingleOrDefault() + 1}\n Döntetlen játékok száma: {jatekosoklist.Where(j => j.Nev == MainWindow.Name).Select(j => j.DrawGame).SingleOrDefault()}";
                        break;
                    default:
                        break;
                }
                File.WriteAllLines(fullPath, sorok);

            }
            else
            {
                List<string> sorok = new List<string>();
                jatekosoklist.ForEach(j => { sorok.Add($"{j.Nev};{j.WonGame};{j.LostGame};{j.DrawGame}"); });
                switch (result)
                {
                    case "Döntetlen":
                        sorok.Add($"{MainWindow.Name};{0};{0};{1}");
                        PlayerPreviousResults.Text = $"Nyert játékok száma: 0\n Vesztett játékok száma: 0\n Döntetlen játékok száma: 1";
                        break;
                    case "Nyert":
                        sorok.Add($"{MainWindow.Name};{1};{0};{0}");
                        PlayerPreviousResults.Text = $"Nyert játékok száma: 1\n Vesztett játékok száma: 0\n Döntetlen játékok száma: 0";
                        break;
                    case "Vesztett":
                        sorok.Add($"{MainWindow.Name};{0};{1};{0}");
                        PlayerPreviousResults.Text = $"Nyert játékok száma: 0\n Vesztett játékok száma: 1\n Döntetlen játékok száma: 0";
                        break;
                    default:
                        break;
                }
                File.WriteAllLines(fullPath, sorok);
            }


        }
    }
}
