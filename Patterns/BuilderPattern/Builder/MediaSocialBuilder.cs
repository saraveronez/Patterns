

using Patterns.BuilderPattern.Products;

namespace Patterns.BuilderPattern.Builder;

public abstract class MediaSocialBuilder
{
    protected MediaSocial _mediaSocial;

    public MediaSocial MediaSocial => _mediaSocial;

    public abstract void BuildPost(string title, string content);
    public abstract void BuildLike(string post);
}