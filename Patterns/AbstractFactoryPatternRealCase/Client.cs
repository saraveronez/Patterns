using Patterns.AbstractFactoryPatternRealCase.Abstracts;
using Patterns.AbstractFactoryPatternRealCase.Products.Enum;

namespace Patterns.AbstractFactoryPatternRealCase;

public class Client
{
    public void ConnectDocumentDb()
    {
        var factory = DocumentDbFactory.Instance(DocumentDbTypes.Raven);

        factory.CreateConnection().Connect();
        var operation = factory.CreateOperation();

        operation.Add("Hello World.");
    }
}