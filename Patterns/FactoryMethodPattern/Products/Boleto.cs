using Patterns.FactoryMethodPattern.Abstract;

namespace Patterns.FactoryMethodPattern.Products;

public class Boleto : Pagamento
{
    public override void Pagar()
    {
        Console.WriteLine("Pagamento realizado via boleto");
    }
}