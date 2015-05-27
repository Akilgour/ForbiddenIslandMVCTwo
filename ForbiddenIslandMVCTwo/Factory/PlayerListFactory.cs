﻿using ForbiddenIslandMVCTwo.Constants;
using ForbiddenIslandMVCTwo.Enum.Repository.Enums;
using ForbiddenIslandMVCTwo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ForbiddenIslandMVCTwo.Factory
{
    public class PlayerListFactory
    {
        public List<Player> Create()
        {
            List<Player> playerList = new List<Player>();
            playerList.Add(new Player() { Id = Guid.NewGuid(), Name = PlayerConstants.MESSENGER_NAME, Colour = PlayerColour.Grey.ToString(), Action = PlayerConstants.MESSENGER_ACTION });
            playerList.Add(new Player() { Id = Guid.NewGuid(), Name = PlayerConstants.EXPLORER_NAME, Colour = PlayerColour.Green.ToString(), Action = PlayerConstants.EXPLORER_ACTION });
            playerList.Add(new Player() { Id = Guid.NewGuid(), Name = PlayerConstants.DIVER_NAME, Colour = PlayerColour.Black.ToString(), Action = PlayerConstants.DIVER_ACTION });
            playerList.Add(new Player() { Id = Guid.NewGuid(), Name = PlayerConstants.PILOT_NAME, Colour = PlayerColour.Blue.ToString(), Action = PlayerConstants.PILOT_ACTION });
            playerList.Add(new Player() { Id = Guid.NewGuid(), Name = PlayerConstants.NAVIGATOR_NAME, Colour = PlayerColour.Yellow.ToString(), Action = PlayerConstants.NAVIGATOR_ACTION });
            playerList.Add(new Player() { Id = Guid.NewGuid(), Name = PlayerConstants.ENGINEER_NAME, Colour = PlayerColour.Red.ToString(), Action = PlayerConstants.ENGINEER_ACTION });
            return playerList.OrderBy(x => Guid.NewGuid()).ToList();
        }
    }
}