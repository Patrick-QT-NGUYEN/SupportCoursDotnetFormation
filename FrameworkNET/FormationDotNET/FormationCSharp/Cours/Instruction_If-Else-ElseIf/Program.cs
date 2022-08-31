// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;


#region Structure Conditionnelle If...Else...
/*
 * If... ELse... Avec une seule instruction
 */

double compteEnBanque = 300.0;


//if (compteEnBanque > 0)
//    Console.WriteLine("Votre compte est créditeur...");
//else
//    Console.WriteLine("Votre compte est négatif... ou nul.");

//// Exemple avec la sugar syntaxe (ternaire)
//Console.WriteLine(compteEnBanque > 0 ? "SugarSyntaxe : Votre compte est créditeur..." : "SugarSyntaxe: Votre compte est négatif... ou nul.");


/*
 * If... ELse... Avec un block instructions
 */

//if (compteEnBanque > 0)
//{
//    Console.WriteLine("Votre compte est créditeur...");
//    Console.WriteLine($"Le solde restant : {compteEnBanque} €uros");
//}
//else
//{
//    Console.WriteLine("Votre compte est débiteur ou nul...");
//    Console.WriteLine($"Le solde restant : {compteEnBanque} €uros");
//}


#endregion

#region Structure Conditionelle If... Else Imbriquées
if (compteEnBanque > 0)
{
    Console.WriteLine("Votre compte est créditeur...");
}
else
{
    if (compteEnBanque < 0)
        Console.WriteLine("Votre compte est débiteur...");
    else
        Console.WriteLine("Votre compte est a 0.");
}
#endregion

#region Exemple de structure conditionnelle If...Else If... Else avec block d'instructions
compteEnBanque = 300;
if (compteEnBanque > 0)
{
    Console.WriteLine("Votre compte est créditeur");
    Console.WriteLine("Le montant du compte est : " + compteEnBanque);
}
else if (compteEnBanque == 0)
{
    Console.WriteLine("Votre solde est nul");
    Console.WriteLine("Le montant du compte est : " + compteEnBanque);
}
else
{
    Console.WriteLine("Votre compte est débiteur");
    Console.WriteLine("Le montant du compte est : " + compteEnBanque);
}
#endregion

#region Exemple de structure conditionnelle If...Else If... Else avec une seule instructions

if (compteEnBanque > 0)
    Console.WriteLine("Votre compte est créditeur");
else if (compteEnBanque == 0)
    Console.WriteLine("Votre solde est nul");
else
    Console.WriteLine("Votre compte est débiteur");

#endregion



Console.WriteLine("Appuyez sur une ENTER pour fermer le programme...");
Console.Read();
