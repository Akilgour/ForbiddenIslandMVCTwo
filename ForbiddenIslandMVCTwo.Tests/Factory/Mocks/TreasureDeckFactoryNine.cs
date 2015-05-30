using ForbiddenIslandMVCTwo.Constants;
using ForbiddenIslandMVCTwo.Enum.Repository.Enums;
using ForbiddenIslandMVCTwo.Factory;
using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenIslandMVCTwo.Tests.Factory.Mocks
{
    class TreasureDeckFactoryNine : ITreasureDeckFactory
    {
        public List<TreasureCard> Create(Guid DrawDeckId)
        {
            var treasureCardList = new List<TreasureCard>();

           treasureCardList.Add(CreateSandBagCard()); // 1
           treasureCardList.Add(CreateHelicopterLiftCard());// 2
           treasureCardList.Add(CreateWaterRiseCard());// 3
           treasureCardList.Add(CreateOceansChaliceCard());// 4
           treasureCardList.Add(CreateCrystalOfFireCard());// 5
           treasureCardList.Add(CreateStatueOfTheWindCard());// 6
           treasureCardList.Add(CreateEarthStoneCard());// 7
           treasureCardList.Add(CreateEarthStoneCard());// 8
           treasureCardList.Add(CreateEarthStoneCard());// 9

           return treasureCardList;
        }

        private TreasureCard CreateSandBagCard()
        {
            return new TreasureCard() { Id = Guid.NewGuid(), Name = CardConstants.SANDBAG_NAME, Description = CardConstants.SANDBAG_DESCRIPTION, Action = CardConstants.SANDBAG_ACTION, TreasureCardType = TreasureCardType.SandBags.ToString(), DeckTheCardIsIn = TeasureCardDeckId.DrawDeck.ToString() };
        }

        private TreasureCard CreateHelicopterLiftCard()
        {
            return new TreasureCard() { Id = Guid.NewGuid(), Name = CardConstants.HELICOPTERLIFT_NAME, Description = CardConstants.HELICOPTERLIFT_DESCRIPTION, Action = CardConstants.HELICOPTERLIFT_ACTION, TreasureCardType = TreasureCardType.HelicopterLift.ToString(), DeckTheCardIsIn = TeasureCardDeckId.DrawDeck.ToString() };
        }

        private TreasureCard CreateWaterRiseCard()
        {
            return new TreasureCard() { Id = Guid.NewGuid(), Name = CardConstants.WATERRISE_NAME, Description = CardConstants.WATERRISE_DESCRIPTION, Action = CardConstants.WATERRISE_ACTION, TreasureCardType = TreasureCardType.WaterRises.ToString(), DeckTheCardIsIn = TeasureCardDeckId.DrawDeck.ToString() };
        }

        private TreasureCard CreateOceansChaliceCard()
        {
            return new TreasureCard() { Id = Guid.NewGuid(), Name = CardConstants.OCEANS_CHALICE_NAME, Description = "", Action = "", TreasureCardType = TreasureCardType.OceansChalice.ToString(), DeckTheCardIsIn = TeasureCardDeckId.DrawDeck.ToString() };
        }

        private TreasureCard CreateCrystalOfFireCard()
        {
            return new TreasureCard() { Id = Guid.NewGuid(), Name = CardConstants.CRYSTAL_OF_FIRE_NAME, Description = "", Action = "", TreasureCardType = TreasureCardType.CrystalOfFire.ToString(), DeckTheCardIsIn = TeasureCardDeckId.DrawDeck.ToString() };
        }

        private TreasureCard CreateStatueOfTheWindCard()
        {
            return new TreasureCard() { Id = Guid.NewGuid(), Name = CardConstants.STATUE_OF_THE_WIND_NAME, Description = "", Action = "", TreasureCardType = TreasureCardType.StatueOfTheWind.ToString(), DeckTheCardIsIn = TeasureCardDeckId.DrawDeck.ToString() };
        }

        private TreasureCard CreateEarthStoneCard()
        {
            return new TreasureCard() { Id = Guid.NewGuid(), Name = CardConstants.EARTH_STONE_NAME, Description = "", Action = "", TreasureCardType = TreasureCardType.EarthStone.ToString(), DeckTheCardIsIn = TeasureCardDeckId.DrawDeck.ToString() };
        }
    }
}
