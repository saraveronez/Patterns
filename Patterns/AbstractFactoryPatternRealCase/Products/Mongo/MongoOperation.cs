using Patterns.AbstractFactoryPatternRealCase.Interfaces;

namespace Patterns.AbstractFactoryPatternRealCase.Products.Mongo;

public class MongoOperation : IDocumentDbOperation
{
    public void Add(string document)
    {
        Console.WriteLine($"Documento adicionado ao MongoDB. {document}");
    }
}