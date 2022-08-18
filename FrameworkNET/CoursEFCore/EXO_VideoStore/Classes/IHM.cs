﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP05.Datas;

namespace TP05.Classes
{
    internal class IHM
    {
        private ApplicationDbContext _context  = ApplicationDbContext.Instance;

        public void Demarrer()
        {
            int choixMenuPrincipal = -1;

            do
            {
                Console.WriteLine("=== MENU PRINCIPAL ===\n");

                Console.WriteLine("1. Gérer les films");
                Console.WriteLine("2. Gérer les clients");
                Console.WriteLine("3. Gérer les emprunts");
                Console.WriteLine("0. Quitter le programme");

                Console.Write("Votre choix : ");
                choixMenuPrincipal = Convert.ToInt32(Console.ReadLine());

                switch (choixMenuPrincipal)
                {
                    case 0:
                        break;
                    case 1:
                        GestionFilms();
                        break;
                    case 2:
                        GestionClients();
                        break;
                    case 3:
                        GestionEmprunts();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("");

            } while (choixMenuPrincipal != 0);
        }

        private void GestionFilms()
        {
            int choixGestionFilms = -1;

            do
            {
                Console.WriteLine("=== Gestion des films ===\n");

                Console.WriteLine("1. Voir les films");
                Console.WriteLine("2. Ajouter un film");
                Console.WriteLine("3. Modifier un film");
                Console.WriteLine("4. Supprimer un film");
                Console.WriteLine("0. Retour au menu principal");

                Console.Write("Votre choix : ");
                choixGestionFilms = Convert.ToInt32(Console.ReadLine());

                switch (choixGestionFilms)
                {
                    case 0:
                        break;
                    case 1:
                        VoirFilms();
                        break;
                    case 2:
                        AjouterFilm();
                        break;
                    case 3:
                        ModifierFilm();
                        break;
                    case 4:
                        SupprimerFilm();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("");

            } while (choixGestionFilms != 0);
        }

        private void GestionClients()
        {
            int choixGestionClients = -1;

            do
            {
                Console.WriteLine("=== Gestion des clients ===\n");

                Console.WriteLine("1. Voir les clients");
                Console.WriteLine("2. Ajouter un client");
                Console.WriteLine("3. Modifier un client");
                Console.WriteLine("4. Supprimer un client");
                Console.WriteLine("0. Retour au menu principal");

                Console.Write("Votre choix : ");
                choixGestionClients = Convert.ToInt32(Console.ReadLine());

                switch (choixGestionClients)
                {
                    case 0:
                        break;
                    case 1:
                        VoirClients();
                        break;
                    case 2:
                        AjouterClient();
                        break;
                    case 3:
                        ModifierClient();
                        break;
                    case 4:
                        SupprimerClient();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("");

            } while (choixGestionClients != 0);
        }

        private void GestionEmprunts()
        {
            int choixGestionEmprunts = -1;

            do
            {
                Console.WriteLine("=== Gestion des emprunts ===\n");

                Console.WriteLine("1. Voir les emprunts");
                Console.WriteLine("2. Réaliser un emprunt");
                Console.WriteLine("3. Réaliser un retour");
                Console.WriteLine("0. Retour au menu principal");

                Console.Write("Votre choix : ");
                choixGestionEmprunts = Convert.ToInt32(Console.ReadLine());

                switch (choixGestionEmprunts)
                {
                    case 0:
                        break;
                    case 1:
                        VoirEmprunts();
                        break;
                    case 2:
                        RealiserEmprunt();
                        break;
                    case 3:
                        RealiserRetour();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("");

            } while (choixGestionEmprunts != 0);
        }

        private void VoirEmprunts()
        {
            Console.WriteLine("=== Liste des emprunts ===\n");

            var emprunts = _context.Emprunts
                .Include(emprunt => emprunt.Client)
                .Include(emprunt => emprunt.Films)
                .ToList();

            // Plusieurs syntaxes existent pour une boucle de type forEach()
            //
            // foreach (var emprunt in emprunts) { }
            // OU

            emprunts.ForEach(emprunt =>
            {
                // DateTime.ToLongDateString() équivaut à DateTime.ToString("D")
                Console.WriteLine($"Emprunt du {emprunt.EmprunteLe.ToLongDateString()} par {emprunt.Client.Prenom} {emprunt.Client.Nom} {((DateTime.Now - emprunt.EmprunteLe).Days > 14 ? "EN RETARD" : "")}");
                emprunt.Films.ForEach(film =>
                {
                    Console.WriteLine($"\t{film.Nom} par {film.Realisateur}");
                });
            });
        }

        private void RealiserEmprunt()
        {
            Console.WriteLine("=== Réaliser un emprunt ===\n");

            Console.Write("ID du client empruntant : ");
            int clientId = Convert.ToInt32(Console.ReadLine());

            // Si on voulait trouver le client par son nom de famille, on aurait pu procéder de la sorte 
            //
            //Console.Write("Nom du client empruntant : ");
            //string clientLastName = Console.ReadLine();
            //Client clientTrouveWLastName = _context.Clients.FirstOrDefault(client => client.Nom.StartsWith(clientLastName));

            Client clientTrouve = _context.Clients.FirstOrDefault(client => client.Id == clientId);

            if (clientTrouve == null) Console.WriteLine("Aucun client trouvé avec cet ID !");
            else
            {
                var empruntsParClient = _context.Emprunts.Include(emprunt => emprunt.Client).Include(emprunt => emprunt.Films).Where(emprunt => emprunt.Client == clientTrouve);

                if (empruntsParClient.ToList().Find(emprunt => (DateTime.Now - emprunt.EmprunteLe).Days > 14) != null) Console.WriteLine("Ce client a déjà des emprunts en retard ! Il ne peut plus emprunter !");
                else
                {
                    int filmId = -1;
                    List<Film> nouvelleListe = new List<Film>();
                    do
                    {
                        Console.Write("ID du film à emprunter (-1 pour stopper l'ajout de films): ");
                        filmId = Convert.ToInt32(Console.ReadLine());

                        Film filmTrouve = _context.Films.FirstOrDefault(film => film.Id == filmId);

                        if (filmTrouve == null) Console.WriteLine("Aucun film trouvé avec cet ID !");
                        else if (_context.Emprunts.FirstOrDefault(emprunt => emprunt.Films.Contains(filmTrouve)) != null || nouvelleListe.Contains(filmTrouve)) Console.WriteLine("Ce film a déjà été emprunté !");
                        else
                        {
                            nouvelleListe.Add(filmTrouve);
                            Console.WriteLine("Film ajouté à l'emprunt en cours !");
                        }

                    } while (filmId != -1);

                    if (nouvelleListe.Count == 0) Console.WriteLine("Liste de film vide ! Abandon de l'opération...");
                    else
                    {
                        Emprunt nouvelEmprunt = new Emprunt()
                        {
                            EmprunteLe = DateTime.Now,
                            Client = clientTrouve,
                            Films = nouvelleListe
                        };

                        _context.Emprunts.Add(nouvelEmprunt);

                        if (_context.SaveChanges() > 0)
                        {
                            Console.WriteLine($"L'emprunt a été ajouté avec succès ! Date de retour avant frais de retard : {nouvelEmprunt.EmprunteLe.AddDays(14).ToLongDateString()}");
                        }
                        else
                        {
                            Console.WriteLine("Ajout de l'emprunt impossible ! Abandon de l'opération...");
                        }
                    }
                }

            }
        }

        private void RealiserRetour()
        {
            Console.WriteLine("=== Réaliser un retour ===\n");
            int filmId = -1;

            do
            {
                Console.Write("ID du film retourné (-1 pour stopper les retours) : ");
                filmId = Convert.ToInt32(Console.ReadLine());

                Film filmTrouve = _context.Films.FirstOrDefault(film => film.Id == filmId);

                if (filmTrouve == null) Console.WriteLine("Aucun film trouvé avec cet ID !");
                else
                {
                    Emprunt empruntConcerne = _context.Emprunts.Include(emprunt => emprunt.Client).Include(emprunt => emprunt.Films).FirstOrDefault(emprunt => emprunt.Films.Contains(filmTrouve));
                    if (empruntConcerne == null) Console.WriteLine("Ce film n'a pas encore été emprunté !");
                    else
                    {
                        empruntConcerne.Films.Remove(filmTrouve);
                        if (empruntConcerne.Films.Count == 0)
                        {
                            _context.Emprunts.Remove(empruntConcerne);
                            if (_context.SaveChanges() > 0)
                            {
                                Console.WriteLine("L'emprunt ne possédait pas d'autres films, il a donc été retiré de la liste des emprunts");
                            }
                            else
                            {
                                Console.WriteLine("Suppression de l'emprunt impossible...");
                            }
                        }
                        else
                        {
                            _context.Emprunts.Update(empruntConcerne);
                            if (_context.SaveChanges() > 0)
                            {
                                Console.WriteLine("Film retourné avec succès ! Liste des autres films reliés à cet emprunt :");
                                empruntConcerne.Films.ForEach(film =>
                                {
                                    Console.WriteLine($"\t{film.Nom} par {film.Realisateur}");
                                });
                            }
                            else
                            {
                                Console.WriteLine("Impossible de modifier l'emprunt...");
                            }

                        }
                    }
                }

            } while (filmId != -1);
            
        }


        private void VoirFilms()
        {
            Console.WriteLine("=== Liste des films ===\n");

            var films = _context.Films.ToList();

            films.ForEach(film =>
            {
                Console.WriteLine($"{film.Id}. {film.Nom} par {film.Realisateur} - Score : {film.Score} Prix : {film.Price.ToString("c", CultureInfo.CurrentCulture)}");
                Console.WriteLine($"\t {film.Description.Substring(0, film.Description.Length > 50 ? 50 : film.Description.Length)}{(film.Description.Length > 50 ? "..." : null)}");
            });
        }

        private void AjouterFilm()
        {
            Console.WriteLine("=== Ajouter un film ===\n");

            Console.Write("Nom du film : ");
            string nom = Console.ReadLine();
            Console.Write("Réalisateur du film : ");
            string realisateur = Console.ReadLine();
            Console.Write("Description du film : ");
            string description = Console.ReadLine();
            Console.Write("Score du film : ");
            int score = Convert.ToInt32(Console.ReadLine());
            Console.Write("Prix du film : ");
            decimal prix = Convert.ToDecimal(Console.ReadLine().Replace('.',','));

            Film nouveauFilm = new Film()
            {
                Nom = nom,
                Realisateur = realisateur,
                Description = description,
                Score = score,
                Price = prix
            };

            _context.Films.Add(nouveauFilm);
            if (_context.SaveChanges() > 0)
            {
                Console.WriteLine("Film ajouté avec succès !");
            }
            else
            {
                Console.WriteLine("ERREUR : Ajout du film échoué...");
            }

        }

        private void ModifierFilm()
        {
            Console.WriteLine("=== Modifier un film ===\n");

            Console.Write("ID du film à modifier : ");
            int filmId = Convert.ToInt32(Console.ReadLine());

            Film filmTrouve = _context.Films.FirstOrDefault(film => film.Id == filmId);

            if (filmTrouve == null) Console.WriteLine("Aucun film trouvé avec cet ID !");
            else
            {
                Console.Write("Nouveau nom du film : ");
                string nouveauNom = Console.ReadLine();
                Console.Write("Nouveau réalisateur du film : ");
                string nouveauRealisateur = Console.ReadLine();
                Console.Write("Nouvelle description du film : ");
                string nouvelleDescription = Console.ReadLine();
                Console.Write("Nouveau score du film : ");
                int nouveauScore = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nouveau prix du film : ");
                decimal nouveauPrix = Convert.ToDecimal(Console.ReadLine().Replace('.', ','));

                filmTrouve.Nom = nouveauNom;
                filmTrouve.Realisateur = nouveauRealisateur;
                filmTrouve.Description = nouvelleDescription;
                filmTrouve.Score = nouveauScore;
                filmTrouve.Price = nouveauPrix;

                // _context.Films.Update(filmTrouve); Si on veut être sur que les éléments non traqués soient modifiés 
                if (_context.SaveChanges() > 0)
                {
                    Console.WriteLine("Film modifié avec succès !");
                }
                else
                {
                    Console.WriteLine("ERREUR : Modification du film échouée...");
                }
            }

        }

        private void SupprimerFilm()
        {
            Console.WriteLine("=== Supprimer un film ===\n");

            Console.Write("ID du film à supprimer : ");
            int filmId = Convert.ToInt32(Console.ReadLine());

            Film filmTrouve = _context.Films.FirstOrDefault(film => film.Id == filmId);

            if (filmTrouve == null) Console.WriteLine("Aucun film trouvé avec cet ID !");
            else
            {
                _context.Films.Remove(filmTrouve);

                if (_context.SaveChanges() > 0)
                {
                    Console.WriteLine("Film supprimé avec succès !");
                }
                else
                {
                    Console.WriteLine("ERREUR : Suppression du film échouée...");
                }
            }
        }
        private void VoirClients()
        {
            Console.WriteLine("=== Liste des clients ===\n");

            var clients = _context.Clients.ToList();

            clients.ForEach(client =>
            {
                Console.WriteLine($"{client.Id}. {client.Prenom} {client.Nom} - Téléphone : {client.Telephone}, Email : {client.Email}");
            });
        }

        private void AjouterClient()
        {
            Console.WriteLine("=== Ajouter un client ===\n");

            Console.Write("Prénom du client : ");
            string prenom = Console.ReadLine();
            Console.Write("Nom du client : ");
            string nom = Console.ReadLine();
            Console.Write("Téléphone du client : ");
            string telephone = Console.ReadLine();
            Console.Write("Email du client : ");
            string email = Console.ReadLine();

            Client nouveauClient = new Client()
            {
                Prenom = prenom,
                Nom = nom,
                Telephone = telephone,
                Email = email
            };

            _context.Clients.Add(nouveauClient);
            if (_context.SaveChanges() > 0)
            {
                Console.WriteLine("Client ajouté avec succès !");
            }
            else
            {
                Console.WriteLine("ERREUR : Ajout du client échoué...");
            }

        }

        private void ModifierClient()
        {
            Console.WriteLine("=== Modifier un client ===\n");

            Console.Write("ID du client à modifier : ");
            int clientId = Convert.ToInt32(Console.ReadLine());

            Client clientTrouve = _context.Clients.FirstOrDefault(client => client.Id == clientId);

            if (clientTrouve == null) Console.WriteLine("Aucun client trouvé avec cet ID !");
            else
            {
                Console.Write("Nouveau prénom du client : ");
                string nouveauPrenom = Console.ReadLine();
                Console.Write("Nouveau nom du client : ");
                string nouveauNom = Console.ReadLine();
                Console.Write("Nouveau téléphone du client : ");
                string nouveauTelephone = Console.ReadLine();
                Console.Write("Nouvel email du client : ");
                string nouvelEmail = Console.ReadLine();

                clientTrouve.Prenom = nouveauPrenom;
                clientTrouve.Nom = nouveauNom;
                clientTrouve.Telephone = nouveauTelephone;
                clientTrouve.Email = nouvelEmail;

                _context.Clients.Update(clientTrouve);
                if (_context.SaveChanges() > 0)
                {
                    Console.WriteLine("Client modifié avec succès !");
                }
                else
                {
                    Console.WriteLine("ERREUR : Modification du client échouée...");
                }
            }

        }

        private void SupprimerClient()
        {
            Console.WriteLine("=== Supprimer un client ===\n");

            Console.Write("ID du client à supprimer : ");
            int clientId = Convert.ToInt32(Console.ReadLine());

            Client clientTrouve = _context.Clients.FirstOrDefault(client => client.Id == clientId);

            if (clientTrouve == null) Console.WriteLine("Aucun client trouvé avec cet ID !");
            else
            {
                _context.Clients.Remove(clientTrouve);

                if (_context.SaveChanges() > 0)
                {
                    Console.WriteLine("Client supprimé avec succès !");
                }
                else
                {
                    Console.WriteLine("ERREUR : Suppression du client échouée...");
                }
            }
        }
    }
}
