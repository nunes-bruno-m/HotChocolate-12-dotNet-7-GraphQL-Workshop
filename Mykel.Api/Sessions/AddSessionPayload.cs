using Mykel.GraphQL.Common;
using Mykel.GraphQL.Data;

namespace Mykel.GraphQL.Sessions
{
    public class AddSessionPayload : SessionPayloadBase
    {
        public AddSessionPayload(UserError error)
            : base(new[] { error })
        {
        }

        public AddSessionPayload(Session session) : base(session)
        {
        }

        public AddSessionPayload(IReadOnlyList<UserError> errors) : base(errors)
        {
        }
    }
}
