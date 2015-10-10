using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ForbiddenIslandMVCTwo.Constants;
using ForbiddenIslandMVCTwo.Factory;

namespace NUnitTest
{
    [TestFixture]
    public class PlayerListFactroyTest
    {

        [Test]
        public void PlayerCountSix_IsValid()
        {
            //Arrange 
            var playerListFactory = new PlayerListFactory();

            //Act 
            var playerList = playerListFactory.Create();

            //Assert
            Assert.AreEqual(playerList.Count, 6);
        }

        [TestCase(PlayerConstants.MESSENGER_NAME, "Grey", PlayerConstants.MESSENGER_ACTION)]
        [TestCase(PlayerConstants.EXPLORER_NAME, "Green", PlayerConstants.EXPLORER_ACTION)]
        [TestCase(PlayerConstants.DIVER_NAME, "Black", PlayerConstants.DIVER_ACTION)]
        [TestCase(PlayerConstants.PILOT_NAME, "Blue", PlayerConstants.PILOT_ACTION)]
        [TestCase(PlayerConstants.NAVIGATOR_NAME, "Yellow", PlayerConstants.NAVIGATOR_ACTION)]
        [TestCase(PlayerConstants.ENGINEER_NAME, "Red", PlayerConstants.ENGINEER_ACTION)]
        public void HasMessenger_IsValid(string playerName, string playerColour, string playerAction)
        {
            //Arrange 
            var playerListFactory = new PlayerListFactory();

            //Act 
            var playerList = playerListFactory.Create();

            var item = playerList.SingleOrDefault(x => x.Name == playerName);

            //Assert
            Assert.AreEqual(item.Colour, playerColour);
            Assert.AreEqual(item.Action, playerAction);
            Assert.AreEqual(item.Name, playerName);
        }
    }
}
