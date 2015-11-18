using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenIslandMVCTwo.Validation.CanGiveCard.Interface
{
    public interface ICanGiveCardValidation
    {
        ValidationResult IsValid(IslandTile islandTile, Player givingPlayer, Player receivingPlayer, TreasureCard treasureCard);
    }
}
