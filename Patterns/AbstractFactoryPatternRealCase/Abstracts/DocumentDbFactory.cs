using Patterns.AbstractFactoryPatternRealCase.Factories;
using Patterns.AbstractFactoryPatternRealCase.Interfaces;
using Patterns.AbstractFactoryPatternRealCase.Products.Enum;

namespace Patterns.AbstractFactoryPatternRealCase.Abstracts;

public abstract class DocumentDbFactory
{
    public static DocumentDbFactory Instance(DocumentDbTypes type)
    {
        switch (type)
        {
            case DocumentDbTypes.Mongo:
                return new MongoDbFactory();
            case DocumentDbTypes.Raven:
                return new RavenDbFactory();
            default: throw new NotImplementedException();
        }
    }

    public abstract IDocumentDbConnection CreateConnection();
    public abstract IDocumentDbOperation CreateOperation();
}