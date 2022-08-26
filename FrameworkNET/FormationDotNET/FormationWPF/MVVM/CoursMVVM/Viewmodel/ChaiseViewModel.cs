using CommunityToolkit.Mvvm.Input;
using CoursMVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CoursMVVM.Viewmodel
{
    class ChaiseViewModel : INotifyPropertyChanged
    {
        #region Attributes
        private Chaise _chaise;
        #endregion

        #region Properties

        public int NbPieds
        {
            get => _chaise.NbPieds;
            set
            {
                _chaise.NbPieds = value;
                RaisePropertyChanged("NbPieds");
            }
        }

        public string Couleur
        {
            get => _chaise.Couleur;
            set
            {
                _chaise.Couleur = value;
                RaisePropertyChanged("Couleur");
            }
        }

        public string Materiaux
        {
            get => _chaise.Materiaux;
            set
            {
                _chaise.Materiaux = value;
                RaisePropertyChanged("Materiaux");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ValidCommand { get; set; }
        #endregion

        #region Méthodes
        private void RaisePropertyChanged(string PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(PropertyName));
            }
        }
        #endregion

        #region Constructor
        public ChaiseViewModel()
        {
            _chaise = new();
            ValidCommand = new RelayCommand(ActionValidCommand);
        }
        #endregion

        #region Command
        private void ActionValidCommand()
        {
            MessageBox.Show($"NbPieds : {NbPieds} - Couleur : {Couleur} - Matériaux : {Materiaux}");
        }
        #endregion

    }
}
