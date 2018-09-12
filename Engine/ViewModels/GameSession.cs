using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;
using Engine.Factories;
using System.ComponentModel;

namespace Engine.ViewModels
{
     public class GameSession : BaseNotificationClass
     {

          private Location _currentLocation;
          public World CurrentWorld { get; set; }

          public Player CurrentPlayer { get; set; }

          public Location CurrentLocation
          {
               get { return _currentLocation; }
               set
               {
                    _currentLocation = value;
                    OnPropertyChanged(nameof(CurrentLocation));
                    OnPropertyChanged(nameof(HasLocationToNorth));
                    OnPropertyChanged(nameof(HasLocationToSouth));
                    OnPropertyChanged(nameof(HasLocationToEast));
                    OnPropertyChanged(nameof(HasLocationToWest));
               }
          }

          public bool HasLocationToNorth
          {
               get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null; }
          }

          public bool HasLocationToSouth
          {
               get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null; }
          }

          public bool HasLocationToEast
          {
               get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate) != null; }
          }

          public bool HasLocationToWest
          {
               get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate) != null; }
          }

          public GameSession()
          {
               //---Player Info---
               CurrentPlayer = new Player {Name="Patrick", CharacterClass="Fighter", HitPoints=10, Gold=100, ExperiencePoints=0, Level=1};

               //---Location Info---               
               CurrentWorld = WorldFactory.CreateWorld();
               CurrentLocation = CurrentWorld.LocationAt(0, 0);
               
          }

          public void MoveNorth()
          {
               if (HasLocationToNorth)
               {
                    CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
               }               
          }

          public void MoveWest()
          {
               if (HasLocationToWest)
               {
                    CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
               }               
          }

          public void MoveEast()
          {
               if (HasLocationToEast)
               {
                    CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
               }
          }

          public void MoveSouth()
          {
               if (HasLocationToSouth)
               {
                    CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
               }
          }          
     }
}
