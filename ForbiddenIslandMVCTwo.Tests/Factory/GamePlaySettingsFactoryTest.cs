using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForbiddenIslandMVCTwo.Enum.Repository.Enums;
using ForbiddenIslandMVCTwo.Factory;
using ForbiddenIslandMVCTwo.Tests.Factory.Mocks;
using ForbiddenIslandMVCTwo.Constants;

namespace ForbiddenIslandMVCTwo.Tests.Factory
{
    [TestClass]
    public class GamePlaySettingsFactoryTest
    {
   
        [TestMethod]
        public void Create_MoveNumberZero()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Normal,new PlayerListFactoryEmpty(),0);

            //Assert
            Assert.AreEqual(gamePlaySettings.MoveNumber, 0);
        }

        [TestMethod]
        public void Create_WaterLevelNovice()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Novice, new PlayerListFactoryEmpty(), 0);

            //Assert
            Assert.AreEqual(gamePlaySettings.WaterLevelMarker, 1);
        }

        [TestMethod]
        public void Create_WaterLevelNormal()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Normal, new PlayerListFactoryEmpty(), 0);

            //Assert
            Assert.AreEqual(gamePlaySettings.WaterLevelMarker, 2);
        }

        [TestMethod]
        public void Create_WaterLevelElite()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Elite, new PlayerListFactoryEmpty(), 0);

            //Assert
            Assert.AreEqual(gamePlaySettings.WaterLevelMarker, 3);
        }

        [TestMethod]
        public void Create_WaterLevelLegendary()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryEmpty(), 0);

            //Assert
            Assert.AreEqual(gamePlaySettings.WaterLevelMarker, 4);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), PlayerConstants.PLAYER_COUNT_CANT_BE_LONGER_THAN_PLAYER_LIST)]
        public void Create_MorePlayerCountThanInPlayerList()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryEmpty(), 1);

            //Assert
            Assert.Fail(); // If it gets to this line, no exception was thrown
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), PlayerConstants.CANT_BE_MORE_THAN_FOUR)]
        public void Create_MorePlayersThanFour()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryEmpty(), 5);

            //Assert
            Assert.Fail(); // If it gets to this line, no exception was thrown
        }

        [TestMethod]
        public void Create_SetZeroPlayers()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 0);

            //Assert
            Assert.AreEqual(gamePlaySettings.FirstMovePlayer, null );
            Assert.AreEqual(gamePlaySettings.SecondMovePlayer, null);
            Assert.AreEqual(gamePlaySettings.ThirdMovePlayer, null);
            Assert.AreEqual(gamePlaySettings.FourthMovePlayer, null);
        }


        [TestMethod]
        public void Create_SetOnePlayers()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 1);

            //Assert
            Assert.AreNotEqual(gamePlaySettings.FirstMovePlayer, null);
            Assert.AreEqual(gamePlaySettings.SecondMovePlayer, null);
            Assert.AreEqual(gamePlaySettings.ThirdMovePlayer, null);
            Assert.AreEqual(gamePlaySettings.FourthMovePlayer, null);
        }

        [TestMethod]
        public void Create_SetTwoPlayers()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 2);

            //Assert
            Assert.AreNotEqual(gamePlaySettings.FirstMovePlayer, null);
            Assert.AreNotEqual(gamePlaySettings.SecondMovePlayer, null);
            Assert.AreEqual(gamePlaySettings.ThirdMovePlayer, null);
            Assert.AreEqual(gamePlaySettings.FourthMovePlayer, null);
        }

        [TestMethod]
        public void Create_SetThreePlayers()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 3);

            //Assert
            Assert.AreNotEqual(gamePlaySettings.FirstMovePlayer, null);
            Assert.AreNotEqual(gamePlaySettings.SecondMovePlayer, null);
            Assert.AreNotEqual(gamePlaySettings.ThirdMovePlayer, null);
            Assert.AreEqual(gamePlaySettings.FourthMovePlayer, null);
        }

        [TestMethod]
        public void Create_SetFourPlayers()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 4);

            //Assert
            Assert.AreNotEqual(gamePlaySettings.FirstMovePlayer, null);
            Assert.AreNotEqual(gamePlaySettings.SecondMovePlayer, null);
            Assert.AreNotEqual(gamePlaySettings.ThirdMovePlayer, null);
            Assert.AreNotEqual(gamePlaySettings.FourthMovePlayer, null);
        }
    }
}
