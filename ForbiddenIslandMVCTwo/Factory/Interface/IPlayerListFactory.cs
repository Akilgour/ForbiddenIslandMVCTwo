using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;

namespace ForbiddenIslandMVCTwo.Factory
{
    public interface IPlayerListFactory
    {
        List<Player> Create();
    }
}
