﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Models
{
    public class TreasureCard
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Action { get; set; }
        public string TreasureCardType { get; set; }
        public int Order { get; set; }
        public string DeckTheCardIsIn { get; set; }

        public Guid GameId { get; set; }
        public virtual GamePlaySetting GamePlaySetting { get; set; }
        public Guid? DrawDeckId { get; set; }
        public Guid? PlayerId { get; set; }
    }
}