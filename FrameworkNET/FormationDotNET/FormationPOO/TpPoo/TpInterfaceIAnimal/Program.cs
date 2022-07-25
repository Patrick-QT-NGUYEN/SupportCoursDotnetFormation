
#region IAnimal
// Déclaration Liste IAnimal
using TpInterfaceIAnimal.Classes;
using TpInterfaceIAnimal.Interfaces;

List<IAnimal> animaux = new List<IAnimal>();

// Instanciation et ajout à la liste
animaux.Add(new Chien());
animaux.Add(new Chat());
animaux.Add(new Lapin());

/* Pour chaque IAnimal contenue dans la liste, 
 * utilisation des méthodes interfacées
 */
foreach (IAnimal a in animaux)
{
    a.Manger();
    a.Crier();
}

#endregion

Console.WriteLine("Appuyez sur ENTER pour fermer la console...");
Console.Read();