int compteur = 0;


for (int i = 0; i < 100; i++)
{
    compteur++;
    if (compteur ==50)
    {        
        continue;
    }
    Console.WriteLine(compteur);
    if (compteur == 55)
    {
        break;
    }

}






Console.WriteLine("Appuyez sur ENTER pour fermer le programme...");
Console.Read();
