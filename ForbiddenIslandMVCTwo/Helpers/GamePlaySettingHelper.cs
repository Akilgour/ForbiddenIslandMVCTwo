using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Helpers
{
    public static class GamePlaySettingHelper
    {

        private static Dictionary<double, int> fourPlayers = new Dictionary<double, int>() {
            {.25, 1},
            {.5, 2},
            {.75, 3},
            {0, 4},
        };

        private static Dictionary<double, int> threePlayers = new Dictionary<double, int>() {
            {.33, 1},
            {.67, 2},
            {0, 3},
        };

        private static Dictionary<double, int> twoPlayers = new Dictionary<double, int>() {
            {.5, 1},
            {0, 2},
        };

        private static Dictionary<double, int> onePlayers = new Dictionary<double, int>() {
            {0, 1},
        };

        /// <summary>
        /// Reutns the current player.  
        /// Worked out using the number of players that here is and the and the turn number 
        /// </summary>
        /// <param name="gamePlaySetting"></param>
        /// <returns></returns>
        public static Player CurrentPlayer(GamePlaySetting gamePlaySetting)
        {
            var numberOfPlayer = NumberOfPlayers(gamePlaySetting);
            var moveNumber = gamePlaySetting.MoveNumber;
            Dictionary<double, int> playerDictionary = null;

            switch (numberOfPlayer)
            {
                case 1:
                    playerDictionary = onePlayers;
                    break;
                case 2:
                    playerDictionary = twoPlayers;
                    break;
                case 3:
                    playerDictionary = threePlayers;
                    break;
                case 4:
                    playerDictionary = fourPlayers;
                    break;
            }

            var moveNumberDividedNumberOfPlayer = (double)moveNumber / (double)numberOfPlayer;
            var key = moveNumberDividedNumberOfPlayer - Math.Floor(moveNumberDividedNumberOfPlayer);
            var playerNumber = playerDictionary[Math.Round(key, 2)];
            return GetPlayerByNumber(gamePlaySetting, playerNumber);
        }

        /// <summary>
        /// Will give the number of players in the system
        /// </summary>
        /// <param name="gamePlaySetting"></param>
        /// <returns></returns>
        public static int NumberOfPlayers(GamePlaySetting gamePlaySetting)
        {
            if (gamePlaySetting.FirstMovePlayer == null) { return 0; }
            if (gamePlaySetting.SecondMovePlayer == null) { return 1; }
            if (gamePlaySetting.ThirdMovePlayer == null) { return 2; }
            if (gamePlaySetting.FourthMovePlayer == null) { return 3; }
            return 4;
        }

        /// <summary>
        /// Will give player based 
        /// gamePlaySetting 1 = FirstMovePlayer
        /// gamePlaySetting 2 = SecondMovePlayer
        /// gamePlaySetting 3 = ThirdMovePlayer
        /// gamePlaySetting 4 = FourthMovePlayer
        /// </summary>
        /// <param name="gamePlaySetting">The index of the player you want</param>
        /// <param name="playerNumber"></param>
        /// <returns></returns>
        public static Player GetPlayerByNumber(GamePlaySetting gamePlaySetting, int playerNumber)
        {
            switch (playerNumber)
            {
                case 1:
                    return gamePlaySetting.FirstMovePlayer;
                case 2:
                    return gamePlaySetting.SecondMovePlayer;
                case 3:
                    return gamePlaySetting.ThirdMovePlayer;
                case 4:
                    return gamePlaySetting.FourthMovePlayer;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}