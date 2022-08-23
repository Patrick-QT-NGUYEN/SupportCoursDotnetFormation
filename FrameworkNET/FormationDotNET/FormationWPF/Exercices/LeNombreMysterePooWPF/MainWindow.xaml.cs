using LeNombreMysterePooWPF.Models;
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

namespace LeNombreMysterePooWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NombreMystere _jeu;
        public MainWindow()
        {
            InitializeComponent();            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _jeu = new NombreMystere();
            StartGame();
        }
        private void TextBoxEssai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                btnValider_Click(sender, e);
            }
        }

        private void StartGame()
        {            
            _jeu.Start();
            TextBlockInfo1.Text = "";
            TextBlockInfo2.Text = "Veuillez saisir un chiffre/nombre : ";
            TextBoxEssai.Text = "";
            TextBoxEssai.KeyDown += TextBoxEssai_KeyDown;
            btnValider.IsEnabled = true;
            UpdateNbCoups();
        }

        private void UpdateNbCoups()
        {
            TextBlockNbEssai.Text = "Nombre d'essais : " + _jeu.NbCoups;
        }

        private void YouWin()
        {
            TextBlockInfo2.Text = " Les nombre mystere était " + _jeu.NbMystere;
            TextBoxEssai.KeyDown -= TextBoxEssai_KeyDown;
            btnValider.IsEnabled = false;
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            string picked = TextBoxEssai.Text;
            int pickedNum;
            // Vérification de la validité de la saisie utilisateur
            bool isNumeric = int.TryParse(picked, out pickedNum);
            if (isNumeric == false)
            {
                TextBlockInfo1.Text = "Erreur de saisie...";
            }
            else
            {
                TextBlockInfo1.Text = _jeu.TestNumber(pickedNum);                
                UpdateNbCoups();
                if (_jeu.Trouve)
                {
                    YouWin();
                }
            }
            TextBoxEssai.Text = "";            
        }

        private void BtnNouvellePartie_Click(object sender, RoutedEventArgs e)
        {            
            StartGame();
        }
    }
}
