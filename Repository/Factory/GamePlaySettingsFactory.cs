using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForbiddenIslandMVCTwo.Models;
using Repository.Enums;

namespace Repository.Factory
{
    public class GamePlaySettingsFactory
    {

        public GamePlaySetting Create(DifficultyLevel DifficultyLevel)
        {
            var gamePlaySetting = new GamePlaySetting();

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
