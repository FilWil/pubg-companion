using MediatR;
using MediatR.Framework.OperationResults;
using Pubg.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PubgStats.AppCore.Features.Matches.Queries.GetRecentMatchesForPlayer
{
    public class GetRecentMatchesForPlayerHandler : IRequestHandler<GetRecentMatchesForPlayer, RequestResult<PubgPlayer>>
    {
        public async Task<RequestResult<PubgPlayer>> Handle(GetRecentMatchesForPlayer request, CancellationToken cancellationToken)
        {
            var pubgPlayerService = new PubgPlayerService();
            var playersRequest = new GetPubgPlayersRequest() { PlayerNames = new string[] { "S_T_A_R" } };

            var players = pubgPlayerService.GetPlayers(PubgPlatform.Steam, playersRequest);

            return players
                .FirstOrDefault()?
                .AsSuccessResult();
        }
    }
}
