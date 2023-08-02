using Patterns.AbstractFactoryPattern.Abstract.Produtcts;

namespace Patterns.AbstractFactoryPattern.Factory.Products;

public class MediaSocialFacebook : MediaSocial
{
    public override void Like()
    {
        Console.WriteLine("Post curtido no Facebook");
    }

    public override void Post(string title, string body)
    {
        Console.WriteLine(title);
        Console.WriteLine(body + " Facebook");
    }
}