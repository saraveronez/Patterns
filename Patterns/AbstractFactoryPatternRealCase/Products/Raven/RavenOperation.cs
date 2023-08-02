using Patterns.AbstractFactoryPatternRealCase.Interfaces;

namespace Patterns.AbstractFactoryPatternRealCase.Products.Raven;

public class RavenOperation : IDocumentDbOperation
{
    public void Add(string document)
    {
        Console.WriteLine($"Documento adicionado ao Raven. {document}");
    }
}