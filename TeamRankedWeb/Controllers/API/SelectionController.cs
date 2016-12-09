using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entries;
using Services;

namespace TeamRankedWeb.Controllers.API
{

    [RoutePrefix("api/selection")]
    public class SelectionController : ApiController
    {
        [Route("")]
        [HttpPost]
        public List<Team> GeTeams(List<Player> players)
        {
            return Selection.GetTeams(players, 3);
        }
    }
}
