using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ForbiddenIslandMVCTwo.Models;

namespace ForbiddenIslandMVCTwo.Context
{
    public class ForbiddenIslandContext : DbContext
    {
        public DbSet<GamePlaySetting> GamePlaySettings { get; set; }
        public DbSet<TreasureCard> TreasureCards { get; set; }
        public DbSet<Player> Players { get; set; } 

    }
}