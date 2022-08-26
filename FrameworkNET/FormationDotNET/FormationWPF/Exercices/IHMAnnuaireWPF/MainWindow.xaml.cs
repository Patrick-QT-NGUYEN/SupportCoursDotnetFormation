using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using TpListContactClassAdoNET.Classes;


namespace IHMAnnuaireWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Contact> _contacts;

        public MainWindow()
        {
            InitializeComponent();
            DisplayContact();
        }

        private void DisplayContact()
        {
            _contacts = Contact.GetAll();
            listeViewContacts.ItemsSource = _contacts;
        }

        private void BtnValiderClick(object sender, RoutedEventArgs e)
        {
            Contact tmp = new()
            {
                Firstname = boxPrenom.Text,
                Lastname = boxNom.Text,
                DateOfBirth = (DateTime)DpDateOfBirth.SelectedDate,
                PhoneNumber = boxTelephone.Text,
                Email = boxMail.Text,
                ContactAddress = new(int.Parse(boxNum.Text), boxRoad.Text, int.Parse(boxPostalCode.Text), boxTown.Text, boxCountry.Text)
            };
            tmp.Id = tmp.Add();
            if (tmp.Id > 0)
            {
                DisplayContact();
                ResetForm(sender, e);
            };
        }

        private void EditClick(object sender, RoutedEventArgs e)
        {
            if (listeViewContacts.SelectedItem is Contact c)
            {
                BlockTitleForm.Header = "Update Contact";
                BlockId.Text = c.Id.ToString();
                boxNom.Text = c.Lastname;
                boxPrenom.Text = c.Firstname;
                DpDateOfBirth.SelectedDate = c.DateOfBirth;
                boxTelephone.Text = c.PhoneNumber;
                boxMail.Text = c.Email;
                boxNum.Text = c.ContactAddress.Number.ToString();
                boxRoad.Text = c.ContactAddress.RoadName;
                boxPostalCode.Text = c.ContactAddress.PostalCode.ToString();
                boxTown.Text = c.ContactAddress.Town;
                boxCountry.Text = c.ContactAddress.Country;
                BtnValider.Content = "Modifier";
                BtnValider.Click -= BtnValiderClick;
                BtnValider.Click += UpdateContact;
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un contact au préalable!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void UpdateContact(object sender, RoutedEventArgs e)
        {
            Contact tmp = new()
            {
                Id = int.Parse(BlockId.Text),
                Firstname = boxPrenom.Text,
                Lastname = boxNom.Text,
                DateOfBirth = (DateTime)DpDateOfBirth.SelectedDate,
                PhoneNumber = boxTelephone.Text,
                Email = boxMail.Text,
                ContactAddress = new(int.Parse(boxNum.Text), boxRoad.Text, int.Parse(boxPostalCode.Text), boxTown.Text, boxCountry.Text)
            };

            if (tmp.Update())
            {
                DisplayContact();
                ResetForm(sender,e);
                BtnValider.Click -= UpdateContact;
                BtnValider.Click += BtnValiderClick;
            };

        }
        private void DeleteClick(object sender, RoutedEventArgs e)
        {
            if (listeViewContacts.SelectedItem is Contact c)
            {
                MessageBoxResult question = MessageBox.Show($"Est-vous sur de voiloir supprimer le contact? \n{c.ToString()}", "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (question == MessageBoxResult.Yes)
                {
                    (bool, string) result = c.Delete();
                    if (result.Item1)
                        MessageBox.Show(result.Item2, "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    else
                        MessageBox.Show(result.Item2, "Error", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    DisplayContact();
                }
            }
            else            
                MessageBox.Show("Veuillez selectionner un contact au préalable!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            
        }

        private void ResetForm(object sender, RoutedEventArgs e)
        {
            BlockTitleForm.Header = "Add Contact";
            BlockId.Text = "";
            boxNom.Text = "";
            boxPrenom.Text = "";
            DpDateOfBirth.SelectedDate =DateTime.Now;
            boxTelephone.Text = "";
            boxMail.Text = "";
            boxNum.Text ="N°";
            boxRoad.Text ="road";
            boxPostalCode.Text ="PostalCode";
            boxTown.Text = "City";
            boxCountry.Text = "Country";
            BtnValider.Content = "Ajouter";            
        }

        private void DetailClick(object sender, RoutedEventArgs e)
        {
            if(listeViewContacts.SelectedItem is Contact c)
            {
                BlockTitleForm.Header = "Details Contact";
                BlockId.Text = c.Id.ToString();
                boxNom.Text = c.Lastname;
                boxPrenom.Text = c.Firstname;
                DpDateOfBirth.SelectedDate = c.DateOfBirth;
                boxTelephone.Text = c.PhoneNumber;
                boxMail.Text = c.Email;
                boxNum.Text = c.ContactAddress.Number.ToString();
                boxRoad.Text = c.ContactAddress.RoadName;
                boxPostalCode.Text = c.ContactAddress.PostalCode.ToString();
                boxTown.Text = c.ContactAddress.Town;
                boxCountry.Text = c.ContactAddress.Country;
                BtnValider.Content = "Fermer";
                BtnValider.Click -= BtnValiderClick;
                BtnValider.Click += ResetForm;
            }
            else
            {
                MessageBox.Show("Veuillez selectionner un contact au préalable!", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void SearchClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
