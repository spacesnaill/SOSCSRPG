﻿using Engine.ViewModels;
using System.Windows;

namespace WPFUI
{
     /// <summary>
     /// Interaction logic for MainWindow.xaml
     /// </summary>
     public partial class MainWindow : Window
     {
          private GameSession _gameSession;

          public MainWindow()
          {
               InitializeComponent();

               _gameSession = new GameSession();

               DataContext = _gameSession; //what the xaml file will use for the values of labels and controls
          }

          private void OnClick_MoveNorth(object sender, RoutedEventArgs e)
          {
               _gameSession.MoveNorth();
          }

          private void OnClick_MoveWest(object sender, RoutedEventArgs e)
          {
               _gameSession.MoveWest();
          }

          private void OnClick_MoveEast(object sender, RoutedEventArgs e)
          {
               _gameSession.MoveEast();
          }

          private void OnClick_MoveSouth(object sender, RoutedEventArgs e)
          {
               _gameSession.MoveSouth();
          }
     }
}