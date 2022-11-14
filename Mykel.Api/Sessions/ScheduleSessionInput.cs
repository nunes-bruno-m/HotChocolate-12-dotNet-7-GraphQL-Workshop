using Mykel.GraphQL.Data;

namespace Mykel.GraphQL.Sessions
{
    public record ScheduleSessionInput(
        [property : ID(nameof(Session))]
        int SessionId,
        [property : ID(nameof(Track))]
        int TrackId,
        DateTimeOffset StartTime,
        DateTimeOffset EndTime);
}
