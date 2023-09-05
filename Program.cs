//Crie um programa que, dado o peso e a altura de uma pessoa, determine se ela está abaixo do peso, com peso normal, com sobrepeso ou obesa, de acordo com o índice de massa corporal (IMC).

Console.WriteLine("Calculadora de IMC\n");
Console.WriteLine("Digite seu peso em kilogramas:");
double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite sua altura em metros:");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = Math.Round(peso / (altura * altura), 2);

Console.WriteLine($"Seu IMC é {imc}.");

if (imc < 18.5)
{
    Console.WriteLine("Você está abaixo do peso recomendado.");
}

else if (imc > 18.5 & imc <= 24.9)
{
    Console.WriteLine("Você está com o peso normal.");
}

else if (imc > 24.9 & imc < 29.9)
{
    Console.WriteLine("Você está com sobrepeso.");
}

else if (imc >= 30 & imc <= 34.9)
{
    Console.WriteLine("Você está com obesidade de 1° grau.");
}

Console.ReadLine();