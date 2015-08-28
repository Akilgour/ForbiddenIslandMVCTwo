using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForbiddenIslandMVCTwo.Models;
using ForbiddenIslandMVCTwo.Helpers;

namespace ForbiddenIslandMVCTwo.Tests.Helpers.GamePlaySettingHelperTest
{
    /// <summary>
    /// Summary description for CurrentPlayerTest_OnePlayers
    /// </summary>
    [TestClass]
    public class CurrentPlayerTest_OnePlayers
    {

        private GamePlaySetting gamePlaySetting;

        [TestInitialize()]
        public void Initialize()
        {
            gamePlaySetting = new GamePlaySetting();

            gamePlaySetting.FirstMovePlayer = new Player() { Name = "PlayerOne" };
            gamePlaySetting.SecondMovePlayer = null;
            gamePlaySetting.ThirdMovePlayer = null;
            gamePlaySetting.FourthMovePlayer = null;
        }

        [TestMethod]
        public void MoveOne()
        {
            //Arrange 
            // See Initialize
            gamePlaySetting.MoveNumber = 1;

            //Act 
            var player = GamePlaySettingHelper.CurrentPlayer(gamePlaySetting);

            //Assert
            Assert.AreEqual("PlayerOne", player.Name);
        }

        [TestMethod]
        public void MoveTwo()
        {
            //Arrange 
            // See Initialize
            gamePlaySetting.MoveNumber = 2;

            //Act 
            var player = GamePlaySettingHelper.CurrentPlayer(gamePlaySetting);

            //Assert
            Assert.AreEqual("PlayerOne", player.Name);
        }

        [TestMethod]
        public void MoveThree()
        {
            //Arrange 
            // See Initialize
            gamePlaySetting.MoveNumber = 3;

            //Act 
            var player = GamePlaySettingHelper.CurrentPlayer(gamePlaySetting);

            //Assert
            Assert.AreEqual("PlayerOne", player.Name);
        }

        [TestMethod]
        public void MoveFour()
        {
            //Arrange 
            // See Initialize
            gamePlaySetting.MoveNumber = 4;

            //Act 
            var player = GamePlaySettingHelper.CurrentPlayer(gamePlaySetting);

            //Assert
            Assert.AreEqual("PlayerOne", player.Name);
        }

        [TestMethod]
        public void MoveFive()
        {
            //Arrange 
            // See Initialize
            gamePlaySetting.MoveNumber = 5;

            //Act 
            var player = GamePlaySettingHelper.CurrentPlayer(gamePlaySetting);

            //Assert
            Assert.AreEqual("PlayerOne", player.Name);
        }

        [TestMethod]
        public void MoveSix()
        {
            //Arrange 
            // See Initialize
            gamePlaySetting.MoveNumber = 6;

            //Act 
            var player = GamePlaySettingHelper.CurrentPlayer(gamePlaySetting);

            //Assert
            Assert.AreEqual("PlayerOne", player.Name);
        }

        [TestMethod]
        public void MoveSeven()
        {
            //Arrange 
            // See Initialize
            gamePlaySetting.MoveNumber = 7;

            //Act 
            var player = GamePlaySettingHelper.CurrentPlayer(gamePlaySetting);

            //Assert
            Assert.AreEqual("PlayerOne", player.Name);
        }

        [TestMethod]
        public void MoveEight()
        {
            //Arrange 
            // See Initialize
            gamePlaySetting.MoveNumber = 8;

            //Act 
            var player = GamePlaySettingHelper.CurrentPlayer(gamePlaySetting);

            //Assert
            Assert.AreEqual("PlayerOne", player.Name);
        }


        [TestMethod]
        public void MoveTen()
        {
            //Arrange 
            // See Initialize
            gamePlaySetting.MoveNumber = 10;

            //Act 
            var player = GamePlaySettingHelper.CurrentPlayer(gamePlaySetting);

            //Assert
            Assert.AreEqual("PlayerOne", player.Name);
        }

        [TestMethod]
        public void MoveTwelve()
        {
            //Arrange 
            // See Initialize
            gamePlaySetting.MoveNumber = 12;

            //Act 
            var player = GamePlaySettingHelper.CurrentPlayer(gamePlaySetting);

            //Assert
            Assert.AreEqual("PlayerOne", player.Name);
        }

        [TestMethod]
        public void MoveSixteen()
        {
            //Arrange 
            // See Initialize
            gamePlaySetting.MoveNumber = 16;

            //Act 
            var player = GamePlaySettingHelper.CurrentPlayer(gamePlaySetting);

            //Assert
            Assert.AreEqual("PlayerOne", player.Name);
        }
    }
}