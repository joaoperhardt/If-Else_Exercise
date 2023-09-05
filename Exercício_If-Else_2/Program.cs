//Desenvolva um programa que determine se um ano é bissexto ou não. Um ano é bissexto se for divisível por 4, mas não por 100, a menos que seja divisível por 400.

Console.WriteLine("Digite um ano para ser verificado:");

int ano = Convert.ToInt32(Console.ReadLine());

if (ano % 4 == 0)
{
    if (ano % 100 == 0)
    {
        if (ano % 400 == 0)
        {
            Console.WriteLine($"O ano {ano} é bissexto.");
        }

        else
        {
            Console.WriteLine($"O ano {ano} não é bissexto.");
        }
    }
}

else
{
    Console.WriteLine($"O ano {ano} não é bissexto.");
}

Console.ReadLine();