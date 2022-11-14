using Mykel.GraphQL.Data;

namespace Mykel.GraphQL.Sessions
{
    public record AddSessionInput(
        string Title,
        string? Abstract,
        [property: ID(nameof(Speaker))]
        IReadOnlyList<int> SpeakerIds);
}
