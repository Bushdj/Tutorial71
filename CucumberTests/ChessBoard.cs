﻿using System;
using System.Collections.Generic;

namespace CucumberTests
{
    public class ChessBoard
    {
        System.Collections.Generic.Dictionary<Tuple<char,int>, Pawn> board = new Dictionary<Tuple<char,int>, Pawn>();
        public ChessBoard()
        { }

            public Tuple<char, int> getLocation(Pawn p) {
            foreach(Tuple<char,int> key in board.Keys)
            {
                if (board[key] == p) {
                    return key;
                }
            }
            return null;
        }

        public void movePiece(Tuple<char,int > x1, Tuple<char, int> x2)
        {
            Pawn p = board[x1];
            board.Remove(x1);
            if(board[x2] != null)
            {
                Pawn capd = board[x2];
                capd.capture();
                board.Remove(x2);
            }
            board.Add(x2, p);
        }

        public void placePiece(Pawn p, Tuple<char,int> x1)
        {
            board.Add(x1, p);

        }
    } }

        
    
