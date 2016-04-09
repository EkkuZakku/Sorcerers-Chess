using UnityEngine;
using System.Collections;

public class Board : MonoBehaviour
{
    private class BoardX
    {
        public const int _A = 0;
        public const int _B = 1;
        public const int _C = 2;
        public const int _D = 3;
        public const int _E = 4;
        public const int _F = 5;
        public const int _G = 6;
        public const int _H = 7;

    }

    private class BoardY
    {
        public const int _1 = 0;
        public const int _2 = 1;
        public const int _3 = 2;
        public const int _4 = 3;
        public const int _5 = 4;
        public const int _6 = 5;
        public const int _7 = 6;
        public const int _8 = 7;

    }

    private class PieceNum
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

    private int[,] board_xy = new int[8,8];

    // Use this for initialization
    void Start()
    {

        for (int i = 0; i < 8; i++)
        {
            board_xy[i, BoardY._2] = (PieceNum.Pawn + PieceNum.White);
            board_xy[i, BoardY._7] = (PieceNum.Pawn + PieceNum.Black);
            if (i == 0 || i == 8)
            {
                board_xy[i, BoardY._1] = PieceNum.Rook + PieceNum.White;
                board_xy[i, BoardY._8] = PieceNum.Rook + PieceNum.Black;

            }
            else if (i == 1 || i == 7)
            {
                board_xy[i, BoardY._1] = PieceNum.Knight + PieceNum.White;
                board_xy[i, BoardY._8] = PieceNum.Knight + PieceNum.Black;

            }
            else if (i == 2 || i == 6)
            {
                board_xy[i, BoardY._1] = PieceNum.Knight + PieceNum.White;
                board_xy[i, BoardY._8] = PieceNum.Knight + PieceNum.Black;

            }

        }

        board_xy[BoardX._D, BoardY._1] = PieceNum.Queen + PieceNum.White;
        board_xy[BoardX._D, BoardY._8] = PieceNum.Queen + PieceNum.Black;
        board_xy[BoardX._E, BoardY._1] = PieceNum.King + PieceNum.White;
        board_xy[BoardX._E, BoardY._8] = PieceNum.King + PieceNum.Black;

    }

    // Update is called once per frame
    void Update()
    {

    }

}
