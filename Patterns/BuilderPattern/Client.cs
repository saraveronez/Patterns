using Patterns.BuilderPattern.Builder;
using Patterns.BuilderPattern.Directors;

namespace Patterns.BuilderPattern;

public class Client
{
    public void SocialMediaBuilder()
    {
        var director = new Director(new MediaSocialFacebookBuilder());
    }
}