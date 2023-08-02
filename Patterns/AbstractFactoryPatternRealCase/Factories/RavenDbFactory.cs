using Patterns.AbstractFactoryPatternRealCase.Abstracts;
using Patterns.AbstractFactoryPatternRealCase.Interfaces;
using Patterns.AbstractFactoryPatternRealCase.Products.Raven;

namespace Patterns.AbstractFactoryPatternRealCase.Factories;

public class RavenDbFactory : DocumentDbFactory
{
    public override IDocumentDbConnection CreateConnection()
    {
        return new RavenConnection();
    }

    public override IDocumentDbOperation CreateOperation()
    {
        return new RavenOperation();
    }
}