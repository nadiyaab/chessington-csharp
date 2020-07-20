﻿using System.Collections.Generic;
using System.Linq;

namespace Chessington.GameEngine.Pieces
{
    public class Pawn : Piece
    {
        public Pawn(Player player) 
            : base(player) { }

        public override IEnumerable<Square> GetAvailableMoves(Board board)
        {

            if(HasMoved == true){
           
                if(Player == Player.Black){
                    return new List<Square>{
                        Square.At(7,2)
                    };
                }
                return new List<Square>{
                    Square.At(4,2)
                };
            }
                if(Player == Player.Black){
                    return new List<Square>{
                        Square.At(5,0),
                        Square.At(3,3)
                    };
                }
                return new List<Square>{
                    Square.At(3,0),
                    Square.At(4,5)
                };
        
        }
    }
}