using Mykel.GraphQL.Data;

namespace Mykel.GraphQL.Tracks
{
    public record RenameTrackInput([property: ID(nameof(Track))] int Id, string Name);
}
