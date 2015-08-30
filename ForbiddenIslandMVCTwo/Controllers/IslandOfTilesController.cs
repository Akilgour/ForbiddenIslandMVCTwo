using ForbiddenIslandMVCTwo.Context;
using ForbiddenIslandMVCTwo.Helpers;
using ForbiddenIslandMVCTwo.Models;
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
            var islandOfTiles = LoadIslandOfTiles(gameId);
            return View(islandOfTiles);
        }

        [HttpPost]
        public ActionResult Index(IslandOfTiles island)
        {
            var islandOfTiles = LoadIslandOfTiles(island.GamePlaySettingsId);
            return View(islandOfTiles);
        }

        private IslandOfTiles LoadIslandOfTiles(Guid gameId)
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
            var currentPlayer = GamePlaySettingHelper.CurrentPlayer(gamePlaySettings);
            return new IslandOfTiles(queryIslandTiles, gamePlaySettings, currentPlayer);
        }

    }
}
