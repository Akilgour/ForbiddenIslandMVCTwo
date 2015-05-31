using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Models
{
    public class Island
    {
        [Key]
        public Guid Id { get; set; }

        public List<IslandTile> IslandBoard { get; set; }

        public Guid MoveOne { get; set; }
        public Guid MoveTwo { get; set; }
        public Guid MoveThree { get; set; }

        public Guid CurrentPlayerId { get; set; }

        public Guid GameId { get; set; }
        public virtual GamePlaySetting GamePlaySetting { get; set; }
    }
}