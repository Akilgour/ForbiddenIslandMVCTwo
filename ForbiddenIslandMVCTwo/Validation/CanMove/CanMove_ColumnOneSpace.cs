using ForbiddenIslandMVCTwo.Constants;
using ForbiddenIslandMVCTwo.Models;
using ForbiddenIslandMVCTwo.Validation.CanMove.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Validation.CanMove
{
    public class CanMove_ColumnOneSpace : ICanMoveValidation
    {
        public ValidationResult IsValid(IslandTile FirstIslandTile, IslandTile SecondIslandTile, Player Player)
        {

            int result = FirstIslandTile.ColumnNumber > SecondIslandTile.ColumnNumber ? FirstIslandTile.ColumnNumber - SecondIslandTile.ColumnNumber : SecondIslandTile.ColumnNumber - FirstIslandTile.ColumnNumber;

            if (result > 1)
            {
                return new ValidationResult(string.Format(CanMoveErrorConstants.ONLY_MOVE_ONE_COLUMN, FirstIslandTile.Name, SecondIslandTile.Name));
            }

            return ValidationResult.Success;
        }
    }
}