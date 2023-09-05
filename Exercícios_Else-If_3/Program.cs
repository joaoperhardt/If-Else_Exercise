// Faça um programa que determine o maior de três números digitados pelo usuário.

Console.WriteLine("Digite o primeiro número:");
double primeiroNumeroDigitado = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o segundo número:");
double segundoNumeroDigitado = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o terceiro número:");
double terceiroNumeroDigitado = Convert.ToDouble(Console.ReadLine());

if (primeiroNumeroDigitado > segundoNumeroDigitado & primeiroNumeroDigitado > terceiroNumeroDigitado)
{
    Console.WriteLine($"{primeiroNumeroDigitado} é o maior número entre os selecionados.");
}

else if (segundoNumeroDigitado > primeiroNumeroDigitado & segundoNumeroDigitado > terceiroNumeroDigitado)
{
    Console.WriteLine($"{segundoNumeroDigitado} é o maior número entre os selecionados.");
}

else if (terceiroNumeroDigitado > primeiroNumeroDigitado & terceiroNumeroDigitado > segundoNumeroDigitado)
{
    Console.WriteLine($"{terceiroNumeroDigitado} é o maior número entre os selecionados.");
}

else
{
    Console.WriteLine("Não houve um número maior que todos.");
}

Console.ReadLine();