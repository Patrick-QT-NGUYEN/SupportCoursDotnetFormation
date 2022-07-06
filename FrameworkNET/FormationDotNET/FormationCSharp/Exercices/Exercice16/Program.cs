
            #region Déclaration des variables
            double revenus = 0;
            int nbAdulte = 0;
            int nbEnfants = 0;
            double nbParts;            
            double revenuImposable = 0;
            double montantImpot = 0;
            #endregion

            #region Récupération des saisies Utilisateur
            Console.WriteLine("--- Quelle sera le montant des mes impôts ? --- \n");

            Console.Write("Entrez le montant net imposable du foyer (en Euros): ");
            revenus = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez le nombre d'adulte du foyer : ");
            nbAdulte = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entrez le nombre d'enfants du foyer : ");
            nbEnfants = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");
            #endregion

            #region Calcul du nombre de parts du foyer            
            if (nbEnfants <= 2)
                nbParts = nbAdulte + nbEnfants * 0.5;
            else
                nbParts = nbAdulte + nbEnfants - 1;
            #endregion

            #region Sugar Syntaxe (ternaire) pour le Calcul du nombre de parts
            //nbParts = nbEnfants <= 2 ? nbAdulte + nbEnfants * 0.5 : nbAdulte + nbEnfants - 1;
            #endregion

            #region Calcul du montant de l'impôt  
            // Calcul du Revenu imposable
            revenuImposable = revenus / nbParts;

            // Calcul de l'impôt par la structure conditionnelle
            if (revenuImposable >= 10065 && revenuImposable <= 25659)
                montantImpot = Math.Round((revenuImposable - 10064) * 0.11, 0);
            else if (revenuImposable >= 25660 && revenuImposable <= 73369)
                montantImpot = Math.Round((revenuImposable - 25659) * 0.3 + 1715, 34, 0);
            else if (revenuImposable >= 73370 && revenuImposable <= 157806)
                montantImpot = Math.Round((revenuImposable - 73369) * 0.41 + 1715.34 + 14312.7, 0);
            else if (revenuImposable >= 157807)
                montantImpot = Math.Round((revenuImposable - 157806) * 0.45 + 1715.34 + 14312.7 + 34618.8, 0);

            // Calcul de l'impôt
            montantImpot = montantImpot * nbParts;
            #endregion

            #region Affichage des résultats
            Console.WriteLine("Vous allez payer " + montantImpot + " Euros\n");
            #endregion


            Console.WriteLine("Appuyez sur une touche pour fermer le programme...");
            Console.Read();