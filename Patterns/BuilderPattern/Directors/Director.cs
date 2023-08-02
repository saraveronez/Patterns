using Patterns.BuilderPattern.Builder;

namespace Patterns.BuilderPattern.Directors;

public class Director
{
    public Director(MediaSocialBuilder builder)
    {
        builder.BuildPost("", "");
        builder.BuildLike("");
    }
}