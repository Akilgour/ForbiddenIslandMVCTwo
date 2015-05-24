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
        public GamePlaySetting Create(DifficultyLevel DifficultyLevel)
        {
            var gamePlaySetting = new GamePlaySetting();

            gamePlaySetting.Id = Guid.NewGuid();
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

            return gamePlaySetting;
        }
    }
}