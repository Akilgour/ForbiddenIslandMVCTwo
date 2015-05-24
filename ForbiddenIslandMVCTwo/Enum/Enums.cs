using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Enum
{
    namespace Repository.Enums
    {
        public enum TileState
        {
            Normal,
            Flodded,
            Gone
        }

        public enum PlayerColour
        {
            Red,
            Yellow,
            Blue,
            Black,
            Green,
            Grey,
            None
        }

        public enum TreasureCardType
        {
            EarthStone,
            StatueOfTheWind,
            CrystalOfFire,
            OceansChalice,
            WaterRises,
            HelicopterLift,
            SandBags,
        }

        public enum TeasureCardDeckId
        {
            DrawDeck,
            DiscardDeck,
            PlayerOneDeck,
            PlayerTwoDeck,
            PlayerThreeDeck,
            PlayerFourDeck,
        }

        public enum TreasureStatue
        {
            EarthStone,
            StatueOfTheWind,
            CrystalOfFire,
            OceansChalice,
            None,
        }


        public enum MoveType
        {
            FirstMyPawnMoveTile,
            SecondMyPawnMoveTile,
            ThirdMyPawnMoveTile,
            FourthMyPawnMoveTile,
        }

        public enum DifficultyLevel
        {
            Novice,
            Normal,
            Elite,
            Legendary,
        }
    }

}