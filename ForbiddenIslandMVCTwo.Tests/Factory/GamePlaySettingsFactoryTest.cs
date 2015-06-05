using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForbiddenIslandMVCTwo.Enum.Repository.Enums;
using ForbiddenIslandMVCTwo.Factory;
using ForbiddenIslandMVCTwo.Tests.Factory.Mocks;
using ForbiddenIslandMVCTwo.Constants;
using System.Linq;

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
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Normal, new PlayerListFactoryEmpty(), 0, new TreasureDeckFactoryEmpty(), new IslandFactoryEmpty());

            //Assert
            Assert.AreEqual(gamePlaySettings.MoveNumber, 0);
        }

        [TestMethod]
        public void Create_WaterLevelNovice()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Novice, new PlayerListFactoryEmpty(), 0, new TreasureDeckFactoryEmpty(), new IslandFactoryEmpty());

            //Assert
            Assert.AreEqual(gamePlaySettings.WaterLevelMarker, 1);
        }

        [TestMethod]
        public void Create_WaterLevelNormal()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Normal, new PlayerListFactoryEmpty(), 0, new TreasureDeckFactoryEmpty(), new IslandFactoryEmpty());

            //Assert
            Assert.AreEqual(gamePlaySettings.WaterLevelMarker, 2);
        }

        [TestMethod]
        public void Create_WaterLevelElite()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Elite, new PlayerListFactoryEmpty(), 0, new TreasureDeckFactoryEmpty(), new IslandFactoryEmpty());

            //Assert
            Assert.AreEqual(gamePlaySettings.WaterLevelMarker, 3);
        }

        [TestMethod]
        public void Create_WaterLevelLegendary()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryEmpty(), 0, new TreasureDeckFactoryEmpty(), new IslandFactoryEmpty());

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
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryEmpty(), 1, new TreasureDeckFactoryEmpty(), new IslandFactoryEmpty());

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
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryEmpty(), 5, new TreasureDeckFactoryEmpty(), new IslandFactoryEmpty());

            //Assert
            Assert.Fail(); // If it gets to this line, no exception was thrown
        }

        [TestMethod]
        public void Create_SetZeroPlayers()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 0, new TreasureDeckFactoryEmpty(), new IslandFactoryEmpty());

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
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 1, new TreasureDeckFactoryEmpty(), new IslandFactoryEmpty());

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
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 2, new TreasureDeckFactoryEmpty(), new IslandFactoryEmpty());

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
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 3, new TreasureDeckFactoryEmpty(), new IslandFactoryEmpty());

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
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 4, new TreasureDeckFactoryEmpty(), new IslandFactoryEmpty());

            //Assert
            Assert.AreNotEqual(gamePlaySettings.FirstMovePlayer, null);
            Assert.AreNotEqual(gamePlaySettings.SecondMovePlayer, null);
            Assert.AreNotEqual(gamePlaySettings.ThirdMovePlayer, null);
            Assert.AreNotEqual(gamePlaySettings.FourthMovePlayer, null);
        }

        [TestMethod]
        public void DrawDeckNotNull()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 4, new TreasureDeckFactoryNine(), new IslandFactoryEmpty());

            var drawDeck = gamePlaySettings.DrawDeck;

            //Assert
            Assert.AreNotEqual(drawDeck, null);
        }

        [TestMethod]
        public void DrawDeckHasCorrectCount()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 4, new TreasureDeckFactoryNine(), new IslandFactoryEmpty());

            var drawDeck = gamePlaySettings.DrawDeck;

            //Assert
            Assert.AreEqual(drawDeck.Count, 9);
        }


        [TestMethod]
        public void Create_SetPlayerOneWithCardsNineCards()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 4, new TreasureDeckFactoryNine(), new IslandFactoryEmpty());
            var playerCards = gamePlaySettings.DrawDeck.Where(x => x.PlayerId == gamePlaySettings.FirstMovePlayer.Id);

            //Assert
            Assert.AreEqual(playerCards.First().Name, CardConstants.SANDBAG_NAME);
            Assert.AreEqual(playerCards.Last().Name, CardConstants.HELICOPTERLIFT_NAME);       
        }

        [TestMethod]
        public void Create_SetPlayerTwoWithCardsNineCards()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 4, new TreasureDeckFactoryNine(), new IslandFactoryEmpty());
            var playerCards = gamePlaySettings.DrawDeck.Where(x => x.PlayerId == gamePlaySettings.SecondMovePlayer.Id);

           var foo = playerCards.ToList();

            //Assert
            Assert.AreEqual(playerCards.First().Name, CardConstants.OCEANS_CHALICE_NAME);
            Assert.AreEqual(playerCards.Last().Name, CardConstants.CRYSTAL_OF_FIRE_NAME);
        }

        [TestMethod]
        public void Create_SetPlayerThreeWithCardsNineCards()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 4, new TreasureDeckFactoryNine(), new IslandFactoryEmpty());
            var playerCards = gamePlaySettings.DrawDeck.Where(x => x.PlayerId == gamePlaySettings.ThirdMovePlayer.Id);

            //Assert
            Assert.AreEqual(playerCards.First().Name, CardConstants.STATUE_OF_THE_WIND_NAME);
            Assert.AreEqual(playerCards.Last().Name, CardConstants.EARTH_STONE_NAME);
        }

        [TestMethod]
        public void Create_SetPlayerFourWithCardsNineCards()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 4, new TreasureDeckFactoryNine(), new IslandFactoryEmpty());
            var playerCards = gamePlaySettings.DrawDeck.Where(x => x.PlayerId == gamePlaySettings.FourthMovePlayer.Id);

            //Assert
            Assert.AreEqual(playerCards.First().Name, CardConstants.EARTH_STONE_NAME);
            Assert.AreEqual(playerCards.Last().Name, CardConstants.EARTH_STONE_NAME);
        }

        [TestMethod]
        public void Create_DiscardDeckIdNotEmpty()
        {
            //Arrange 
            var gamePlaySettingsFactory = new GamePlaySettingsFactory();

            //Act 
            var gamePlaySettings = gamePlaySettingsFactory.Create(DifficultyLevel.Legendary, new PlayerListFactoryFour(), 4, new TreasureDeckFactoryNine(), new IslandFactoryEmpty());

            //Assert
            Assert.AreNotEqual(gamePlaySettings.DiscardDeckId,  Guid.Empty);
            Assert.AreNotEqual(gamePlaySettings.DiscardDeckId, null);
        }
    }
}
