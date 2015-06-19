using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.ViewModels
{
    public class IslandOfTiles
    {

        public List<IslandTile> AllIslandTile { get; set; }

        public List<IslandTile> FirstRow
        {
            get
            
            {
                return GetItemsAtRow(1);
            }
        }

        public List<IslandTile> SecondRow
        {
            get
            {
                return GetItemsAtRow(2);
            }
        }

        public List<IslandTile> ThirdRow
        {
            get
            {
                return GetItemsAtRow(3);
            }
        }

        public List<IslandTile> FourthRow
        {
            get
            {
                return GetItemsAtRow(4);
            }
        }

        public List<IslandTile> FifthRow
        {
            get
            {
                return GetItemsAtRow(5);
            }
        }

        public List<IslandTile> SixthRow
        {
            get
            {
                return GetItemsAtRow(6);
            }
        }

        private List<IslandTile> GetItemsAtRow(int index)
        {
            return AllIslandTile.Where(x => x.RowNumber == index).OrderBy(x => x.ColumnNumber).ToList();
        }

    }
}