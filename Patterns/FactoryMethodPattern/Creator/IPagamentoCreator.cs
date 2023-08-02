using Patterns.FactoryMethodPattern.Abstract;
using Patterns.FactoryMethodPattern.Products;

namespace Patterns.FactoryMethodPattern.Creator;

public interface IPagamentoCreator
{
    Pagamento Create(ProductTypes type);
}