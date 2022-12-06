using System;

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


