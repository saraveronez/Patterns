using Patterns.AbstractFactoryPattern.Abstract.Produtcts;
using Patterns.AbstractFactoryPattern.Factory.Products;

namespace Patterns.AbstractFactoryPattern.Abstract;

public interface IAbstractFactory
{
    MediaSocial CreateMediaSocial(MediaSocialEnum mediaSocial);
}