using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
namespace ForbiddenIslandMVCTwo.Factory
{
   public interface ITreasureDeckFactory
    {
       List<TreasureCard> Create(Guid DrawDeckId);
    }
}
