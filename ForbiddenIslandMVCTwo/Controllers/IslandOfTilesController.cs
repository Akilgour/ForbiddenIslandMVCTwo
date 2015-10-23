using DependencyResolver;
using ForbiddenIslandMVCTwo.Context;
using ForbiddenIslandMVCTwo.Helpers;
using ForbiddenIslandMVCTwo.Models;
using ForbiddenIslandMVCTwo.Validation.CanMove.Interface;
using ForbiddenIslandMVCTwo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ForbiddenIslandMVCTwo.Controllers
{
    public class IslandOfTilesController : Controller
    {

        private ForbiddenIslandContext context = new ForbiddenIslandContext();
        private ValidationResults validation;

        //
        // GET: /Island/
        public ActionResult Index(Guid gameId)
        {
            var islandOfTiles = LoadIslandOfTiles(gameId);
            return View(islandOfTiles);
        }

        //On Submit Button Click
        [HttpPost]
        public ActionResult Index(IslandOfTiles island)
        {
            //   var firstMoveTile = context.IslandTiles.Where(x => x.Id == island.CurrentPlayer.t).Single();
            var gamePlaySettings = context.GamePlaySettings.Single(x => x.Id == island.GamePlaySettingsId);
            var currentPlayer = GamePlaySettingHelper.CurrentPlayer(gamePlaySettings);

            var currentPlayerTile = context.IslandTiles.Where(x => x.Id == island.CurrentPlayerTileId).Single();
            var firstMoveTile = context.IslandTiles.Where(x => x.Id == island.MoveOne).Single();
            var secondMoveTile = context.IslandTiles.Where(x => x.Id == island.MoveTwo).Single();
            var thirdMoveTile = context.IslandTiles.Where(x => x.Id == island.MoveThree).Single();

            var porkLoin = new PorkLoin();
            var canMoveValidationList = porkLoin.GetList<ICanMoveValidation>().ToList();

            foreach (var canMoveValidation in canMoveValidationList)
            {
                CanMoveValidation(currentPlayerTile, firstMoveTile, canMoveValidation, currentPlayer);
                CanMoveValidation(firstMoveTile, secondMoveTile, canMoveValidation, currentPlayer);
                CanMoveValidation(secondMoveTile, thirdMoveTile, canMoveValidation, currentPlayer);
            }

            var islandOfTiles = LoadIslandOfTiles(island.GamePlaySettingsId);
            return View(islandOfTiles);
        }

        private void CanMoveValidation(IslandTile firstMoveTile, IslandTile secondMoveTile, ICanMoveValidation canMoveValidation, Player player)
        {
            var validationResults = canMoveValidation.IsValid(firstMoveTile, secondMoveTile, player);
            if (validationResults != null)
            {
                ModelState.AddModelError("", validationResults.ErrorMessage);
            }
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
