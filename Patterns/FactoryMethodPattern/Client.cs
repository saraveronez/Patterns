

using Patterns.FactoryMethodPattern.Creator;
using Patterns.FactoryMethodPattern.Products;

namespace Patterns.FactoryMethodPattern;

public class Client
{
    public void CriarPagamento()
    {
        // usar DI
        IPagamentoCreator factory = new PagamentoCreator();

        var pay = factory.Create(ProductTypes.Boleto);

        pay.Pagar();
    }
}