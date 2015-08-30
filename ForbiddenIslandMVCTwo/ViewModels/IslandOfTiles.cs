using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.ViewModels
{
    public class IslandOfTiles
    {
        public Guid MoveOne { get; set; }
        public Guid MoveTwo { get; set; }   
        public Guid MoveThree { get; set; }
        public Guid GamePlaySettingsId { get; set; }

        //Default constructer for post backs
        public IslandOfTiles(){ }

        public IslandOfTiles(IQueryable<IslandTileViewModel> query, GamePlaySetting gamePlaySetting, Player currentPlayer)
        {
            AllIslandTile = query.ToList();
            GamePlaySetting = gamePlaySetting;
            GamePlaySettingsId = gamePlaySetting.Id;
            CurrentPlayer = currentPlayer;
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

        public Player CurrentPlayer  { get; private set; }
    }
}