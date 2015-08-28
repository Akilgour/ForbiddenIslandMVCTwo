using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForbiddenIslandMVCTwo.Models;
using ForbiddenIslandMVCTwo.Helpers;

namespace ForbiddenIslandMVCTwo.Tests.Helpers.GamePlaySettingHelperTest
{
    /// <summary>
    /// Summary description for NumberOfPlayers_Test
    /// </summary>
    [TestClass]
    public class NumberOfPlayersTest
    {

        [TestMethod]
        public void HasZeroPlayers()
        {
            //Arrange 
            var gamePlaySetting = new GamePlaySetting();

            gamePlaySetting.FirstMovePlayer = null;
            gamePlaySetting.SecondMovePlayer = null;
            gamePlaySetting.ThirdMovePlayer = null;
            gamePlaySetting.FourthMovePlayer = null;

            //Act 
            var numberOfPlayers = GamePlaySettingHelper.NumberOfPlayers(gamePlaySetting);

            //Assert
            Assert.AreEqual(numberOfPlayers, 0);
        }

        [TestMethod]
        public void HasOnePlayers()
        {
            //Arrange 
            var gamePlaySetting = new GamePlaySetting();

            gamePlaySetting.FirstMovePlayer = new Player();
            gamePlaySetting.SecondMovePlayer = null;
            gamePlaySetting.ThirdMovePlayer = null;
            gamePlaySetting.FourthMovePlayer = null;

            //Act 
            var numberOfPlayers = GamePlaySettingHelper.NumberOfPlayers(gamePlaySetting);

            //Assert
            Assert.AreEqual(numberOfPlayers, 1);
        }

        [TestMethod]
        public void HasTwoPlayers()
        {
            //Arrange 
            var gamePlaySetting = new GamePlaySetting();

            gamePlaySetting.FirstMovePlayer = new Player();
            gamePlaySetting.SecondMovePlayer = new Player();
            gamePlaySetting.ThirdMovePlayer = null;
            gamePlaySetting.FourthMovePlayer = null;

            //Act 
            var numberOfPlayers = GamePlaySettingHelper.NumberOfPlayers(gamePlaySetting);

            //Assert
            Assert.AreEqual(numberOfPlayers, 2);
        }

        [TestMethod]
        public void HasThreePlayers()
        {
            //Arrange 
            var gamePlaySetting = new GamePlaySetting();

            gamePlaySetting.FirstMovePlayer = new Player();
            gamePlaySetting.SecondMovePlayer = new Player();
            gamePlaySetting.ThirdMovePlayer = new Player();
            gamePlaySetting.FourthMovePlayer = null;

            //Act 
            var numberOfPlayers = GamePlaySettingHelper.NumberOfPlayers(gamePlaySetting);

            //Assert
            Assert.AreEqual(numberOfPlayers, 3);
        }

        [TestMethod]
        public void HasFourPlayers()
        {
            //Arrange 
            var gamePlaySetting = new GamePlaySetting();

            gamePlaySetting.FirstMovePlayer = new Player();
            gamePlaySetting.SecondMovePlayer = new Player();
            gamePlaySetting.ThirdMovePlayer = new Player();
            gamePlaySetting.FourthMovePlayer = new Player();

            //Act 
            var numberOfPlayers = GamePlaySettingHelper.NumberOfPlayers(gamePlaySetting);

            //Assert
            Assert.AreEqual(numberOfPlayers, 4);
        }
    }
}
