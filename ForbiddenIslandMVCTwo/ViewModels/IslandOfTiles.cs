using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.ViewModels
{
    public class IslandOfTiles
    {
        public IslandOfTiles(IQueryable<IslandTileViewModel> query, GamePlaySetting gamePlaySetting)
        {
            AllIslandTile = query.ToList();
            GamePlaySetting = gamePlaySetting;
        }

        public List<IslandTileViewModel> AllIslandTile { get; private set; }

        public GamePlaySetting GamePlaySetting { get; private set; }

        public List<IslandTileViewModel> FirstRow
        {
            get
            {
                return GetItemsAtRow(1);
            }
        }

        public List<IslandTileViewModel> SecondRow
        {
            get
            {
                return GetItemsAtRow(2);
            }
        }

        public List<IslandTileViewModel> ThirdRow
        {
            get
            {
                return GetItemsAtRow(3);
            }
        }

        public List<IslandTileViewModel> FourthRow
        {
            get
            {
                return GetItemsAtRow(4);
            }
        }

        public List<IslandTileViewModel> FifthRow
        {
            get
            {
                return GetItemsAtRow(5);
            }
        }

        public List<IslandTileViewModel> SixthRow
        {
            get
            {
                return GetItemsAtRow(6);
            }
        }

        private List<IslandTileViewModel> GetItemsAtRow(int index)
        {
            return AllIslandTile.Where(x => x.RowNumber == index).OrderBy(x => x.ColumnNumber).ToList();
        }

        public Player FirstPlayer
        {
            get
            {
                return AllIslandTile.SelectMany(x => x.PlayersOnTiles).Single(x => x.Id == gamePlaySetting.FirstMovePlayer.Id);              
            }   
        }

    }
}