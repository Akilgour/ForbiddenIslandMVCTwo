using ForbiddenIslandMVCTwo.Enum.Repository.Enums;
using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Factory
{
   public class IslandFactory : IIslandFactory
    {

       private Guid GameId;

       public List<IslandTile> Create(Guid gameId)
        {
           // var island = new Island();
            GameId = gameId;
          
            // island.IslandBoard = new List<IslandTile>();
            List<IslandTile> islandBoard = new List<IslandTile>();

            //AK so i know this should be passed in by a list, that is loaded from a external file, but this is first pass

            //A

            //B 2
            islandBoard.Add(CreateIslandTile("Breakers Bridge"));
            islandBoard.Add(CreateIslandTile("Bronze Gate", PlayerColour.Red));

            //C 6
            islandBoard.Add(CreateIslandTile("Cave of Embers", TreasureStatue.CrystalOfFire));
            islandBoard.Add(CreateIslandTile("Cave of Shadows", TreasureStatue.CrystalOfFire));
            islandBoard.Add(CreateIslandTile("Cliffs of Abandon"));
            islandBoard.Add(CreateIslandTile("Copper Gate", PlayerColour.Green));
            islandBoard.Add(CreateIslandTile("Coral Palace", TreasureStatue.OceansChalice));
            islandBoard.Add(CreateIslandTile("Crimson Forest"));
            //D 1
            islandBoard.Add(CreateIslandTile("Dunes of Deception"));
            //E

            //F 1
            islandBoard.Add(CreateIslandTile("Fools' Landing", PlayerColour.Blue, true));
            //G 1
            islandBoard.Add(CreateIslandTile("Gold Gate", PlayerColour.Yellow));

            //H 
            islandBoard.Add(CreateIslandTile("Howling Garden", TreasureStatue.StatueOfTheWind));

            //I 1
            islandBoard.Add(CreateIslandTile("Iron Gate", PlayerColour.Black));

            //J

            //K

            //L 1 
            islandBoard.Add(CreateIslandTile("Lost Lagoon"));

            //M 1
            islandBoard.Add(CreateIslandTile("Misty March"));

            //N

            //O 1
            islandBoard.Add(CreateIslandTile("Observatory"));


            //P 1
            islandBoard.Add(CreateIslandTile("Phantom Rock"));

            //Q

            //R

            //S 1
            islandBoard.Add(CreateIslandTile("Silver Gate", PlayerColour.Grey));
            //T 4
            islandBoard.Add(CreateIslandTile("Temple of the Moon", TreasureStatue.EarthStone));
            islandBoard.Add(CreateIslandTile("Temple of the Sun", TreasureStatue.EarthStone));
            islandBoard.Add(CreateIslandTile("Tidal Palace", TreasureStatue.OceansChalice));
            islandBoard.Add(CreateIslandTile("Twilight Hollow"));
            //U

            //V

            //W 2
            islandBoard.Add(CreateIslandTile("Watchtower"));
            islandBoard.Add(CreateIslandTile("Whispering Garden", TreasureStatue.StatueOfTheWind));
            //X

            //Y

            //Z       

            islandBoard = islandBoard.OrderBy(x => Guid.NewGuid()).ToList();

            //Since the list has been randomised by the above order, line i just set the firt item it find that can have a status and set it to have a staute
            islandBoard.First(x => x.CanHaveStatue == TreasureStatue.StatueOfTheWind.ToString()).HasStatue = true;
            islandBoard.First(x => x.CanHaveStatue == TreasureStatue.CrystalOfFire.ToString()).HasStatue = true;
            islandBoard.First(x => x.CanHaveStatue == TreasureStatue.EarthStone.ToString()).HasStatue = true;
            islandBoard.First(x => x.CanHaveStatue == TreasureStatue.OceansChalice.ToString()).HasStatue = true;


            SetRowAnColumnNumber(islandBoard[0], 1, 3);
            SetRowAnColumnNumber(islandBoard[1], 1, 4);

            SetRowAnColumnNumber(islandBoard[2], 2, 2);
            SetRowAnColumnNumber(islandBoard[3], 2, 3);
            SetRowAnColumnNumber(islandBoard[4], 2, 4);
            SetRowAnColumnNumber(islandBoard[5], 2, 5);

            SetRowAnColumnNumber(islandBoard[6], 3, 1);
            SetRowAnColumnNumber(islandBoard[7], 3, 2);
            SetRowAnColumnNumber(islandBoard[8], 3, 3);
            SetRowAnColumnNumber(islandBoard[9], 3, 4);
            SetRowAnColumnNumber(islandBoard[10], 3, 5);
            SetRowAnColumnNumber(islandBoard[11], 3, 6);

            SetRowAnColumnNumber(islandBoard[12], 4, 1);
            SetRowAnColumnNumber(islandBoard[13], 4, 2);
            SetRowAnColumnNumber(islandBoard[14], 4, 3);
            SetRowAnColumnNumber(islandBoard[15], 4, 4);
            SetRowAnColumnNumber(islandBoard[16], 4, 5);
            SetRowAnColumnNumber(islandBoard[17], 4, 6);

            SetRowAnColumnNumber(islandBoard[18], 5, 2);
            SetRowAnColumnNumber(islandBoard[19], 5, 3);
            SetRowAnColumnNumber(islandBoard[20], 5, 4);
            SetRowAnColumnNumber(islandBoard[21], 5, 5);

            SetRowAnColumnNumber(islandBoard[22], 6, 3);
            SetRowAnColumnNumber(islandBoard[23], 6, 4);

            islandBoard.Add(CreateSeaTile(1, 1));
            islandBoard.Add(CreateSeaTile(1, 2));
            islandBoard.Add(CreateSeaTile(1, 5));
            islandBoard.Add(CreateSeaTile(1, 6));

            islandBoard.Add(CreateSeaTile(2, 1));
            islandBoard.Add(CreateSeaTile(2, 6));

            islandBoard.Add(CreateSeaTile(5, 1));
            islandBoard.Add(CreateSeaTile(5, 6));

            islandBoard.Add(CreateSeaTile(6, 1));
            islandBoard.Add(CreateSeaTile(6, 2));
            islandBoard.Add(CreateSeaTile(6, 5));
            islandBoard.Add(CreateSeaTile(6, 6));

            //var playerListFactory = new PlayerListFactory();
            //var playerList = playerListFactory.Create();
            //for (int i = 0; i <= 3; i++)
            //{
            //    islandBoard.Single(x => x.StartingTileForPlayer == playerList[i].Colour).PlayersOnTile.Add(playerList[i]);
            //}
            return islandBoard;
        }

         private static void SetRowAnColumnNumber(IslandTile islandTile, int RowNumber, int ColumnNumber)
        {
            islandTile.ColumnNumber = ColumnNumber;
            islandTile.RowNumber = RowNumber;
        }

        private IslandTile CreateIslandTile(string tileName)
        {
            return CreateIslandTile(tileName, PlayerColour.None, false, TreasureStatue.None, false);
        }

        private IslandTile CreateIslandTile(string tileName, TreasureStatue TreasureStatue)
        {
            return CreateIslandTile(tileName, PlayerColour.None, false, TreasureStatue, false);
        }

        private IslandTile CreateIslandTile(string tileName, PlayerColour startingTileForPlayer)
        {
            return CreateIslandTile(tileName, startingTileForPlayer, false, TreasureStatue.None, false);
        }

        private IslandTile CreateIslandTile(string tileName, PlayerColour startingTileForPlayer, bool helicopterSite)
        {
            return CreateIslandTile(tileName, startingTileForPlayer, helicopterSite, TreasureStatue.None, false);
        }

        private IslandTile CreateIslandTile(string tileName, PlayerColour startingTileForPlayer, bool helicopterSite, TreasureStatue TreasureStatue, bool HasStatue)
        {
            var islandTile = new IslandTile();
            islandTile.Id = Guid.NewGuid();
            islandTile.Name = tileName;
            islandTile.StartingTileForPlayer = startingTileForPlayer.ToString();
            islandTile.SubmergedState = TileState.Normal.ToString();
            islandTile.HelicopterSite = helicopterSite;
            islandTile.PlayersOnTile = new List<Player>();
            islandTile.CanHaveStatue = TreasureStatue.ToString();
            islandTile.HasStatue = HasStatue;
            islandTile.GameId = GameId;
            return islandTile;
        }

        private IslandTile CreateSeaTile(int RowNumber, int ColumnNumber)
        {
            var islandTile = new IslandTile();
            islandTile.Id = Guid.NewGuid();
            islandTile.Name = "Sea";
            islandTile.StartingTileForPlayer = PlayerColour.None.ToString();
            islandTile.SubmergedState = TileState.Gone.ToString();
            islandTile.HelicopterSite = false;
            islandTile.RowNumber = RowNumber;
            islandTile.ColumnNumber = ColumnNumber;
            islandTile.PlayersOnTile = new List<Player>();
            islandTile.CanHaveStatue = TreasureStatue.None.ToString();
            islandTile.HasStatue = false;
            islandTile.GameId = GameId;
            return islandTile;
        }
    }
}