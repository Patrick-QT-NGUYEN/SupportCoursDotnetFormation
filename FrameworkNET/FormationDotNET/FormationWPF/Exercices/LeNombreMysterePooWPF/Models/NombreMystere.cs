using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeNombreMysterePooWPF.Models
{
    internal class NombreMystere
    {
        Random aleatoire = new Random();
        int nbMystere;
        int nbCoups;
        bool trouve;


        public NombreMystere()
        {
            Start();
        }

        public int NbMystere { get => nbMystere; set => nbMystere = value; }
        public int NbCoups { get => nbCoups; set => nbCoups = value; }
        public bool Trouve { get => trouve; set => trouve = value; }

        public void Start()
        {
            NbMystere = aleatoire.Next(1, 51);
            NbCoups = 0;
            Trouve = false;
        }

        public string TestNumber(int num)
        {
            string response = "";
            nbCoups++;
            switch (num)
            {
                case int tmp when tmp < NbMystere:
                    response = $"C'est plus que {num}...";
                    break;
                case int tmp when tmp > NbMystere:
                    response = $"C'est moins que {num}...";
                    break;
                case int tmp when tmp == NbMystere:
                    response = $"Bravo!!! Vous avez trouvé en {nbCoups} coups";
                    Trouve = true;
                    break;
            }
            return response;
        }
    }
}
