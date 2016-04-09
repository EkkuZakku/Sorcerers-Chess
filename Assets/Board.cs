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

    private int[,] board_xy = new int[8,8];

    // Use this for initialization
    void Start()
    {

        for (int i = 0; i < 8; i++)
        {
            board_xy[i, BoardY._2] = (ChessTypes.Piece.Pawn + ChessTypes.Piece.White);
            board_xy[i, BoardY._7] = (ChessTypes.Piece.Pawn + ChessTypes.Piece.Black);
            if (i == 0 || i == 8)
            {
                board_xy[i, BoardY._1] = ChessTypes.Piece.Rook + ChessTypes.Piece.White;
                board_xy[i, BoardY._8] = ChessTypes.Piece.Rook + ChessTypes.Piece.Black;

            }
            else if (i == 1 || i == 7)
            {
                board_xy[i, BoardY._1] = ChessTypes.Piece.Knight + ChessTypes.Piece.White;
                board_xy[i, BoardY._8] = ChessTypes.Piece.Knight + ChessTypes.Piece.Black;

            }
            else if (i == 2 || i == 6)
            {
                board_xy[i, BoardY._1] = ChessTypes.Piece.Knight + ChessTypes.Piece.White;
                board_xy[i, BoardY._8] = ChessTypes.Piece.Knight + ChessTypes.Piece.Black;

            }

        }

        board_xy[BoardX._D, BoardY._1] = ChessTypes.Piece.Queen + ChessTypes.Piece.White;
        board_xy[BoardX._D, BoardY._8] = ChessTypes.Piece.Queen + ChessTypes.Piece.Black;
        board_xy[BoardX._E, BoardY._1] = ChessTypes.Piece.King + ChessTypes.Piece.White;
        board_xy[BoardX._E, BoardY._8] = ChessTypes.Piece.King + ChessTypes.Piece.Black;

    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    public int Get_Piece_At_Location(int x, int y)
    {
        return board_xy[x, y];

    }

    public void Move_Piece_To_Location(int origin_x, int origin_y, int destination_x, int destination_y, int piece)
    {
        if (Check_Valid_Move(origin_x,origin_y,destination_x,destination_y,piece))
        {
            Set_Piece_At_Location(destination_x, destination_y, piece);
            Clear_Piece_At_Location(origin_x, origin_y);

        }

    }

    private void Set_Piece_At_Location(int x, int y, int piece)
    {
        board_xy[x, y] = piece;

    }

    private void Clear_Piece_At_Location(int x, int y)
    {
        board_xy[x, y] = ChessTypes.Piece.None;

    }

    public bool Check_Valid_Move(int[] origin, int destination_x, int destination_y, int piece)
    {
        return Check_Valid_Move(origin[0], origin[1], destination_x, destination_y, piece);

    }

    public bool Check_Valid_Move(int origin_x, int origin_y, int destination_x, int destination_y, int piece)
    {

        return true;

        return false;

    }

}
