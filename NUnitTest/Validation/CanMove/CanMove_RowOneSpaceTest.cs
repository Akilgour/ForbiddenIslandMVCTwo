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
        [TestCase(1, 3, 2, 3 )]// Move OneRow RowOne To RowTwo IsValid
        [TestCase(2, 3, 1, 3 )]// Move OneRow RowTwo To RowOne IsValid
        
        public void MoveOneRowRowOneToRowTwo_IsValid(int firstTileRowNumber, int firstTileColumnNumber, int secondTileRowNumber, int secondTileColumnNumber)
        {
            //Arrange 
            var canMove = new CanMove_RowOneSpace();
            var firstTile = new IslandTile() { RowNumber = firstTileRowNumber, ColumnNumber = firstTileColumnNumber };
            var secondTile = new IslandTile() { RowNumber = secondTileRowNumber, ColumnNumber = secondTileColumnNumber };
            var currentPlayer = new Player();

            //Act 
            var validation = canMove.IsValid(firstTile, secondTile, currentPlayer);

            //Assert
            Assert.AreEqual(null, validation);
        }

        [TestCase(1, 3, 3, 3,  CanMoveErrorConstants.ONLY_MOVE_ONE_ROW)]// Move TwoRow RowOne To RowThree NotValid
        [TestCase(3, 3, 1, 3,  CanMoveErrorConstants.ONLY_MOVE_ONE_ROW)]// Move TwoRow RowThree To RowOne NotValid
        public void MoveOneRowRowOneToRowTwo_Error(int firstTileRowNumber, int firstTileColumnNumber, int secondTileRowNumber, int secondTileColumnNumber, string errorMessage)
        {
            //Arrange 
            var canMove = new CanMove_RowOneSpace();
            var firstTile = new IslandTile() { RowNumber = firstTileRowNumber, ColumnNumber = firstTileColumnNumber, Name = "First tile" };
            var secondTile = new IslandTile() { RowNumber = secondTileRowNumber, ColumnNumber = secondTileColumnNumber, Name = "Second tile" };
            var currentPlayer = new Player();

            //Act 
            var validation = canMove.IsValid(firstTile, secondTile, currentPlayer);

            //Assert
            Assert.AreEqual("Can not move from First tile to Second tile. Can only move one row at a time", validation.ErrorMessage);
        }



    }
}
