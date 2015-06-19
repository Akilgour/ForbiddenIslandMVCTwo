using ForbiddenIslandMVCTwo.Context;
using ForbiddenIslandMVCTwo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForbiddenIslandMVCTwo.Controllers
{
    public class IslandOfTilesController : Controller
    {
        //
        // GET: /Island/
        public ActionResult Index(Guid gameId)
        {
            using (var context = new ForbiddenIslandContext())
            {
                var query = context.IslandTiles.Where(x => x.GameId == gameId);
                var islandOfTiles = new IslandOfTiles();

                //TODO should be factory, but just test stuff
                islandOfTiles.AllIslandTile = query.ToList();

                return View(islandOfTiles);

            }
        }

    }
}
