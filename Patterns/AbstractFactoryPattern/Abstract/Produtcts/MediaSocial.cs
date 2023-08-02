namespace Patterns.AbstractFactoryPattern.Abstract.Produtcts;

//Faz sentido ser uma interface tbm.

public abstract class MediaSocial
{
    public abstract void Post(string title, string body);
    public abstract void Like();
}