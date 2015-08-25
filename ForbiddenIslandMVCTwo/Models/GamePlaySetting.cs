using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Models
{
    public class GamePlaySetting
    {
 
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid? FirstMovePlayerId { get; set; }
        public Guid? SecondMovePlayerId { get; set; }
        public Guid? ThirdMovePlayerId { get; set; }
        public Guid? FourthMovePlayerId { get; set; }
        [Display(Name = "Move Number")]
        public int MoveNumber { get; set; }
        [Display(Name = "Water Level")]
        public int WaterLevelMarker { get; set; }
        public Guid DrawDeckId { get; set; }
        public Guid DiscardDeckId { get; set; }

        [Display(Name = "First Move Player")]
        [ForeignKey("FirstMovePlayerId")]
        public virtual Player FirstMovePlayer { get; set; }
        [Display(Name = "Second Move Player")]
        [ForeignKey("SecondMovePlayerId")]
        public virtual Player SecondMovePlayer { get; set; }
        [Display(Name = "Third Move Player")]
        [ForeignKey("ThirdMovePlayerId")]
        public virtual Player ThirdMovePlayer { get; set; }
        [Display(Name = "Four Move Player")]
        [ForeignKey("FourthMovePlayerId")]
        public virtual Player FourthMovePlayer { get; set; }
        public virtual List<TreasureCard> DrawDeck { get; set; }
        public virtual List<IslandTile> IslandTiles { get; set; }
    }
}