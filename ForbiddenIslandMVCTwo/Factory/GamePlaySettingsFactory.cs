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
        public GamePlaySetting Create(DifficultyLevel DifficultyLevel, IPlayerListFactory PlayerListFactory, int PlayerCount)
        {
            var gamePlaySetting = new GamePlaySetting();

            gamePlaySetting.Id = Guid.NewGuid();// temp till i can get  [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)] working
            gamePlaySetting.Name = DateTime.Now.ToString();
            gamePlaySetting.MoveNumber = 0;

            switch (DifficultyLevel)
            {
                case DifficultyLevel.Novice:
                    gamePlaySetting.WaterLevelMarker = 1;
                    break;
                case DifficultyLevel.Normal:
                    gamePlaySetting.WaterLevelMarker = 2;
                    break;
                case DifficultyLevel.Elite:
                    gamePlaySetting.WaterLevelMarker = 3;
                    break;
                case DifficultyLevel.Legendary:
                    gamePlaySetting.WaterLevelMarker = 4;
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

            if (PlayerCount >= 1)
            {
                gamePlaySetting.FirstMovePlayer = playerList[0];
            }

            if (PlayerCount >= 2)
            {
                gamePlaySetting.SecondMovePlayer = playerList[1];
            }

            if (PlayerCount >= 3)
            {
                gamePlaySetting.ThirdMovePlayer = playerList[2];
            }

            if (PlayerCount >= 4)
            {
                gamePlaySetting.FourthMovePlayer = playerList[3];
            }

            return gamePlaySetting;
        }
    }
}