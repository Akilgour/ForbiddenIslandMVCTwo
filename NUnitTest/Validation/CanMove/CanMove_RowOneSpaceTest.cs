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
    public class CanMove_RowOneSpaceTest
    {
        [TestCase(1, 3, 2, 3, true, null)]// Move OneRow RowOne To RowTwo IsValid
        [TestCase(2, 3, 1, 3, true, null)]// Move OneRow RowTwo To RowOne IsValid
        [TestCase(1, 3, 3, 3, false, CanMoveErrorConstants.ONLY_MOVE_ONE_ROW)]// Move TwoRow RowOne To RowThree NotValid
        [TestCase(3, 3, 1, 3, false, CanMoveErrorConstants.ONLY_MOVE_ONE_ROW)]// Move TwoRow RowThree To RowOne NotValid
        public void MoveOneRowRowOneToRowTwo_IsValid(int firstTileRowNumber, int firstTileColumnNumber, int secondTileRowNumber, int secondTileColumnNumber, bool isValid, string errorMessage)
        {
            //Arrange 
            var canMove = new CanMove_RowOneSpace();
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
