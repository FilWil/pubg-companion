using MediatR;
using MediatR.Framework.Api;
using Microsoft.AspNetCore.Mvc;
using PubgStats.AppCore.Features.Matches.Queries.GetRecentMatchesForPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PubgStats.AppCore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MatchesController : ApiControllerWithMediator
    {
        [HttpGet]
        public async Task<IActionResult> GetRecentMatchesForPlayer()
        {
            var result = await Mediator.Send(new GetRecentMatchesForPlayer());

            if (result.Success)
                return Ok(result.Item);
            else
                return NotFound(result.Message);
        }
    }
}
