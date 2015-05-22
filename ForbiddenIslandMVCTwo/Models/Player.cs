using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Models
{
    public class Player
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Action { get; set; }
        public string Colour { get; set; }
        public string PlayerHandId { get; set; }
        public bool HasEarthStoneTreasureStatue { get; set; }
        public bool HasStatueOfTheWindTreasureStatue { get; set; }
        public bool HasCrystalOfFireTreasureStatue { get; set; }
        public bool HasOceansChaliceTreasureStatue { get; set; }
    }
}