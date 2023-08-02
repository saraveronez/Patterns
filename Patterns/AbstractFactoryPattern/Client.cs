using Patterns.AbstractFactoryPattern.Abstract;
using Patterns.AbstractFactoryPattern.Factory;
using Patterns.AbstractFactoryPattern.Factory.Products;

namespace Patterns.AbstractFactoryPattern;

public class Client
{
    public void PublishInMedia()
    {
        // trabalhar com injeção de dependencias
        IAbstractFactory factory = new MediaSocialFactory();

        var mediaSocial = factory.CreateMediaSocial(MediaSocialEnum.Twitter);

        mediaSocial.Post(title: "Titulo do post"
            , body: "Minha primeira publicação no");
        mediaSocial.Like();
    }
}