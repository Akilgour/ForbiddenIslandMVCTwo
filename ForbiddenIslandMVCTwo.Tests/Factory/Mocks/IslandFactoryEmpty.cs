using ForbiddenIslandMVCTwo.Factory;
using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenIslandMVCTwo.Tests.Factory.Mocks
{
    class IslandFactoryEmpty : IIslandFactory
    {
        public List<IslandTile> Create(Guid gameId)
        {
            return new List<IslandTile>();
        }
    }
}
