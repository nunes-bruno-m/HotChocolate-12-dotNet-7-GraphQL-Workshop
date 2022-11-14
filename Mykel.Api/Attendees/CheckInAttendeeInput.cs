using Mykel.GraphQL.Data;

namespace Mykel.GraphQL.Attendees
{
    public record CheckInAttendeeInput(
        [property: ID(nameof(Session))]
        int SessionId,
        [property: ID(nameof(Attendee))]
        int AttendeeId);
}