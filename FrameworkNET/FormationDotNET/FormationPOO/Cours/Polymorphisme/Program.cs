using System;
using Polymorphisme.Classes;

namespace Polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Parametrique

            #region Méthode avec double en parametre
            Console.WriteLine(Parametrique.Additionner("3", "7"));

            Console.WriteLine("Le résultat est {0}", Parametrique.Additionner(3, 5));
            #endregion

            #endregion

            #region Stock / Produits
            // Instanciation de l'objet Stock
            Stock stock = new Stock();

            // Instanciation d'un nouveau produit : nom, description, quantité
            Produit p1 = new Produit();
            p1.Nom = "MarioParty";
            p1.Description = "Jeu vidéo pour Nintendo Switch";
            p1.Quantite = 2;

            // Ajout de notre produit p1 au Stock
            stock.AjouterProduit(p1);

            // Instanciation d'un nouveau produit : nom, description, quantité
            Produit p2 = new Produit("Xbox", "Console XBox de Microsoft", 4);

            // Ajout de notre produit p au Stock
            stock.AjouterProduit(p2);

            // Ajout d'un nouveau produit crée à la volée au Stock
            stock.AjouterProduit("PS5", "Console Playstation 5 de Sony", 5);

            // On affiche le nombre de produit en Stock
            Console.WriteLine("Mon tableau contient actuellement {0} produits" + Environment.NewLine, stock.AvoirStockProduit());

            // Ajout d'un nouveau produit créé à la volée au stock
            stock.AjouterProduit("Nintendo Switch", "Console Nintendo Switch", 7);

            // Demande d'affichage du stock
            stock.AfficherStock();

            // Demande de retrait d'un produit
            stock.SupprimerProduit(p1);

            // Demande d'affichage du stock
            stock.AfficherStock();

            stock.SupprimerProduit("PS5");

            // Demande d'affichage du stock
            stock.AfficherStock();
            #endregion

            // Fin du programme
            Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
            Console.Read();
        }
    }
}
