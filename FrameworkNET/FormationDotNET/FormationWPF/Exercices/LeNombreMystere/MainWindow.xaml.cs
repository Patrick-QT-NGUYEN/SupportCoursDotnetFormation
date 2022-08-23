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

namespace LeNombreMystere
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random aleatoire = new Random();
        int nbMystere;
        int nbCoups;
        bool trouve;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start()
        {
            nbMystere = aleatoire.Next(1, 51);
            nbCoups = 0;
            trouve = false;
            TextBlockLigne1.Text = "";
            TextBlockLigne2.Text = "Veuillez saisir une chiffre / nombre : ";
            UpdateNbCoup();
            TextBoxUserNum.Text = "";
            BtnValider.IsEnabled = true;
            TextBoxUserNum.KeyDown += TextBoxUserNum_KeyDown;
        }

        private void UpdateNbCoup()
        {
            TexBlockNbEssais.Text = $"Nombre d'essais : {nbCoups}";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Start();
        }

        private void BtnValider_Click(object sender, RoutedEventArgs e)
        {
            // Récupération du contenu du champ string
            string Picked = TextBoxUserNum.Text;
            // Déclaration d'une variable de stockage pour un entier
            int nbUser;

            bool isNumeric = int.TryParse(Picked, out nbUser);

            string response = "";
            if (isNumeric == false)
            {
                response = "Erreur de saisie...";
            }
            else
            {
                nbCoups++;
                switch (nbUser)
                {
                    case int tmp when tmp < nbMystere:
                        response = $"C'est plus que {nbUser}...";
                        break;
                    case int tmp when tmp > nbMystere:
                        response = $"C'est moins que {nbUser}...";
                        break;
                    case int tmp when tmp == nbMystere:
                        response = $"Bravo vous avez trouvé en {nbCoups} coups";
                        trouve = true;
                        break;
                }
                TextBoxUserNum.Text = "";
                UpdateNbCoup();
            }

            TextBlockLigne1.Text = response;

            if (trouve)
            {
                TextBlockLigne2.Text = $"Le nombre mystère était {nbMystere}";
                BtnValider.IsEnabled = false;
                TextBoxUserNum.KeyDown -= TextBoxUserNum_KeyDown;
            }
        }

        private void BtnNouvellePartie_Click(object sender, RoutedEventArgs e)
        {
            Start();
        }

        private void TextBoxUserNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnValider_Click(sender,e);
            }
        }
    }
}
