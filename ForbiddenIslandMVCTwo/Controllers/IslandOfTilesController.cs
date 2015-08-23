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

         private ForbiddenIslandContext context = new ForbiddenIslandContext();

        //
        // GET: /Island/
        public ActionResult Index(Guid gameId)
        {
          
                var queryIslandTiles = context.IslandTiles.Where(x => x.GameId == gameId).Select(x => new IslandTileViewModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    RowNumber = x.RowNumber,
                    ColumnNumber = x.ColumnNumber,
                    PlayersOnTiles = x.PlayersOnTile,
             
                });



                var gamePlaySettings = context.GamePlaySettings.Single(x => x.Id == gameId);

                var islandOfTiles = new IslandOfTiles(queryIslandTiles, gamePlaySettings);

             //  PlayersOnTile

                return View(islandOfTiles);

        }

    }
}
