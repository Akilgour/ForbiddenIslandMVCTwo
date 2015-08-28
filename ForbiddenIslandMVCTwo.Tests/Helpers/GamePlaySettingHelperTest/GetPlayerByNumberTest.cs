using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForbiddenIslandMVCTwo.Models;
using ForbiddenIslandMVCTwo.Helpers;

namespace ForbiddenIslandMVCTwo.Tests.Helpers.GamePlaySettingHelperTest
{
    /// <summary>
    /// Summary description for GetPlayerByNumberTest
    /// </summary>
    [TestClass]
    public class GetPlayerByNumberTest
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
        [ExpectedException(typeof(NotImplementedException))]
        public void GetPlayerZero()
        {
            //Arrange 
            // See Initialize
            int playerNumber = 0;

            //Act 
            var player = GamePlaySettingHelper.GetPlayerByNumber(gamePlaySetting, playerNumber);

        }

        [TestMethod]
        public void GetPlayerOne()
        {
            //Arrange 
            // See Initialize
            int playerNumber = 1;

            //Act 
            var player = GamePlaySettingHelper.GetPlayerByNumber(gamePlaySetting, playerNumber);

            //Assert
            Assert.AreEqual("PlayerOne", player.Name);
        }

        [TestMethod]
        public void GetPlayerTwo()
        {
            //Arrange 
            // See Initialize
            int playerNumber = 2;

            //Act 
            var player = GamePlaySettingHelper.GetPlayerByNumber(gamePlaySetting, playerNumber);

            //Assert
            Assert.AreEqual("PlayerTwo", player.Name);
        }

        [TestMethod]
        public void GetPlayerThree()
        {
            //Arrange 
            // See Initialize
            int playerNumber = 3;

            //Act 
            var player = GamePlaySettingHelper.GetPlayerByNumber(gamePlaySetting, playerNumber);

            //Assert
            Assert.AreEqual("PlayerThree", player.Name);
        }

        [TestMethod]
        public void GetPlayerFour()
        {
            //Arrange 
            // See Initialize
            int playerNumber = 4;

            //Act 
            var player = GamePlaySettingHelper.GetPlayerByNumber(gamePlaySetting, playerNumber);

            //Assert
            Assert.AreEqual("PlayerFour", player.Name);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void GetPlayerFive()
        {
            //Arrange 
            // See Initialize
            int playerNumber = 5;

            //Act 
            var player = GamePlaySettingHelper.GetPlayerByNumber(gamePlaySetting, playerNumber);

        }

    }
}
