using MediatR;
using MediatR.Framework.OperationResults;
using Pubg.Net;

namespace PubgStats.AppCore.Features.Matches.Queries.GetRecentMatchesForPlayer
{
    public class GetRecentMatchesForPlayer : IRequest<RequestResult<PubgPlayer>>
    {
    }
}
