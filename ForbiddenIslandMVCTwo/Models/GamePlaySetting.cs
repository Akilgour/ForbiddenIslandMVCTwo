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
        public int MoveNumber { get; set; }
        public int WaterLevelMarker { get; set; }
        public Guid DrawDeckId { get; set; }
        public Guid DiscardDeckId { get; set; }

        [ForeignKey("FirstMovePlayerId")]
        public virtual Player FirstMovePlayer { get; set; }
        [ForeignKey("SecondMovePlayerId")]
        public virtual Player SecondMovePlayer { get; set; }
        [ForeignKey("ThirdMovePlayerId")]
        public virtual Player ThirdMovePlayer { get; set; }
        [ForeignKey("FourthMovePlayerId")]
        public virtual Player FourthMovePlayer { get; set; }
        public virtual List<TreasureCard> DrawDeck { get; set; }
   
    }
}