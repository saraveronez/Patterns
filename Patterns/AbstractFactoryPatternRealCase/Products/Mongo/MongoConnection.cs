using Patterns.AbstractFactoryPatternRealCase.Interfaces;

namespace Patterns.AbstractFactoryPatternRealCase.Products.Mongo;

public class MongoConnection : IDocumentDbConnection
{
    public void Connect()
    {
        Console.WriteLine("Conexão com MongoDB.");
    }
}