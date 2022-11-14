using Mykel.GraphQL.Data;
using Mykel.GraphQL.DataLoader;

namespace Mykel.GraphQL.Sessions
{
    [ExtendObjectType("Subscription")]
    public class SessionSubscriptions
    {
        [Subscribe]
        [Topic]
        public Task<Session> OnSessionScheduledAsync(
            [EventMessage] int sessionId,
            SessionByIdDataLoader sessionById,
            CancellationToken cancellationToken) =>
            sessionById.LoadAsync(sessionId, cancellationToken);
    }
}
