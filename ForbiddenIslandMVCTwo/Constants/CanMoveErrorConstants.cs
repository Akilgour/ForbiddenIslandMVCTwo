using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Constants
{
    public static class CanMoveErrorConstants
    {
        public const string ONLY_MOVE_ONE_ROW = "Can only move one row at a time";
        public const string ONLY_MOVE_ONE_COLUMN = "Can only move one column at a time";
        public const string NEED_FOUR_MOVE_TILES = "MoveType four player move tiles";
        public const string CANMOVEVALIDATION_CANNOT_BE_NULL = "CanMoveValidation cannot be null";
        public const string PLAYERMOVES_CANNOT_BE_NULL = "PlayerMoves cannot be null";
    }
}