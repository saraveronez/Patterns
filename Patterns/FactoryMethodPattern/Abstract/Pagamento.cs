namespace Patterns.FactoryMethodPattern.Abstract;

public abstract class Pagamento
{
    protected string Descricao { get; }
    protected string Tipo { get; }
    protected decimal Valor { get; }

    public abstract void Pagar();
}