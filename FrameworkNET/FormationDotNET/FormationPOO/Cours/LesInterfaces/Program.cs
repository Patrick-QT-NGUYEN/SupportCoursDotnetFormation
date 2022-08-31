// See https://aka.ms/new-console-template for more information


using LesInterfaces.Classes;
using LesInterfaces.Interfaces;


#region Avec Class Person et Address et Address2
//Person p = new Person(new Address2()) { Nom = "Di Persio", Prenom = "Anthony" };

//p.PersonAddress.AddressInformation();
#endregion



#region IVolant
//List<IVolant> volants = new List<IVolant>();

//volants.Add(new Oiseau());
//volants.Add(new Drone());
//volants.Add(new Avion());

//foreach (IVolant v in volants)
//{
//    v.Voler();
//}

IVolant avion = new Avion();
IVolant drone = new Drone();
IVolant oiseau = new Oiseau();

TransportColis t = new TransportColis(oiseau);
t.Transporter();
t.Livrer();
#endregion









Console.WriteLine("Press Enter");
Console.Read();
