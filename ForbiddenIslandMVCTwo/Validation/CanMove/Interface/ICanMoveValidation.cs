using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenIslandMVCTwo.Validation.CanMove.Interface
{
    public interface ICanMoveValidation
    {
        ValidationResult IsValid(IslandTile FirstIslandTile, IslandTile SecondIslandTile, Player Player);
    }
}
