// Escreva um programa que calcule o preço de um produto com desconto de 10% se o valor total da compra for maior ou igual a R$100.
// preço - 10% = preço * 0,9

Console.WriteLine("Digite o valor total da compra:");
double valorTotal = Convert.ToDouble(Console.ReadLine());
double valorFinal = valorTotal * 0.9;

if (valorTotal >= 100)
{   
    Console.WriteLine($"O total a pagar é R${valorFinal}");
}

else
{
    Console.WriteLine($"O total a pagar é R${valorTotal}");
}

Console.ReadLine();