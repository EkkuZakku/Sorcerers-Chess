using UnityEngine;
using System.Collections;

public class ChessTypes
{
    public class Piece
    {
        public const int None = 0;
        public const int Pawn = 1;
        public const int Knight = 2;
        public const int Bishop = 3;
        public const int Rook = 4;
        public const int Queen = 5;
        public const int King = 6;
        public const int White = 0;
        public const int Black = 7;

    }

    public int Get_Piece_Color(int piece)
    {
        if (piece > Piece.Black)
        {
            return Piece.Black;
        }
        else
        {
            return Piece.White;
        }

    }

    public int Get_Piece(int piece)
    {
        return piece - Get_Piece_Color(piece);

    }

}
