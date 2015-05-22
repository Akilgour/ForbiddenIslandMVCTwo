using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Models
{
    public class GamePlaySetting
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual List<TreasureCard> TreasureCard { get; set; }



    }
}