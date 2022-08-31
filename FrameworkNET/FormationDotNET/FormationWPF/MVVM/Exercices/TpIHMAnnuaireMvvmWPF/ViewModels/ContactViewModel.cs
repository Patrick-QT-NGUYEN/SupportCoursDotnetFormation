using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TpListContactClassAdoNET.Classes;

namespace TpIHMAnnuaireMvvmWPF.ViewModels
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool readOnly;
        private string buttonName;
        private string formName;

        private Contact contact;

        private Contact selectedContact;

        private ObservableCollection<Contact> _contacts;
        public ObservableCollection<Contact> Contacts 
        { 
            get=> _contacts;
            set
            {
                _contacts = value;
                RaisePropertyChanged("Contacts");
            }
        }

        public ICommand ConfirmCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand DetailsCommand { get; set; }


        public Contact Contact
        {
            get => contact;
            set
            {
                contact = value;
                RaisePropertyChanged("Firstname");
                RaisePropertyChanged("Lastname");
                RaisePropertyChanged("DateOfBirth");
                RaisePropertyChanged("PhoneNumber");
                RaisePropertyChanged("Email");
                RaisePropertyChanged("ContactAddress");
            }
        }
        public string Firstname
        {
            set
            {
                Contact.Firstname = value;
                RaisePropertyChanged("Firstname");
            }
            get => Contact.Firstname;
        }

        public string Lastname
        {
            set
            {
                Contact.Lastname = value;
                RaisePropertyChanged("Lastname");
            }
            get => Contact.Lastname;
        }

        public string PhoneNumber
        {
            set
            {
                Contact.PhoneNumber = value;
                RaisePropertyChanged("PhoneNumber");
            }
            get => Contact.PhoneNumber;
        }

        public DateTime DateOfBirth
        {
            set
            {
                Contact.DateOfBirth = value;
                RaisePropertyChanged("DateOfBirth");
            }
            get => Contact.DateOfBirth;
        }

        public string Email
        {
            set
            {
                Contact.Email = value;
                RaisePropertyChanged("Email");
            }
            get => Contact.Email;
        }

        public Address ContactAddress
        {
            set
            {
                Contact.ContactAddress = value;
                RaisePropertyChanged("ContactAddress");
            }
            get => Contact.ContactAddress;
        }
        public string FormName
        {
            set
            {
                formName = value;
                RaisePropertyChanged("FormName");
            }
            get => formName;
        }
        public string ButtonName
        {
            set
            {
                buttonName = value;
                RaisePropertyChanged("ButtonName");
            }
            get => buttonName;
        }

        public Contact SelectedContact { get => selectedContact; set => selectedContact = value; }

        public ContactViewModel()
        {
            Contact = new Contact();
            Contact.DateOfBirth = DateTime.Now;
            Contacts = Contact.GetAll();
            readOnly = false;
            FormName = "Add Contact";
            ButtonName = "Ajouter";
            ConfirmCommand = new RelayCommand(ConfirmContact);
            EditCommand = new RelayCommand(EditCommandAction);
            DeleteCommand = new RelayCommand(DeleteCommandAction);
            DetailsCommand = new RelayCommand(DetailsCommandAction);
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void ResetForm()
        {
            Contact = new Contact();
            DateOfBirth = DateTime.Now;
            ButtonName = "Ajouter";
            FormName = "Add Contact";
        }

        private void ConfirmContact()
        {
            if (Contact.Id == 0 && !readOnly)
            {

                Contact.Id = Contact.Add();
                if (Contact.Id > 0)
                {

                    MessageBox.Show("Contact ajouté avec l'id " + Contact.Id);

                    Contacts.Add(Contact);

                    Contact = new Contact();
                }
                else
                {
                    MessageBox.Show("Erreur ajout contact");
                }
            }
            else if (readOnly)
            {
                readOnly = false;
                ResetForm();
            }
            else
            {
                if (Contact.Update())
                {

                    MessageBox.Show("Contact modifié ");

                    ResetForm();
                }
                else
                {
                    MessageBox.Show("Erreur modification contact");
                }
            }
        }

        private void EditCommandAction()
        {
            if (SelectedContact != null)
            {
                Contact = SelectedContact;
                FormName = "Update Contact";
                ButtonName = "Modifier";
            }
            else
            {
                MessageBox.Show("Veuillez séléctionner un contact au préalable !", "Erreur !", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void DetailsCommandAction()
        {
            if (SelectedContact != null)
            {
                Contact = SelectedContact;
                readOnly = true;
                ButtonName = "Fermer";
                FormName = $"Contact N°{Contact.Id}";
            }
            else
            {
                MessageBox.Show("Veuillez séléctionner un contact au préalable !", "Erreur !", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void DeleteCommandAction()
        {
            if (SelectedContact != null)
            {
                MessageBoxResult result = MessageBox.Show($"Etes-vous sur de vouloir supprimer le contact :\n{SelectedContact.ToString()}\n", "Demande de suppression", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);

                if (result == MessageBoxResult.Yes)
                {
                    SelectedContact.Delete();

                    Contacts.Remove(SelectedContact);
                }
            }
            else
            {
                MessageBox.Show("Veuillez séléctionner un contact au préalable !", "Erreur !", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
