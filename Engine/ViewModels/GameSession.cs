﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.ViewModels
{
     public class GameSession
     {
          public Player CurrentPlayer { get; set; }

          public Location CurrentLocation { get; set; }

          public GameSession()
          {
               //---Player Info---
               CurrentPlayer = new Player();
               CurrentPlayer.Name = "Patrick";
               CurrentPlayer.CharacterClass = "Fighter";
               CurrentPlayer.HitPoints = 10;
               CurrentPlayer.Gold = 1000000;
               CurrentPlayer.ExperiencePoints = 0;
               CurrentPlayer.Level = 1;

               //---Location Info---
               CurrentLocation = new Location();
               CurrentLocation.Name = "Home";
               CurrentLocation.XCoordinate = 0;
               CurrentLocation.YCoordinate = -1;
               CurrentLocation.Description = "This is your House.";
               CurrentLocation.ImageName = "/Engine;component/Images/Locations/Home.gif";
          }
     }
}
