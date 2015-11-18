using ForbiddenIslandMVCTwo.Models;
using ForbiddenIslandMVCTwo.Validation.CanGiveCard.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Validation.CanGiveCard
{
    public class CanGiveCard_OnSameTile : ICanGiveCardValidation
    {

        public ValidationResult IsValid(IslandTile islandTile, Player givingPlayer, Player receivingPlayer, TreasureCard treasureCard)
        {
            if (islandTile == null) throw new ArgumentNullException("Island tile can not be null");
            if (givingPlayer == null) throw new ArgumentNullException("Giving player can not be null");
            if (receivingPlayer == null) throw new ArgumentNullException("Receiving player can not be null");
            if (treasureCard == null) throw new ArgumentNullException("Treasure card can not be null");

            if ((!islandTile.PlayersOnTile.Any(x => x == givingPlayer)) || (!islandTile.PlayersOnTile.Any(x => x == receivingPlayer)))
            {
                return new ValidationResult(string.Format("{0} can not give {1} {2}", givingPlayer.Name, receivingPlayer.Name, treasureCard.Name));
            }
            return ValidationResult.Success;
        }
    }
}