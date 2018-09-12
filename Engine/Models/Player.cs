﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
     public class Player : INotifyPropertyChanged
     {
          private string _name;
          private string _characterClass;
          private int _hitPoints;
          private int _experiencePoints;
          private int _level;
          private int _gold;

          //leverages the "publish and subscribe" method
          //this player model publishes an event and the UI subscribes to "OnPropertyChanged" and is notified when there is a change
          public string Name
          {
               get { return _name; }
               set
               {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
               }
          }

          public string CharacterClass
          {
               get { return _characterClass; }
               set
               {
                    _name = value;
                    OnPropertyChanged(nameof(CharacterClass));
               }
          }

          public int HitPoints
          {
               get { return _hitPoints; }
               set
               {
                    _hitPoints = value;
                    OnPropertyChanged(nameof(HitPoints));
               }
          }

          public int ExperiencePoints
          {
               get { return _experiencePoints; }
               set
               {
                    _experiencePoints = value;
                    OnPropertyChanged(nameof(ExperiencePoints));
               }
          }

          public int Level
          {
               get { return _level; }
               set
               {
                    _level = value;
                    OnPropertyChanged(nameof(Level));
               }
          }

          public int Gold
          {
               get { return _gold; }
               set
               {
                    _gold = value;
                    OnPropertyChanged(nameof(Gold));
               }
          }

          public event PropertyChangedEventHandler PropertyChanged;

          protected virtual void OnPropertyChanged(String propertyName)
          {
               PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
          }
     }
}
