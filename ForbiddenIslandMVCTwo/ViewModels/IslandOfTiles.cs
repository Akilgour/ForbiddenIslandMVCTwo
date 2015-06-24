﻿using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.ViewModels
{
    public class IslandOfTiles
    {
      

        public IslandOfTiles(IQueryable<IslandTileViewModel> query)
        {
            // TODO: Make Factory
            AllIslandTile = query.ToList();
        }

        public List<IslandTileViewModel> AllIslandTile { get; set; }


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

    }
}