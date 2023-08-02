using Patterns.FactoryMethodPattern.Abstract;
using Patterns.FactoryMethodPattern.Products;

namespace Patterns.FactoryMethodPattern.Creator;

public class PagamentoCreator : IPagamentoCreator
{
    public Pagamento Create(ProductTypes type)
    {
        switch (type)
        {
            case ProductTypes.Boleto: return new Boleto();
            case ProductTypes.CartaoCredito: return new CartaoCredito();
            default: throw new NotImplementedException();

        }
    }

}