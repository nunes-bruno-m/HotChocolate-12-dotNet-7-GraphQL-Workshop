using Mykel.GraphQL.Common;
using Mykel.GraphQL.Data;

namespace Mykel.GraphQL.Attendees
{
    public class AttendeePayloadBase : Payload
    {
        public AttendeePayloadBase(Attendee attendee)
        {
            Attendee = attendee;
        }

        public AttendeePayloadBase(IReadOnlyList<UserError> errors)
            : base(errors)
        {
        }

        public Attendee? Attendee { get; }
    }
}