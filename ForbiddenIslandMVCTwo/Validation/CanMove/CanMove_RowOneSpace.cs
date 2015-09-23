using ForbiddenIslandMVCTwo.Constants;
using ForbiddenIslandMVCTwo.Models;
using ForbiddenIslandMVCTwo.Validation.CanMove.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Validation.CanMove
{
    public class CanMove_RowOneSpace : ICanMoveValidation
    {
        public ValidationResults IsValid(IslandTile FirstIslandTile, IslandTile SecondIslandTile, Player Player)
        {

            int result = FirstIslandTile.RowNumber > SecondIslandTile.RowNumber ? FirstIslandTile.RowNumber - SecondIslandTile.RowNumber : SecondIslandTile.RowNumber - FirstIslandTile.RowNumber;

            if (result > 1)
            {
                return new ValidationResults() { IsValid = false, ErrorMessage = CanMoveErrorConstants.ONLY_MOVE_ONE_ROW };
            }

            return new ValidationResults() { IsValid = true };
        }
    }
}