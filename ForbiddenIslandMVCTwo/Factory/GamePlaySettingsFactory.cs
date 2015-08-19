using ForbiddenIslandMVCTwo.Constants;
using ForbiddenIslandMVCTwo.Enum.Repository.Enums;
using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Factory
{
    public class GamePlaySettingsFactory
    {
       private GamePlaySetting setting;

       public GamePlaySetting Create(DifficultyLevel DifficultyLevel, IPlayerListFactory PlayerListFactory, int PlayerCount, ITreasureDeckFactory TreasureDeckFactory, IIslandFactory IslandFactory)
        {
            setting = new GamePlaySetting();

            setting.Id = Guid.NewGuid();// temp till i can get  [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] working
            setting.Name = DateTime.Now.ToString();
            setting.MoveNumber = 0;

            switch (DifficultyLevel)
            {
                case DifficultyLevel.Novice:
                    setting.WaterLevelMarker = 1;
                    break;
                case DifficultyLevel.Normal:
                    setting.WaterLevelMarker = 2;
                    break;
                case DifficultyLevel.Elite:
                    setting.WaterLevelMarker = 3;
                    break;
                case DifficultyLevel.Legendary:
                    setting.WaterLevelMarker = 4;
                    break;
                default:
                    break;
            }

            var playerList = PlayerListFactory.Create();

            if (PlayerCount > 4)
            {
                throw new Exception(PlayerConstants.CANT_BE_MORE_THAN_FOUR);
            }

            if (PlayerCount > playerList.Count)
            {
                throw new Exception(PlayerConstants.PLAYER_COUNT_CANT_BE_LONGER_THAN_PLAYER_LIST);
            }


            setting.DrawDeckId = Guid.NewGuid();
            setting.DiscardDeckId = Guid.NewGuid();
            setting.DrawDeck = TreasureDeckFactory.Create(setting.DrawDeckId);

            if (PlayerCount >= 1)
            {
                setting.FirstMovePlayer = playerList[0];

                if (setting.DrawDeck.Where(x => x.Name != CardConstants.WATERRISE_NAME).Count() >= 2)
                {
                   SetCardAtIndexToBelongToPlayer(0, setting.FirstMovePlayer.Id);
                   SetCardAtIndexToBelongToPlayer(1, setting.FirstMovePlayer.Id);
                }

            }

            if (PlayerCount >= 2)
            {
                setting.SecondMovePlayer = playerList[1];

                if (setting.DrawDeck.Where(x => x.Name != CardConstants.WATERRISE_NAME).Count() >= 4)
                {
                    SetCardAtIndexToBelongToPlayer(2, setting.SecondMovePlayer.Id);
                    SetCardAtIndexToBelongToPlayer(3, setting.SecondMovePlayer.Id);
                }
            }

            if (PlayerCount >= 3)
            {
                setting.ThirdMovePlayer = playerList[2];
                if (setting.DrawDeck.Where(x => x.Name != CardConstants.WATERRISE_NAME).Count() >= 6)
                {
                    SetCardAtIndexToBelongToPlayer(4, setting.ThirdMovePlayer.Id);
                    SetCardAtIndexToBelongToPlayer(5, setting.ThirdMovePlayer.Id);
                }
            }

            if (PlayerCount >= 4)
            {
                setting.FourthMovePlayer = playerList[3];
                if (setting.DrawDeck.Where(x => x.Name != CardConstants.WATERRISE_NAME).Count() >= 8)
                {
                    SetCardAtIndexToBelongToPlayer(6, setting.FourthMovePlayer.Id);
                    SetCardAtIndexToBelongToPlayer(7, setting.FourthMovePlayer.Id);
                }
            }



            setting.IslandTiles = IslandFactory.Create(setting.Id);

            return setting;
        }

        /// <summary>
        /// Give a card at the index to the player id that is passed in
        /// sets that cards draw deck id to be null
        /// It will not give water rises card, it will give them the next card
        /// </summary>
        /// <param name="Index"></param>
        /// <param name="PlayerId"></param>
        private void SetCardAtIndexToBelongToPlayer(int Index, Guid PlayerId)
        {
            var card = setting.DrawDeck.Where(x => x.Name != CardConstants.WATERRISE_NAME).Skip(Index).Take(1).Single();
            card.DrawDeckId = null;
            card.PlayerId = PlayerId;
        }

        public void PlacePlayersOnStartingTiles(GamePlaySetting gamePlaySetting)
        {

            PlaceSinlePlayerOnStartingTiles(gamePlaySetting.IslandTiles, gamePlaySetting.FirstMovePlayer);
            PlaceSinlePlayerOnStartingTiles(gamePlaySetting.IslandTiles, gamePlaySetting.SecondMovePlayer);
            PlaceSinlePlayerOnStartingTiles(gamePlaySetting.IslandTiles, gamePlaySetting.ThirdMovePlayer);
            PlaceSinlePlayerOnStartingTiles(gamePlaySetting.IslandTiles, gamePlaySetting.FourthMovePlayer);
        }

        private void PlaceSinlePlayerOnStartingTiles(List<IslandTile> islandTiles, Player player)
        {
            if (player != null)
            {
                var tile = islandTiles.Single(x => x.StartingTileForPlayer == player.Colour);
                tile.PlayersOnTile.Add(player);
            }
        }
    }
}