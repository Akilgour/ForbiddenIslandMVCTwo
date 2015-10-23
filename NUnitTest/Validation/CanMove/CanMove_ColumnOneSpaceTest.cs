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
        [TestCase(3, 1, 3, 2, true, null)]// Move OneRow ColumnOne To ColumnTwo IsValid
        [TestCase(3, 2, 3, 1, true, null)] // Move OneRow ColumnTwo To ColumnOne IsValid
        [TestCase(3, 1, 3, 3, false, CanMoveErrorConstants.ONLY_MOVE_ONE_COLUMN)]// Move TwoRows ColumnOne To ColumnThree NotValid
        [TestCase(3, 3, 3, 1, false, CanMoveErrorConstants.ONLY_MOVE_ONE_COLUMN)]// Move TwoRows ColumnThree To ColumnOne NotValid
        public void MoveOneRowColumnOneToColumnTwo_IsValid(int firstTileRowNumber, int firstTileColumnNumber, int secondTileRowNumber, int secondTileColumnNumber, bool isValid, string errorMessage)
        {
            //Arrange 
            var canMove = new CanMove_ColumnOneSpace();
            var firstTile = new IslandTile() { RowNumber = firstTileRowNumber, ColumnNumber = firstTileColumnNumber };
            var secondTile = new IslandTile() { RowNumber = secondTileRowNumber, ColumnNumber = secondTileColumnNumber };
            var currentPlayer = new Player();

            //Act 
            var validation = canMove.IsValid(firstTile, secondTile, currentPlayer);

            //Assert
            Assert.AreEqual(isValid, validation.IsValid);
            Assert.AreEqual(errorMessage, validation.ErrorMessage);
        }

    }
}
