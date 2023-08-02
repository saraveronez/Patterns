using Patterns.BuilderPattern.Products;

namespace Patterns.BuilderPattern.Builder;

public class MediaSocialTwitterBuilder : MediaSocialBuilder
{
    public MediaSocialTwitterBuilder()
    {
        _mediaSocial = new MediaSocial("Twitter");
    }

    public override void BuildPost(string title, string content)
    {
        _mediaSocial.Post(title, content);
    }

    public override void BuildLike(string post)
    {
        _mediaSocial.Like(post);
    }
}