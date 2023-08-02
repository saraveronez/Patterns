using Patterns.AbstractFactoryPatternRealCase.Interfaces;

namespace Patterns.AbstractFactoryPatternRealCase.Products.Raven;

public class RavenConnection : IDocumentDbConnection
{
    public void Connect()
    {
        Console.WriteLine("Conexão com Raven.");
    }
}