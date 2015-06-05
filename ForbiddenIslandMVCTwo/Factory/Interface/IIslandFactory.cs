using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;

namespace ForbiddenIslandMVCTwo.Factory
{
    public interface IIslandFactory
    {
        List<IslandTile> Create(Guid gameId);
    }
}
