﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForbiddenIslandMVCTwo.Models;
using ForbiddenIslandMVCTwo.Validation.CanMove;
using ForbiddenIslandMVCTwo.Constants;

namespace ForbiddenIslandMVCTwo.Tests.Validation.CanMove
{
    /// <summary>
    /// Summary description for CanMove_ColumnOneSpaceTesst
    /// </summary>
    [TestClass]
    public class CanMove_ColumnOneSpaceTest
    {

        private IslandTile IslandTileAtRowThreeColumnOne()
        {
            return new IslandTile() { RowNumber = 3, ColumnNumber = 1 };
        }

        private IslandTile IslandTileAtRowThreeColumnTwo()
        {
            return new IslandTile() { RowNumber = 3, ColumnNumber = 2 };
        }

        private IslandTile IslandTileAtRowThreeColumnThree()
        {
            return new IslandTile() { RowNumber = 3, ColumnNumber = 3 };
        }

        [TestMethod]
        public void MoveOneRowColumnOneToColumnTwo_IsValid()
        {
            //Arrange 
            var canMove = new CanMove_ColumnOneSpace();
            var firstTile = IslandTileAtRowThreeColumnOne();
            var secondTile = IslandTileAtRowThreeColumnTwo();
            var currentPlayer = new Player();

            //Act 
            var validation = canMove.IsValid(firstTile, secondTile, currentPlayer);

            //Assert
            Assert.AreEqual(validation.IsValid, true);
            Assert.AreEqual(validation.ErrorMessage, null);
        }

        [TestMethod]
        public void MoveOneRowColumnTwoToColumnOne_IsValid()
        {
            //Arrange 
            var canMove = new CanMove_ColumnOneSpace();
            var firstTile = IslandTileAtRowThreeColumnTwo();
            var secondTile = IslandTileAtRowThreeColumnOne();
            var currentPlayer = new Player();

            //Act 
            var validation = canMove.IsValid(firstTile, secondTile, currentPlayer);

            //Assert
            Assert.AreEqual(validation.IsValid, true);
            Assert.AreEqual(validation.ErrorMessage, null);
        }

        [TestMethod]
        public void MoveTwoRowstColumnOneToColumnThree_NotValid()
        {
            //Arrange 
            var canMove = new CanMove_ColumnOneSpace();
            var firstTile = IslandTileAtRowThreeColumnOne();
            var secondTile = IslandTileAtRowThreeColumnThree();
            var currentPlayer = new Player();

            //Act 
            var validation = canMove.IsValid(firstTile, secondTile, currentPlayer);

            //Assert
            Assert.AreEqual(validation.IsValid, false);
            Assert.AreEqual(validation.ErrorMessage, CanMoveErrorConstants.ONLY_MOVE_ONE_COLUMN);
        }

        [TestMethod]
        public void MoveTwoRowstColumnThreeToColumnOne_NotValid()
        {
            //Arrange 
            var canMove = new CanMove_ColumnOneSpace();
            var firstTile = IslandTileAtRowThreeColumnThree();
            var secondTile = IslandTileAtRowThreeColumnOne();
            var currentPlayer = new Player();

            //Act 
            var validation = canMove.IsValid(firstTile, secondTile, currentPlayer);

            //Assert
            Assert.AreEqual(validation.IsValid, false);
            Assert.AreEqual(validation.ErrorMessage, CanMoveErrorConstants.ONLY_MOVE_ONE_COLUMN);
        }


    }
}
