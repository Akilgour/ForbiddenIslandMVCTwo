using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Models
{
    public class IslandTile
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string SubmergedState { get; set; }
        public string StartingTileForPlayer { get; set; }
        public bool HelicopterSite { get; set; }
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public bool HasStatue { get; set; }
        public string CanHaveStatue { get; set; }
        public Guid GameId { get; set; }

        public virtual ICollection<Player> PlayersOnTile { get; set; } 
    }
}