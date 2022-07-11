using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionPOO.Classes
{
    internal class Voiture
    {
        #region Attributs (Privé)
        private string modele;
        private string couleur;
        private int reservoir;
        private double autonomie;
        private bool demarree;
        private bool arretee;
        private bool roulee;
        private bool stoppee;
        #endregion

        #region Constructeurs
        public Voiture()
        {
            Demarree = false;
            Arretee = false;
            Roulee = false;
            Stoppee = false;
        }

        public Voiture(string modele, string couleur, int reservoir, double autonomie) /*: this()*/
        {
            Modele = modele;
            Couleur = couleur;
            Reservoir = reservoir;
            Autonomie = autonomie;
        }

        #endregion

        #region Propriétés (Publiques)
        public string Modele { get => modele; set => modele = value; }
        public string Couleur { get => couleur; set => couleur = value; }
        public int Reservoir { get => reservoir; set => reservoir = value; }
        public double Autonomie { get => autonomie; set => autonomie = value; }
        public bool Demarree { get => demarree; set => demarree = value; }
        public bool Arretee { get => arretee; set => arretee = value; }
        public bool Roulee { get => roulee; set => roulee = value; }
        public bool Stoppee { get => stoppee; set => stoppee = value; }
        #endregion

        #region Méthodes (Fonction appartenant à une classe)

        public string Demarrer()
        {
            string response = "";
            if (!Demarree)
            {
                Demarree = true;
                response = "La voiture est démarrée..., le moteur tourne!";
            }
            else
            {
                response = "Le moteur tourne déjà!";
            }
            return response;
        }

        public string Arreter()
        {
            string response = "";
            if (!Demarree)
            {
                if (!Roulee)
                {
                    Demarree = false;
                    response = "Le moteur est arrêté...";
                }
                else
                {
                    response = "Impossible d'arrêter le moteur, la voiture roule!";
                }
            }
            else
            {
                response = "Impossible d'arrêter le moteur car il n'est pas démarré";
            }
            return response;
        }

        public string Rouler()
        {
            string response = "";
            if (Demarree)
            {
                if (Reservoir >= 10)
                {
                    if (!Roulee)
                    {
                        roulee = true;
                        reservoir -= 10;
                        autonomie *= 0.85;
                        response = $"La voiture roule...\n\t Il vous reste {reservoir}L de carburant";
                        
                    }
                    else
                    {
                        response = "Vous êtes déjà en train de rouler";
                    }
                }
                else
                {
                    response = "Veuillez mettre du carburant";
                }
            }
            else
            {
                response = "Veuillez démarrer le véhicule avant de rouler";
            }
            return response;
        }

        public string Stopper()
        {
            string response = "";
            if (Roulee)
            {
                Roulee = false;
                response = $"La voiture est arrêtée...\n\t Il vous reste {reservoir}L de carburant";
            }
            else
            {
                response = "vous n'êtes pas en train de rouler!...";
            }
            return response;
        }

        public string Klaxonner()
        {

            return "Pouet Pouet";
        }



        public override string ToString()
        {
            return $"La voiture est une {Modele} de couleur {Couleur}.\n" +
            $"Elle a un réservoir de {Reservoir} litres pour une autonomie de {Autonomie} km.";
        }
        #endregion





    }
}
