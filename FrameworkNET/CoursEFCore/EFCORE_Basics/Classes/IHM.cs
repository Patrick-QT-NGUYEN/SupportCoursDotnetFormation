using EFCORE_Basics.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCORE_Basics.Classes
{
    internal class IHM
    {
        private ApplicationDbContext _context = new();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\n=== MENU PRINCIPAL ===\n");

                Console.WriteLine("1. Voir les chiens");
                Console.WriteLine("2. Ajouter un chien");
                Console.WriteLine("3. Modifier un chien");
                Console.WriteLine("4. Supprimer un chien");
                Console.WriteLine("0. Quitter le programme");

                Console.Write("Faites votre choix : ");
                int mainChoice = int.Parse(Console.ReadLine());

                switch (mainChoice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;

                    case 1:
                        ListDogs();
                        break;

                    case 2:
                        AddDog();
                        break;

                    case 3:
                        EditDog();
                        break;

                    case 4:
                        DeleteDog();
                        break;

                    default:
                        Console.WriteLine("Votre choix est incorrect !");
                        break;
                }
            }
        }

        private void ListDogs()
        {
            // Pour récupérer toutes nos données dans le BdD, il nous suffit de caster notre DbSet<Dog>
            // en une liste utilisable au niveau de notre code
            List<Dog> dogsList = _context.Dogs.ToList();

            Console.WriteLine("\n--- Liste des chiens ---");

            if (dogsList.Count > 0)
            {
                foreach (var dog in dogsList) Console.WriteLine(dog);
            } else
            {
                Console.WriteLine("Il n'y a pas de chien dans la base de données !");
            }


        }

        private void AddDog()
        {
            Console.WriteLine("\n--- Ajout d'un chien ---");

            Console.Write("Quel est le nom du chien ? ");
            string dogName = Console.ReadLine();

            Console.Write("Quel est la race du chien ? ");
            string dogBreed = Console.ReadLine();

            Console.Write("Quel est l'âge du chien ? ");
            int dogAge = int.Parse(Console.ReadLine());

            Dog newDog = new Dog
            {
                Name = dogName,
                Breed = dogBreed,
                Age = dogAge
            };

            // Pour ajouter l'élément en BdD, il nous suffit d'utiliser la méthode .Add() de notre DbSet
            _context.Dogs.Add(newDog);

            // Pour faire s'effectuer les modifications en RAM dans notre BdD, il faut faire appel 
            // à la méthode .SaveChanges()
            _context.SaveChanges();


        }

        private void EditDog()
        {
            Console.WriteLine("\n--- Edition d'un chien ---");

            Console.Write("Quel ID souhaitez-vous modifier ? ");
            int idToEdit = int.Parse(Console.ReadLine());

            // Pour récupérer une unique valeur dans la BbD, il existe la méthode .FirstOrDefault()
            Dog dogToEdit = _context.Dogs.FirstOrDefault(x => x.Id == idToEdit);
            // Cette version ne prend pas en compte l'absence de l'élément
            // en BdD et va potentiellement causer une erreur 
            Dog dogToEditErr = _context.Dogs.First(x => x.Id == idToEdit);

            // Autre possibilité en commençant par la fin
            Dog dogToEdit2 = _context.Dogs.OrderBy(x => x.Id).LastOrDefault(x => x.Id == idToEdit);

            // Pour lever une exception en cas de multiple élément basé sur le predicat
            Dog dogToEdit3 = _context.Dogs.SingleOrDefault(x => x.Id == idToEdit);

            // Si l'on veut trouver simplement avec l'ID, on peut se servir de la méthode .Find()
            Dog dogToEdit4 = _context.Dogs.Find(idToEdit);

            if (dogToEdit != null)
            {
                Console.Write("Quel est le nouveau nom du chien ? ");
                string dogNewName = Console.ReadLine();

                Console.Write("Quel est la nouvelle race du chien ? ");
                string dogNewBreed = Console.ReadLine();

                Console.Write("Quel est le nouvel âge du chien ? ");
                int dogNewAge = int.Parse(Console.ReadLine());

                // Les modifications de notre objet vont lever des évènements dans EF Core,
                // qui pourront être traités par la suite
                dogToEdit.Name = dogNewName;
                dogToEdit.Breed = dogNewBreed;
                dogToEdit.Age = dogNewAge;

                // La sauvegarde des changements va automatiquement modifier en dur (SQL)
                // les élément modifiés en RAM. Chaque modification dans le programme va être suivie
                // par le mécanisme de tracking d'EF Core
                _context.SaveChanges();
            } else
            {
                Console.WriteLine("Il n'y a pas de chien en base de données avec cet Id !");
            }

        }

        private void DeleteDog()
        {
            Console.WriteLine("\n--- Suppression d'un chien ---");

            Console.Write("Quel ID souhaitez-vous supprimer ? ");
            int idToDelete = int.Parse(Console.ReadLine());

            // Pour récupérer une unique valeur dans la BbD, il existe la méthode .FirstOrDefault()
            Dog dogToDelete = _context.Dogs.Find(idToDelete);

            if (dogToDelete != null)
            {
                // Pour supprimer, il suffit d'utiliser la méthode .Remove() de la classe DbSet<T>
                _context.Dogs.Remove(dogToDelete);

                // La sauvegarde des changements va automatiquement modifier en dur (SQL)
                // les élément modifiés en RAM. Chaque modification dans le programme va être suivie
                // par le mécanisme de tracking d'EF Core
                _context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Il n'y a pas de chien en base de données avec cet Id !");
            }
        }
    }
}
