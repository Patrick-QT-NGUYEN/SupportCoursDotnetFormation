
#region Cours Ado.NET Mode Connecté

using Microsoft.Data.SqlClient;

// Connexion à la base de Données
string connetionString = @"Data Source=(LocalDB)\PRF2022;Integrated Security=True";

// Utilisation du type SQLCONNECTION pour connecter notre programme en C# à la BDD
SqlConnection connection = new SqlConnection(connetionString);

// Executer la requete SQL => on utlise un objet de command
// Préparation de la commande

// 1ere méthode avec ExecuteNonQuery() => Retourne le nb de ligne(s) affectée(s)
//string request = "INSERT INTO UTILISATEUR (nom, prenom, email,telephone) VALUES ('Macron','Emmanuel','president@france.fr','+33 6 41 52 63 63')";
// 2eme Méthode avec ExecuteScalar() => Retourne la valeur du champ recherché
//string request = "INSERT INTO UTILISATEUR (nom, prenom, email,telephone) OUTPUT INSERTED.ID VALUES ('Doe','Janes','janesd@gmail.com','+33 6 14 52 63 98')";
// Test Pour Rock
//string request2 = "INSERT INTO UTILISATEUR (nom, prenom, email,telephone) OUTPUT INSERTED.ID VALUES ('Toto','Titi','toto@gmail.com','+33 6 74 10 25 96')";
//3eme Méthode avec ExecuteReader() => Retourne les valeurs qui répondent aux critères
//string request = "SELECT TOP 5 id, nom, prenom, email,telephone FROM UTILISATEUR";


// Instanciation de l'objet command
//SqlCommand command = new SqlCommand(request, connection);

// Ouverture de la connection
//connection.Open();

// 1ere méthode pour executer notre commande => ExecuteNonQuery : Retourne lenombre de ligne impactée par notre commande ("sans retour")
//int nbLigne = command.ExecuteNonQuery();

// 2eme méthode pour executer notre commande => execute.Scalar() : Retourne la valeur du champs ciblé dans la request
//int id = (int)command.ExecuteScalar();

// 3eme Méthode avec un Reader => Retourner l'emsemble des entités qui répondent aux critères
//SqlDataReader reader = command.ExecuteReader();

// Lire la totalité des elements retournés par la BDD 
//while (reader.Read())
//{
//    Console.WriteLine($" Id : {reader.GetInt32(0)} - Nom : {reader.GetString(1)} Prénom : {reader.GetString(2)} Email : {reader.GetString(3)}  Téléphone : {reader.GetString(4)}");
//}

// Fermeture du reader
//reader.Close();

// Liberer la connection afin de pouvoir executer une autre commande
//command.Dispose();

// Test Pour Rock
//command = new SqlCommand(request2, connection);
//int id2 = (int)command.ExecuteScalar();
//command.Dispose();

// Fermeture le connection à la BDD
//connection.Close();

// Affichage du retour d'information fait par le BDD
//Console.WriteLine(nbLigne>0?$"Il y a eu {nbLigne} ligne ajoutés...":"Erreur lors de l'ajout dans la BDD");
//Console.WriteLine(id>0?$"L'insertion a reussi, l'id de la personne est {id}":"Erreur lors de l'ajout dans la BDD");
//Console.WriteLine(id>0?$"L'insertion a reussi, l'id de la personne est {id2}":"Erreur lors de l'ajout dans la BDD");

int id = 7;


// Récupération des saisies utilisateur
Console.Write("Veuillez saisir le nom de la personne : ");
string nom = Console.ReadLine();
Console.Write("Veuillez saisir le prénom de la personne : ");
string prenom = Console.ReadLine();
Console.Write("Veuillez saisir le mail de la personne : ");
string email = Console.ReadLine();
Console.Write("Veuillez saisir le téléphone de la personne : ");
string telephone = Console.ReadLine();

// Rédaction de la request
//string request = "INSERT INTO UTILISATEUR (nom,prenom,email,telephone) OUTPUT INSERTED.ID VALUES (@Titi, @Toto, @Tata, @Tutu)";
string request = "UPDATE UTILISATEUR SET nom=@Titi ,prenom=@Toto,email=@Tata,telephone=@Tutu WHERE id=@Id";

// Création de notre objet command
SqlCommand command = new SqlCommand(request, connection);

// Ajout des paramètres de la commande
command.Parameters.Add(new SqlParameter("@Titi", nom));
command.Parameters.Add(new SqlParameter("@Toto", prenom));
command.Parameters.Add(new SqlParameter("@Tata", email));
command.Parameters.Add(new SqlParameter("@Tutu", telephone));
command.Parameters.Add(new SqlParameter("@Id", id));

// Execution de la commande
connection.Open();
int NbLigne = (int)command.ExecuteNonQuery();
command.Dispose();
connection.Close();

// Affichage du résultat
//Console.WriteLine(id > 0 ? $"L'insertion a reussi, l'id de la personne est {id}" : "Erreur lors de l'ajout dans la BDD");
Console.WriteLine(NbLigne > 0 ? $"Il y a eu {NbLigne} ligne modifié..." : "Erreur lors de la modification dans la BDD");
#endregion














Console.WriteLine("Appuyez sur ENTER pour fermer la console...");
Console.Read();
