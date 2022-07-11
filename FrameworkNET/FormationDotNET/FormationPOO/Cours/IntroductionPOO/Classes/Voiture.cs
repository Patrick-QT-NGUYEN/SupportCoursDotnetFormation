using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionPOO.Classes
{
    internal class Voiture
    {
        #region Attibuts (Privé)
        private string modele;
        private string couleur;
        private int reservoir;
        private int autonomie;
        private bool demaree;
        private bool roule;
        #endregion

        #region Constructeurs

        public Voiture()
        {
            Demaree = false;
            Roule = false;
        }

        public Voiture(string modele, string couleur, int reservoir, int autonomie) : this()
        {
            Modele = modele;
            Couleur = couleur;
            Reservoir = reservoir;
            Autonomie = autonomie;
        }

        #endregion

        #region Proprietes (Publiques)
        public string Modele 
        { 
            get => modele;
            set 
            {
                if (value.Length >=2)
                {
                    modele = value;
                }
                else
                {
                    Console.WriteLine("Erreur nom modele");
                }
            }  
        }
        public string Couleur { get => couleur; set => couleur = value; }
        public int Reservoir { get => reservoir; set => reservoir = value; }
        public int Autonomie { get => autonomie; set => autonomie = value; }
        public bool Demaree { get => demaree; set => demaree = value; }
        public bool Roule { get => roule; set => roule = value; }
        #endregion

        #region Méthodes (Fonction appartenant à une classe)
        public string Klaxonner()
        {
            return "Pouêt...Pouêt!!!";
        }
        public string Demarrer()
        {
            string response = "";
            if (!Demaree)
            {
                Demaree = true;
                response = "La voiture est démarée...,le moteur tourne!";
            }
            else
                response = "Le moteur tourne déjà!";

            return response;
        }

        public string Arreter()
        {
            string response = "";
            if (Demaree)
            {
                if (!Roule)
                {
                    Demaree = false;
                    response = "Le moteur est arrété";
                }
                else
                    response = "Impossible d'arrété le moteur , la voiture roule!";
            }
            else
                response = "Impossible d'arreter le moteur car il n'est pas démarré!";

            return response;
        }

        public string Rouler()
        {
            string response = "";
            if (Demaree)
            {
                if (Reservoir >= 10)
                {
                    if (!Roule)
                    {
                        roule = true;
                        Reservoir -= 10;
                        response = $"La voiture roule...\n\t Il vous reste {Reservoir} L de carburant";
                    }
                    else
                        response = "Vous êtes déjà en train de rouler!";
                }
                else
                    response = "Low Fuel ! Veuillez mettre du carburant!";
            }
            else
                response = "Veuillez démarrer le véhicule avant de rouler!";

            return response;
        }

        public string Stopper()
        {
            string response = "";

            if (roule)
            {
                roule = false;                
                response = $"La voiture est arrétée...\n\t Il vous reste {Reservoir} L de carburant";
            }
            else
                response = "Vous n'êtes pas en train de rouler!";


            return response;
        }

        public override string ToString()
        {
            return $"La voiture est une {Modele} de couleur {Couleur}.\n" +
                     $"Elle a un réservoir de {Reservoir} litres pour une autonomie de {Autonomie} km.";
        }
        #endregion
    }
}
