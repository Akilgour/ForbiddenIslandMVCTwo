using ForbiddenIslandMVCTwo.Constants;
using ForbiddenIslandMVCTwo.Models;
using ForbiddenIslandMVCTwo.Validation.CanGiveCard;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.Validation.CanGiveCard
{
    [TestFixture]
    public class CanGiveCard_OnSameTileTest
    {
        [Test]
        public void IslandTileNull_Exception()
        {
            //Arrange 
            var canGiveCard = new CanGiveCard_OnSameTile();

            var firstPlayer = new Player() { Name = "first player" };
            var secondPlayer = new Player() { Name = "second player" };
            var card = new TreasureCard() { Name = "card a" };

            //Act
            var ex = Assert.Catch<ArgumentNullException>(() => canGiveCard.IsValid(null, firstPlayer, secondPlayer, card));

            //Assert
            StringAssert.Contains("Island tile can not be null", ex.Message);
        }

        [Test]
        public void GivingPlayerNull_Exception()
        {
            //Arrange 
            var canGiveCard = new CanGiveCard_OnSameTile();
            var firstTile = new IslandTile() { RowNumber = 3, ColumnNumber = 1, Name = "Tile 3x1" };
            var secondPlayer = new Player() { Name = "second player" };
            var card = new TreasureCard() { Name = "card a" };

            //Act
            var ex = Assert.Catch<ArgumentNullException>(() => canGiveCard.IsValid(firstTile, null, secondPlayer, card));

            //Assert
            StringAssert.Contains("Giving player can not be null", ex.Message);
        }

        [Test]
        public void ReceivingPlayerNull_Exception()
        {
            //Arrange 
            var canGiveCard = new CanGiveCard_OnSameTile();
            var firstTile = new IslandTile() { RowNumber = 3, ColumnNumber = 1, Name = "Tile 3x1" };
            var firstPlayer = new Player() { Name = "first player" };
            var card = new TreasureCard() { Name = "card a" };

            //Act
            var ex = Assert.Catch<ArgumentNullException>(() => canGiveCard.IsValid(firstTile, firstPlayer, null, card));

            //Assert
            StringAssert.Contains("Receiving player can not be null", ex.Message);
        }

        [Test]
        public void TreasureCardNull_Exception()
        {
            //Arrange 
            var canGiveCard = new CanGiveCard_OnSameTile();
            var firstTile = new IslandTile() { RowNumber = 3, ColumnNumber = 1, Name = "Tile 3x1" };
            var firstPlayer = new Player() { Name = "first player" };
            var secondPlayer = new Player() { Name = "second player" };

            //Act
            var ex = Assert.Catch<ArgumentNullException>(() => canGiveCard.IsValid(firstTile, firstPlayer, secondPlayer, null));

            //Assert
            StringAssert.Contains("Treasure card can not be null", ex.Message);
        }

        [Test]
        public void CanGiveCardWhenBothPlayersOnSameTile_IsValid()
        {
            //Arrange 
            var canGiveCard = new CanGiveCard_OnSameTile();
            var firstTile = new IslandTile() { RowNumber = 3, ColumnNumber = 1, Name = "Tile 3x1" };
            var firstPlayer = new Player() { Name = "first player" };
            var secondPlayer = new Player() { Name = "second player" };
            var card = new TreasureCard() { Name = "card a" };
            firstPlayer.PlayerHand = new List<TreasureCard>();
            firstPlayer.PlayerHand.Add(card);

            firstTile.PlayersOnTile = new List<Player>();
            firstTile.PlayersOnTile.Add(firstPlayer);
            firstTile.PlayersOnTile.Add(secondPlayer);


            //Act 
            var validation = canGiveCard.IsValid(firstTile, firstPlayer, secondPlayer, card);

            //Assert
            Assert.AreEqual(null, validation);
        }


        [Test]
        public void CanGiveCardWhenNotOnSameTile_Error()
        {
            //Arrange 
            var canGiveCard = new CanGiveCard_OnSameTile();
            var firstTile = new IslandTile() { RowNumber = 3, ColumnNumber = 1, Name = "Tile 3x1" };
            var firstPlayer = new Player() { Name = "first player" };
            var secondPlayer = new Player() { Name = "second player" };
            var card = new TreasureCard() { Name = "card a" };
            firstPlayer.PlayerHand = new List<TreasureCard>();
            firstPlayer.PlayerHand.Add(card);
            firstTile.PlayersOnTile = new List<Player>();
            firstTile.PlayersOnTile.Add(firstPlayer);

            //Act 
            var validation = canGiveCard.IsValid(firstTile, firstPlayer, secondPlayer, card);

            //Assert             
            Assert.AreEqual("first player can not give second player card a", validation.ErrorMessage);
        }

        [Test]
        public void CanGiveCardWhenNotOnSameTileButHaveOtherPlayerOnTile_Error()
        {
            //Arrange 
            var canGiveCard = new CanGiveCard_OnSameTile();
            var firstTile = new IslandTile() { RowNumber = 3, ColumnNumber = 1, Name = "Tile 3x1" };
            var firstPlayer = new Player() { Name = "first player" };
            var secondPlayer = new Player() { Name = "second player" };
            var thirdPlayer = new Player() { Name = "third player" };
            var card = new TreasureCard() { Name = "card a" };
            firstPlayer.PlayerHand = new List<TreasureCard>();
            firstPlayer.PlayerHand.Add(card);

            firstTile.PlayersOnTile = new List<Player>();
            firstTile.PlayersOnTile.Add(firstPlayer);
            firstTile.PlayersOnTile.Add(thirdPlayer);

            //Act 
            var validation = canGiveCard.IsValid(firstTile, firstPlayer, secondPlayer, card);

            //Assert             
            Assert.AreEqual("first player can not give second player card a", validation.ErrorMessage);

        }

        [Test]
        public void CanGiveCardWhenFirstPlayerNotOnTile_Error()
        {
            //Arrange 
            var canGiveCard = new CanGiveCard_OnSameTile();
            var firstTile = new IslandTile() { RowNumber = 3, ColumnNumber = 1, Name = "Tile 3x1" };
            var firstPlayer = new Player() { Name = "first player" };
            var secondPlayer = new Player() { Name = "second player" };
            var thirdPlayer = new Player() { Name = "third player" };
            var card = new TreasureCard() { Name = "card a" };
            firstPlayer.PlayerHand = new List<TreasureCard>();
            firstPlayer.PlayerHand.Add(card);

            firstTile.PlayersOnTile = new List<Player>();
            firstTile.PlayersOnTile.Add(secondPlayer);

            //Act 
            var validation = canGiveCard.IsValid(firstTile, firstPlayer, secondPlayer, card);

            //Assert             
            Assert.AreEqual("first player can not give second player card a", validation.ErrorMessage);

        }
    }
}
