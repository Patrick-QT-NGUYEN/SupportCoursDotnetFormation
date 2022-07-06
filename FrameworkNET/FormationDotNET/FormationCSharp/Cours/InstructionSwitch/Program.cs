
#region Cas d'un switch simple avec string
//string civilite = "M.";
//string civilite = "Mme";
//string civilite = "Mlle";
//switch (civilite)
//{
//    case "M.":
//        Console.WriteLine("Bonjour Monsieur!");
//        break;
//    case "Mme":
//        Console.WriteLine("Bonjour Madame!");
//        break;
//    case "Mlle":
//        Console.WriteLine("Bonjour Mademoiselle!");
//        break;
//    default:
//        Console.WriteLine("Bonjour...");
//        break;
//}
#endregion

#region Cas d'un switch simple avec int
//int choix = 5;
//switch (choix)
//{
//    case 1:
//        Console.WriteLine("Choix 1");
//        break;
//    case 2:
//        Console.WriteLine("Choix 2");
//        break;
//    case 3:
//        Console.WriteLine("Choix 3");
//        break;
//    default:
//        Console.WriteLine("Choix defaut");
//        break;
//}
#endregion

#region Cas d'un switch simple avec int avec condition
int age = 7;

switch (age)
{
    //case compte > 0:
    //    break;
    case int tmp when tmp > 0 && tmp <13:
        Console.WriteLine("Vous êtes un enfant...");
        break;
    case int tmp when tmp > 12 && tmp < 18:
        Console.WriteLine("Vous êtes un ado...");
        break;
    default:
        Console.WriteLine("Vous êtes un adulte");
        break;
}
#endregion

Console.WriteLine("Appuyez sur Enter pour fermer le programme...");
Console.Read();