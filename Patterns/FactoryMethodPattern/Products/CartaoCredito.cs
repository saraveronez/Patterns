using Patterns.FactoryMethodPattern.Abstract;

namespace Patterns.FactoryMethodPattern.Products;

public class CartaoCredito : Pagamento
{
    public override void Pagar()
    {
        Console.WriteLine("Pagamento realizado via cartão de crédito");
    }
}