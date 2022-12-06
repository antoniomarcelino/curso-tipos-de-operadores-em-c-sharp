using System;

Console.WriteLine("Digite uma letra");
string letra = Console.ReadLine();

switch(letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
	    Console.WriteLine("Vogal");
	    break;
    default:
        Console.WriteLine("Não é uma vogal.");
        break;
}

/*
if(letra == "a" ||
    letra == "e" ||
    letra == "i" ||
    letra == "o" ||
    letra == "u")
{
    Console.WriteLine("Vogal");
}
else
{
    Console.WriteLine("Não é uma vogal.");
}
*/ 
    

/* if(letra == "a")
{
    Console.WriteLine("Vogal");
}
else if(letra == "e")
{
    Console.WriteLine("Vogal");
}
else if(letra == "i")
{
    Console.WriteLine("Vogal");
}
else if(letra == "o")
{
    Console.WriteLine("Vogal");
}
else if(letra == "u")
{
    Console.WriteLine("Vogal");
}
else
{
    Console.WriteLine("Não é uma vogal.");
} */


/*
int quantidadeEmEstoque = 10;
int quantidadeCompra = 4;
bool possivelVenda = quantidadeEmEstoque > 0 && quantidadeEmEstoque >= quantidadeCompra;
Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
Console.WriteLine($"É possível realizar a venda? {possivelVenda}");
if(quantidadeCompra == 0)
{
	Console.WriteLine("Quantidade de compra insuficiente.");
}
else if(possivelVenda)
{
	Console.WriteLine("Venda realizada.");
}
else
{
	Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
}
*/


