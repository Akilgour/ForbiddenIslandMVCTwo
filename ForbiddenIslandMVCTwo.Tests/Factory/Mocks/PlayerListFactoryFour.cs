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
    public class PlayerListFactoryFour : IPlayerListFactory
    {
        public List<Models.Player> Create()
        {
            List<Player> playerList = new List<Player>();
            playerList.Add(new Player() { Id = Guid.NewGuid(), Name = PlayerConstants.MESSENGER_NAME, Colour = PlayerColour.Grey.ToString(), Action = PlayerConstants.MESSENGER_ACTION });
            playerList.Add(new Player() { Id = Guid.NewGuid(), Name = PlayerConstants.EXPLORER_NAME, Colour = PlayerColour.Green.ToString(), Action = PlayerConstants.EXPLORER_ACTION });
            playerList.Add(new Player() { Id = Guid.NewGuid(), Name = PlayerConstants.DIVER_NAME, Colour = PlayerColour.Black.ToString(), Action = PlayerConstants.DIVER_ACTION });
            playerList.Add(new Player() { Id = Guid.NewGuid(), Name = PlayerConstants.PILOT_NAME, Colour = PlayerColour.Blue.ToString(), Action = PlayerConstants.PILOT_ACTION });
           
            return playerList;
        }
    }
}
