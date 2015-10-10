using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Constants
{
    public static class PlayerConstants
    {
        public const string MESSENGER_ACTION = "Give Treasure card to a player anywhere on the island for 1 action per card.";
        public const string EXPLORER_ACTION = "Move and/or short up diagonally.";
        public const string DIVER_ACTION = "Move throught 1 onr more adjacent flooded and/or missing tiles for 1 action. (Must end your turn on a tile.)";
        public const string PILOT_ACTION = "Once per turn, fly to any tile on the island for 1 action.";
        public const string NAVIGATOR_ACTION = "Move another player up to 2 adjacent tiles for 1 action.";
        public const string ENGINEER_ACTION = "Shore up 2 tiles for 1 action.";

        public const string MESSENGER_NAME = "Messenger";
        public const string EXPLORER_NAME = "Explorer";
        public const string DIVER_NAME = "Diver";
        public const string PILOT_NAME = "Pilot";
        public const string NAVIGATOR_NAME = "Navigator";
        public const string ENGINEER_NAME = "Engineer";

        public const string CANT_BE_MORE_THAN_FOUR = "Cant be more than 4 players ";
        public const string PLAYER_COUNT_CANT_BE_LONGER_THAN_PLAYER_LIST = "Player count cant be longer than player list";
        public static int PLAYER_CARD_STARTING_COUNT = 2;
    }
}