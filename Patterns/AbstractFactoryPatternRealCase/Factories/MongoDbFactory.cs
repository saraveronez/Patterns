using Patterns.AbstractFactoryPatternRealCase.Abstracts;
using Patterns.AbstractFactoryPatternRealCase.Interfaces;
using Patterns.AbstractFactoryPatternRealCase.Products.Mongo;

namespace Patterns.AbstractFactoryPatternRealCase.Factories;

public class MongoDbFactory : DocumentDbFactory
{
    public override IDocumentDbConnection CreateConnection()
    {
        return new MongoConnection();
    }

    public override IDocumentDbOperation CreateOperation()
    {
        return new MongoOperation();
    }
}