using Patterns.AbstractFactoryPattern.Abstract;
using Patterns.AbstractFactoryPattern.Abstract.Produtcts;
using Patterns.AbstractFactoryPattern.Factory.Products;

namespace Patterns.AbstractFactoryPattern.Factory;

public class MediaSocialFactory : IAbstractFactory
{
    public MediaSocial CreateMediaSocial(MediaSocialEnum mediaSocial)
    {
        switch (mediaSocial)
        {
            case MediaSocialEnum.Twitter: return new MediaSocialTwitter();
            case MediaSocialEnum.Facebook: return new MediaSocialFacebook();
            default: throw new NotImplementedException("Media Social not found");
        }
    }
}