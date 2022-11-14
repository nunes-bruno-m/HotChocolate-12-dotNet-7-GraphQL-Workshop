using Mykel.GraphQL.Common;
using Mykel.GraphQL.Data;

namespace Mykel.GraphQL.Attendees
{
    public class RegisterAttendeePayload : AttendeePayloadBase
    {
        public RegisterAttendeePayload(Attendee attendee)
            : base(attendee)
        {
        }

        public RegisterAttendeePayload(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }
    }
}