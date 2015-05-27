using ForbiddenIslandMVCTwo.Factory;
using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenIslandMVCTwo.Tests.Factory.Mocks
{
    class PlayerListFactoryEmpty : IPlayerListFactory
    {
        public List<Player> Create()
        {
            return new List<Player>();
            
        }
    }
}
