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
using TpLePendu.Classes;

namespace LePenduWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private LePendu _jeu;

        public MainWindow()
        {
            InitializeComponent();
            Start();
        }

        private void Start()
        {
            _jeu = new LePendu();
            BlocMasque.Text = _jeu.Masque;
            BlocDejaPropose.Text = "";
            BoxUserChar.Text = "";
            BtnValider.IsEnabled = true;
            BoxUserChar.KeyDown += BoxUserChar_KeyDown;
            ImageDisplay.Source = new BitmapImage(new Uri(@"/img/pendu-1_orange.jpg", UriKind.Relative));
        }

        private void BtnRejouer_Click(object sender, RoutedEventArgs e)
        {
            Start();
        }

        private void YouWin()
        {
            MessageBox.Show($"Bravo!!!Vous avez gagné ! \nLe mot mystère était {_jeu.MotAtrouve.ToUpper()}", "Victoire", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            BtnValider.IsEnabled = false;
            BoxUserChar.KeyDown -= BoxUserChar_KeyDown;
        }

        private void YouLoose()
        {
            MessageBox.Show($"Dommage!!!Vous avez perdu ! \nLe mot mystère était {_jeu.MotAtrouve.ToUpper()}", "Défaite", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            BtnValider.IsEnabled = false;
            BoxUserChar.KeyDown -= BoxUserChar_KeyDown;
        }

        private void ChangeImage()
        {
            switch (_jeu.NbEssai)
            {
                case 9:
                    ImageDisplay.Source = new BitmapImage(new Uri(@"/img/pendu-2_orange.jpg", UriKind.Relative));
                    break;
                case 8:
                    ImageDisplay.Source = new BitmapImage(new Uri(@"/img/pendu-3_orange.jpg", UriKind.Relative));
                    break;
                case 7:
                    ImageDisplay.Source = new BitmapImage(new Uri(@"/img/pendu-4_orange.jpg", UriKind.Relative));
                    break;
                case 6:
                    ImageDisplay.Source = new BitmapImage(new Uri(@"/img/pendu-5_orange.jpg", UriKind.Relative));
                    break;
                case 5:
                    ImageDisplay.Source = new BitmapImage(new Uri(@"/img/pendu-6_orange.jpg", UriKind.Relative));
                    break;
                case 4:
                    ImageDisplay.Source = new BitmapImage(new Uri(@"/img/pendu-7_orange.jpg", UriKind.Relative));
                    break;
                case 3:
                    ImageDisplay.Source = new BitmapImage(new Uri(@"/img/pendu-8_orange.jpg", UriKind.Relative));
                    break;
                case 2:
                    ImageDisplay.Source = new BitmapImage(new Uri(@"/img/pendu-9_orange.jpg", UriKind.Relative));
                    break;
                case 1:
                    ImageDisplay.Source = new BitmapImage(new Uri(@"/img/pendu-10_orange.jpg", UriKind.Relative));
                    break;
                case 0:
                    ImageDisplay.Source = new BitmapImage(new Uri(@"/img/pendu-11_orange.jpg", UriKind.Relative));
                    break;
            }
        }

        private void BtnValider_Click(object sender, RoutedEventArgs e)
        {
            if (BoxUserChar.Text != "" && BoxUserChar.Text.Length == 1)
            {
                if (_jeu.TestChar(char.Parse(BoxUserChar.Text)))
                {
                    BlocMasque.Text = _jeu.Masque;
                    if (_jeu.TestWin())
                    {
                        YouWin();
                    }
                }
                else
                {
                    BlocDejaPropose.Text += BlocDejaPropose.Text == "" ?
                        BoxUserChar.Text : "-" + BoxUserChar.Text;
                    ChangeImage();
                    if (_jeu.NbEssai==0)
                    {
                        YouLoose();
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir une lettre", "Erreur de saisie", MessageBoxButton.OK, MessageBoxImage.Stop);
            }

            BoxUserChar.Text = "";
            BoxUserChar.Focus();
        }

        private void BoxUserChar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnValider_Click(sender, e);
            }
        }
    }
}
