﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ForbiddenIslandMVCTwo.Constants;
using ForbiddenIslandMVCTwo.Factory;
using ForbiddenIslandMVCTwo.Enum.Repository.Enums;
using System.Linq;
using ForbiddenIslandMVCTwo.Models;
using System.Collections.Generic;

namespace ForbiddenIslandMVCTwo.Tests.Factory
{
    [TestClass]
    public class TreasureDeckFactoryTest
    {
        [TestMethod]
        public void CreateTreasureDeck_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());

            //Assert
            Assert.IsInstanceOfType(deckList, typeof(List<TreasureCard>));
        }

        [TestMethod]
        public void HasSandbag_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var hasCard = deckList.Any(x => x.TreasureCardType == TreasureCardType.SandBags.ToString());

            //Assert
            Assert.IsTrue(hasCard);
        }

        [TestMethod]
        public void SandbagValues_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var card = deckList.FirstOrDefault(x => x.TreasureCardType == TreasureCardType.SandBags.ToString());

            //Assert
            Assert.AreNotEqual(card.Id, Guid.Empty);
            Assert.AreEqual(card.Name, CardConstants.SANDBAG_NAME);
            Assert.AreEqual(card.Description, CardConstants.SANDBAG_DESCRIPTION);
            Assert.AreEqual(card.Action, CardConstants.SANDBAG_ACTION);
            Assert.AreEqual(card.TreasureCardType, TreasureCardType.SandBags.ToString());
        }

        [TestMethod]
        public void SandbagCountIsTwo_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var cardCount = deckList.Count(x => x.TreasureCardType == TreasureCardType.SandBags.ToString());

            //Assert
            Assert.AreEqual(cardCount, 2);
        }

        [TestMethod]
        public void HasHelicopterList_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var hasCard = deckList.Any(x => x.TreasureCardType == TreasureCardType.HelicopterLift.ToString());

            //Assert
            Assert.IsTrue(hasCard);
        }

        [TestMethod]
        public void HelicopterListValues_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var card = deckList.FirstOrDefault(x => x.TreasureCardType == TreasureCardType.HelicopterLift.ToString());

            //Assert
            Assert.AreNotEqual(card.Id, Guid.Empty);
            Assert.AreEqual(card.Name, CardConstants.HELICOPTERLIFT_NAME);
            Assert.AreEqual(card.Description, CardConstants.HELICOPTERLIFT_DESCRIPTION);
            Assert.AreEqual(card.Action, CardConstants.HELICOPTERLIFT_ACTION);
            Assert.AreEqual(card.TreasureCardType, TreasureCardType.HelicopterLift.ToString());
        }

        [TestMethod]
        public void HelicopterListCountIsThree_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var cardCount = deckList.Count(x => x.TreasureCardType == TreasureCardType.HelicopterLift.ToString());

            //Assert
            Assert.AreEqual(cardCount, 3);
        }

        [TestMethod]
        public void HasWaterRises_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var hasCard = deckList.Any(x => x.TreasureCardType == TreasureCardType.WaterRises.ToString());

            //Assert
            Assert.IsTrue(hasCard);
        }

        [TestMethod]
        public void WaterRisesValues_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var card = deckList.FirstOrDefault(x => x.TreasureCardType == TreasureCardType.WaterRises.ToString());

            //Assert
            Assert.AreNotEqual(card.Id, Guid.Empty);
            Assert.AreEqual(card.Name, CardConstants.WATERRISE_NAME);
            Assert.AreEqual(card.Description, CardConstants.WATERRISE_DESCRIPTION);
            Assert.AreEqual(card.Action, CardConstants.WATERRISE_ACTION);
            Assert.AreEqual(card.TreasureCardType, TreasureCardType.WaterRises.ToString());
        }

        [TestMethod]
        public void WaterRisesCountIsThree_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var cardCount = deckList.Count(x => x.TreasureCardType == TreasureCardType.WaterRises.ToString());

            //Assert
            Assert.AreEqual(cardCount, 3);
        }

        [TestMethod]
        public void HasOceansChalice_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var hasCard = deckList.Any(x => x.TreasureCardType == TreasureCardType.OceansChalice.ToString());

            //Assert
            Assert.IsTrue(hasCard);
        }

        [TestMethod]
        public void OceansChaliceValues_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var card = deckList.FirstOrDefault(x => x.TreasureCardType == TreasureCardType.OceansChalice.ToString());

            //Assert
            Assert.AreNotEqual(card.Id, Guid.Empty);
            Assert.AreEqual(card.Name, CardConstants.OCEANS_CHALICE_NAME);
            Assert.AreEqual(card.Description, "");
            Assert.AreEqual(card.Action, "");
            Assert.AreEqual(card.TreasureCardType, TreasureCardType.OceansChalice.ToString());
        }

        [TestMethod]
        public void OceansChaliceCountIsFive_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var cardCount = deckList.Count(x => x.TreasureCardType == TreasureCardType.OceansChalice.ToString());

            //Assert
            Assert.AreEqual(cardCount, 5);
        }

        [TestMethod]
        public void HasCrystalOfFire_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var hasCard = deckList.Any(x => x.TreasureCardType == TreasureCardType.CrystalOfFire.ToString());

            //Assert
            Assert.IsTrue(hasCard);
        }

        [TestMethod]
        public void CrystalOfFireValues_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var card = deckList.FirstOrDefault(x => x.TreasureCardType == TreasureCardType.CrystalOfFire.ToString());

            //Assert
            Assert.AreNotEqual(card.Id, Guid.Empty);
            Assert.AreEqual(card.Name, CardConstants.CRYSTAL_OF_FIRE_NAME.ToString());
            Assert.AreEqual(card.Description, "");
            Assert.AreEqual(card.Action, "");
            Assert.AreEqual(card.TreasureCardType, TreasureCardType.CrystalOfFire.ToString());
        }

        [TestMethod]
        public void CrystalOfFireCountIsFive_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var cardCount = deckList.Count(x => x.TreasureCardType == TreasureCardType.CrystalOfFire.ToString());

            //Assert
            Assert.AreEqual(cardCount, 5);
        }

        [TestMethod]
        public void HasStatueOfTheWind_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var hasCard = deckList.Any(x => x.TreasureCardType == TreasureCardType.StatueOfTheWind.ToString());

            //Assert
            Assert.IsTrue(hasCard);
        }

        [TestMethod]
        public void StatueOfTheWindValues_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var card = deckList.FirstOrDefault(x => x.TreasureCardType == TreasureCardType.StatueOfTheWind.ToString());

            //Assert
            Assert.AreNotEqual(card.Id, Guid.Empty);
            Assert.AreEqual(card.Name, CardConstants.STATUE_OF_THE_WIND_NAME);
            Assert.AreEqual(card.Description, "");
            Assert.AreEqual(card.Action, "");
            Assert.AreEqual(card.TreasureCardType, TreasureCardType.StatueOfTheWind.ToString());
        }

        [TestMethod]
        public void StatueOfTheWindCountIsFive_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var cardCount = deckList.Count(x => x.TreasureCardType == TreasureCardType.StatueOfTheWind.ToString());

            //Assert
            Assert.AreEqual(cardCount, 5);
        }


        [TestMethod]
        public void HasEarthStone_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var hasCard = deckList.Any(x => x.TreasureCardType == TreasureCardType.EarthStone.ToString());

            //Assert
            Assert.IsTrue(hasCard);
        }

        [TestMethod]
        public void EarthStoneValues_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var card = deckList.FirstOrDefault(x => x.TreasureCardType == TreasureCardType.EarthStone.ToString());

            //Assert
            Assert.AreNotEqual(card.Id, Guid.Empty);
            Assert.AreEqual(card.Name, CardConstants.EARTH_STONE_NAME);
            Assert.AreEqual(card.Description, "");
            Assert.AreEqual(card.Action, "");
            Assert.AreEqual(card.TreasureCardType, TreasureCardType.EarthStone.ToString());
        }

        [TestMethod]
        public void EarthStoneCountIsFive_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());
            var cardCount = deckList.Count(x => x.TreasureCardType == TreasureCardType.EarthStone.ToString());

            //Assert
            Assert.AreEqual(cardCount, 5);
        }


        [TestMethod]
        public void Are28TreasureCards_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());


            //Assert
            Assert.AreEqual(28, deckList.Count);
        }

        /// <summary>
        /// Okay this test know the last 5 created are EarthStone cards, but since of the randomse they should not be
        /// </summary>
        [TestMethod]
        public void Last5NotEarthStoneTreasureCards_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();

            //Act 
            var deckList = factory.Create(Guid.NewGuid());


            //Assert
            var cardOne = deckList.ElementAt(27).Name == CardConstants.EARTH_STONE_NAME;
            var cardTwo = deckList.ElementAt(26).Name == CardConstants.EARTH_STONE_NAME;
            var cardThree = deckList.ElementAt(25).Name == CardConstants.EARTH_STONE_NAME;
            var cardFour = deckList.ElementAt(24).Name == CardConstants.EARTH_STONE_NAME;
            var cardFive = deckList.ElementAt(23).Name == CardConstants.EARTH_STONE_NAME;

            var isEarthStone = (cardOne && cardTwo && cardThree && cardFour && cardFive);
            Assert.IsFalse(isEarthStone);

        }

        [TestMethod]
        public void AllNewCardsHaveDrawDeckId_IsValid()
        {
            //Arrange 
            var factory = new TreasureDeckFactory();
            var drawDeckId = Guid.NewGuid();

            //Act 
            var deckList = factory.Create(drawDeckId);


            //Assert
            foreach (var item in deckList)
            {
                Assert.AreEqual(item.DrawDeckId, drawDeckId);
            }
        }
    }
}

