﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BattleshipOOP
{
    public class ComputerPlayer : Player
    {

        public ComputerPlayer(string name = "Computer")
        {
            Name = name;
            IsHuman = false;
            list = new List<Ship>();
        }
        public override Square DoMove(Display display, Input input, Utility utility, Board board)
        {
            Square selectedSquare = new Square(0,0);
            do
            {
                Random rand = new Random();
                int x, y;
                x = rand.Next(0, board.size);
                y = rand.Next(0, board.size);
                selectedSquare = GetSquareByCoordinates(new List<int> { x, y }, board);
            }while(selectedSquare.SquareStatus!=SquareStatus.Empty || selectedSquare.SquareStatus!=SquareStatus.Ship);
            return selectedSquare;

        }
    }
}
