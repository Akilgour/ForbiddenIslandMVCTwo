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
                var query = context.IslandTiles.Include("PlayersOnTile").Where(x => x.GameId == gameId).Select(x => new IslandTileViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    RowNumber = x.RowNumber,
                    ColumnNumber = x.ColumnNumber,
                    PlayersOnTiles = x.PlayersOnTile
                });

                
                var islandOfTiles = new IslandOfTiles(query);

             //  PlayersOnTile

                return View(islandOfTiles);

            }
        }

    }
}
