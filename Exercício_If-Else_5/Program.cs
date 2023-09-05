// Crie um programa que solicite o nome e a idade de um usuário e, com base na idade, apresente mensagens de boas-vindas apropriadas: "Bem-vindo, [Nome]!" para idades até 12 anos, "Olá, [Nome]!" para idades entre 13 e 19 anos, e "Olá, Sr./Sra. [Nome]!" para idades acima de 19 anos.

Console.WriteLine("Digite seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("Digite sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());

if (idade <= 12)
{
    Console.WriteLine($"Bem-vindo, {nome}!");
}

else if (idade > 13 & idade <= 19)
{
    Console.WriteLine($"Olá, {nome}!");
}

else if (idade > 19)
{
    Console.WriteLine($"Olá, Sr./Sra. {nome}!");
}

Console.ReadLine();