decimal valor, preco;
void frase(string frase)
{
    for (int i = 0; i < frase.Length; i++)
    Console.Write(frase[i]);
    Thread.Sleep(75);
{
    
}
}
frase("Quantia de dinheiro: ");
valor = decimal.Parse(Console.ReadLine()!);
frase("Preço do produto: ");
preco = decimal.Parse(Console.ReadLine()!);
if (valor-preco > 0)
{
frase($"Seu troco foi de {valor-preco} da compra.");
}
else
{
    frase($"Você deve {-(valor-preco)} para a compra.");
}
