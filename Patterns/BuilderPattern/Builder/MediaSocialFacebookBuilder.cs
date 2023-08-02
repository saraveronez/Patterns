using Patterns.BuilderPattern.Products;

namespace Patterns.BuilderPattern.Builder;

public class MediaSocialFacebookBuilder : MediaSocialBuilder
{
    public MediaSocialFacebookBuilder()
    {
        _mediaSocial = new MediaSocial("Facebook");
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