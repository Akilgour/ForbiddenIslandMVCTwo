﻿using ForbiddenIslandMVCTwo.Constants;
using ForbiddenIslandMVCTwo.Models;
using ForbiddenIslandMVCTwo.Validation.CanMove.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Validation.CanMove
{
    public class CanMove_ColumnOneSpace : ICanMoveValidation
    {
        public ValidationResults IsValid(IslandTile FirstIslandTile, IslandTile SecondIslandTile, Player Player)
        {

            int result = FirstIslandTile.ColumnNumber > SecondIslandTile.ColumnNumber ? FirstIslandTile.ColumnNumber - SecondIslandTile.ColumnNumber : SecondIslandTile.ColumnNumber - FirstIslandTile.ColumnNumber;

            if (result > 1)
            {
                return new ValidationResults() { IsValid = false, ErrorMessage = CanMoveErrorConstants.ONLY_MOVE_ONE_COLUMN };
            }

            return new ValidationResults() { IsValid = true };
        }
    }
}