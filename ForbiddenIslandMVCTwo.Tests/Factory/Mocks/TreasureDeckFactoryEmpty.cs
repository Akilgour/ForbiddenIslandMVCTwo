using ForbiddenIslandMVCTwo.Factory;
using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenIslandMVCTwo.Tests.Factory.Mocks
{
    public class TreasureDeckFactoryEmpty : ITreasureDeckFactory
    {
        public List<TreasureCard> Create(Guid DrawDeckId)
        {
            return new List<TreasureCard>();
        }
    }
}
