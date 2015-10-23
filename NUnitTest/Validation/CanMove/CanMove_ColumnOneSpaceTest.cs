using ForbiddenIslandMVCTwo.Constants;
using ForbiddenIslandMVCTwo.Models;
using ForbiddenIslandMVCTwo.Validation.CanMove;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest.Validation.CanMove
{
    [TestFixture]
    public class CanMove_ColumnOneSpaceTest
    {
        [TestCase(3, 1, "Tile 3x1", 3, 2, "Tile 3x2", true, null)]// Move OneRow ColumnOne To ColumnTwo IsValid
        [TestCase(3, 2, "Tile 3x2", 3, 1, "Tile 3x1", true, null)] // Move OneRow ColumnTwo To ColumnOne IsValid
        [TestCase(3, 1, "Tile 3x1", 3, 3, "Tile 3x3", false, CanMoveErrorConstants.ONLY_MOVE_ONE_COLUMN)]// Move TwoRows ColumnOne To ColumnThree NotValid
        [TestCase(3, 3, "Tile 3x3", 3, 1, "Tile 3x1", false, CanMoveErrorConstants.ONLY_MOVE_ONE_COLUMN)]// Move TwoRows ColumnThree To ColumnOne NotValid
        public void MoveOneRowColumnOneToColumnTwo_IsValid(int firstTileRowNumber, int firstTileColumnNumber, string firstTileName, int secondTileRowNumber, int secondTileColumnNumber, string secondTileName, bool isValid, string errorMessage)
        {
            //Arrange 
            var canMove = new CanMove_ColumnOneSpace();
            var firstTile = new IslandTile() { RowNumber = firstTileRowNumber, ColumnNumber = firstTileColumnNumber, Name = firstTileName };
            var secondTile = new IslandTile() { RowNumber = secondTileRowNumber, ColumnNumber = secondTileColumnNumber, Name = secondTileName };
            var currentPlayer = new Player();

            //Act 
            var validation = canMove.IsValid(firstTile, secondTile, currentPlayer);

            //Assert
            if (isValid)
            {
                Assert.AreEqual(errorMessage, validation);
            }
            else
            {
                Assert.AreEqual(string.Format(errorMessage, firstTileName, secondTileName), validation.ErrorMessage);
            }
        }
    }
}
