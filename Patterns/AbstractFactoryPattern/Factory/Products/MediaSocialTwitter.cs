using Patterns.AbstractFactoryPattern.Abstract.Produtcts;

namespace Patterns.AbstractFactoryPattern.Factory.Products;

public class MediaSocialTwitter : MediaSocial
{
    public override void Like()
    {
        Console.WriteLine("Post curtido no Twitter");
    }

    public override void Post(string title, string body)
    {
        Console.WriteLine(title);
        Console.WriteLine(body + " Twitter");
    }
}