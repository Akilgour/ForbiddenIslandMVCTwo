using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForbiddenIslandMVCTwo.Enum.Repository.Enums;
using ForbiddenIslandMVCTwo.Factory;

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
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Normal);

            //Assert
            Assert.AreEqual(gamePlaySettings.MoveNumber, 0);
        }

        [TestMethod]
        public void Create_WaterLevelNovice()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Novice);

            //Assert
            Assert.AreEqual(gamePlaySettings.WaterLevelMarker, 1);
        }

        [TestMethod]
        public void Create_WaterLevelNormal()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Normal);

            //Assert
            Assert.AreEqual(gamePlaySettings.WaterLevelMarker, 2);
        }

        [TestMethod]
        public void Create_WaterLevelElite()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Elite);

            //Assert
            Assert.AreEqual(gamePlaySettings.WaterLevelMarker, 3);
        }

        [TestMethod]
        public void Create_WaterLevelLegendary()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary);

            //Assert
            Assert.AreEqual(gamePlaySettings.WaterLevelMarker, 4);
        }
    }
}
