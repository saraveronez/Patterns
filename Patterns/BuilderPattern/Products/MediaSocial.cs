namespace Patterns.BuilderPattern.Products;

public class MediaSocial
{
    private readonly string _nomeRedeSocial;

    public MediaSocial(string nomeRedeSocial)
    {
        _nomeRedeSocial = nomeRedeSocial;
    }

    public void Post(string title, string content)
    {
        Console.WriteLine($"{title} {content} || postado na rede {_nomeRedeSocial}");
    }

    public void Like(string post)
    {
        Console.WriteLine($"{post} || curtido na rede {_nomeRedeSocial}");
    }
}