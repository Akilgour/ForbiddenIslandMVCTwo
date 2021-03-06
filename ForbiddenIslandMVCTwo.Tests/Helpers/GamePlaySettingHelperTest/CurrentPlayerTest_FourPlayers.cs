﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForbiddenIslandMVCTwo.Models;
using ForbiddenIslandMVCTwo.Helpers;

namespace ForbiddenIslandMVCTwo.Tests.Helpers.GamePlaySettingHelperTest
{
    /// <summary>
    /// Summary description for CurrentPlayerTest
    /// </summary>
    [TestClass]
    public class CurrentPlayerTest_FourPlayers
    {
        private GamePlaySetting gamePlaySetting;

        [TestInitialize()]
        public void Initialize()
        {
            gamePlaySetting = new GamePlaySetting();

            gamePlaySetting.FirstMovePlayer = new Player() { Name = "PlayerOne" };
            gamePlaySetting.SecondMovePlayer = new Player() { Name = "PlayerTwo" };
            gamePlaySetting.ThirdMovePlayer = new Player() { Name = "PlayerThree" };
            gamePlaySetting.FourthMovePlayer = new Player() { Name = "PlayerFour" };
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
            Assert.AreEqual("PlayerTwo", player.Name);
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
            Assert.AreEqual("PlayerThree", player.Name);
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
            Assert.AreEqual("PlayerFour", player.Name);
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
            Assert.AreEqual("PlayerTwo", player.Name);
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
            Assert.AreEqual("PlayerThree", player.Name);
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
            Assert.AreEqual("PlayerFour", player.Name);
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
            Assert.AreEqual("PlayerTwo", player.Name);
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
            Assert.AreEqual("PlayerFour", player.Name);
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
            Assert.AreEqual("PlayerFour", player.Name);
        }
    }
}
