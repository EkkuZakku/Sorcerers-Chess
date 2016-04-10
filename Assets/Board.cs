using UnityEngine;
using System.Collections;

public class Board : MonoBehaviour
{

    private ChessTypes.Piece[,] board_xy = new ChessTypes.Piece[8, 8];

    public Board(ChessTypes.Piece[,] board_xy)
    {
        this.board_xy = board_xy;

    }

    public Board()
    {
        Initialize_Board();

    }

    // Use this for initialization
    private void Initialize_Board()
    {

        for (int i = 0; i < 8; i++)
        {
            board_xy[i, ChessTypes.BoardY._2] = new ChessTypes.Piece(ChessTypes.Pieces.Pawn, ChessTypes.Pieces.White);
            board_xy[i, ChessTypes.BoardY._7] = new ChessTypes.Piece(ChessTypes.Pieces.Pawn, ChessTypes.Pieces.Black);
            if (i == 0 || i == 8)
            {
                board_xy[i, ChessTypes.BoardY._1] = new ChessTypes.Piece(ChessTypes.Pieces.Rook, ChessTypes.Pieces.White);
                board_xy[i, ChessTypes.BoardY._8] = new ChessTypes.Piece(ChessTypes.Pieces.Rook, ChessTypes.Pieces.Black);

            }
            else if (i == 1 || i == 7)
            {
                board_xy[i, ChessTypes.BoardY._1] = new ChessTypes.Piece(ChessTypes.Pieces.Knight, ChessTypes.Pieces.White);
                board_xy[i, ChessTypes.BoardY._8] = new ChessTypes.Piece(ChessTypes.Pieces.Knight, ChessTypes.Pieces.Black);

            }
            else if (i == 2 || i == 6)
            {
                board_xy[i, ChessTypes.BoardY._1] = new ChessTypes.Piece(ChessTypes.Pieces.Knight, ChessTypes.Pieces.White);
                board_xy[i, ChessTypes.BoardY._8] = new ChessTypes.Piece(ChessTypes.Pieces.Knight, ChessTypes.Pieces.Black);

            }

        }

        board_xy[ChessTypes.BoardX._D, ChessTypes.BoardY._1] = new ChessTypes.Piece(ChessTypes.Pieces.Queen, ChessTypes.Pieces.White);
        board_xy[ChessTypes.BoardX._D, ChessTypes.BoardY._8] = new ChessTypes.Piece(ChessTypes.Pieces.Queen, ChessTypes.Pieces.Black);
        board_xy[ChessTypes.BoardX._E, ChessTypes.BoardY._1] = new ChessTypes.Piece(ChessTypes.Pieces.King, ChessTypes.Pieces.White);
        board_xy[ChessTypes.BoardX._E, ChessTypes.BoardY._8] = new ChessTypes.Piece(ChessTypes.Pieces.King, ChessTypes.Pieces.Black);

    }

    // Update is called once per frame
    //void Update()
    //{

    //}

    public ChessTypes.Piece Get_Piece_At_Location(ChessTypes.XY xy)
    {
        return Get_Piece_At_Location(xy.x, xy.y);

    }

    public ChessTypes.Piece Get_Piece_At_Location(int x, int y)
    {
        return board_xy[x, y];

    }

    public void Make_Move(ChessTypes.XY origin, ChessTypes.XY destination)
    {
        if (Check_Valid_Move(origin, destination))
        {
            Move_Piece_To_Location(origin, destination);

        }

    }

    public void Move_Piece_To_Location(ChessTypes.XY origin, ChessTypes.XY destination)
    {
        ChessTypes.Piece piece = Get_Piece_At_Location(origin);
        Set_Piece_At_Location(destination.x, destination.y, piece);
        Clear_Piece_At_Location(origin.x, origin.y);

    }

    public void Move_Piece_To_Location(int origin_x, int origin_y, int destination_x, int destination_y, ChessTypes.Piece piece)
    {
        Set_Piece_At_Location(destination_x, destination_y, piece);
        Clear_Piece_At_Location(origin_x, origin_y);

    }

    private void Set_Piece_At_Location(int x, int y, ChessTypes.Piece piece)
    {
        board_xy[x, y] = piece;

    }

    private void Clear_Piece_At_Location(int x, int y)
    {
        board_xy[x, y] = new ChessTypes.Piece(ChessTypes.Pieces.None);

    }

    public bool Check_Valid_Move(ChessTypes.XY origin, ChessTypes.XY destination)
    {
        ChessTypes.Piece origin_piece = Get_Piece_At_Location(origin);
        ChessTypes.Piece destination_piece = Get_Piece_At_Location(destination);
        if (origin_piece.PieceType != ChessTypes.Pieces.None)
        {
            if (destination_piece.PieceType != ChessTypes.Pieces.None)
            {
                if (Get_Piece_At_Location(origin).Color == Get_Piece_At_Location(destination).Color)
                {
                    return false;
                }
                else
                {
                    if (ChessTypes.Check_Valid_Movement(origin, destination, this))
                        return true;
                    else
                        return false;
                }

            }
            else if (ChessTypes.Check_Valid_Movement(origin, destination, this))
            {
                Board temp_board = new Board(board_xy);
                temp_board.Move_Piece_To_Location(origin, destination, origin_piece);
                if (ChessTypes.In_Check(temp_board))
                    return false;
                else
                    return true;
            }
            else
                return false;
        }
        else
            return false;

    }

    public bool Check_Valid_Move(int origin_x, int origin_y, int destination_x, int destination_y)
    {
        return Check_Valid_Move(origin_x, origin_y, destination_x, destination_y);

    }

    //public int Piece(ChessTypes.Piece piece)
    //{
    //    return new ChessTypes.Piece(Get_Piece(piece));

    //}

    //public int Piece_Type(int piece)
    //{
    //    return ChessTypes.Get_Piece(piece);

    //}

    //public int Piece_Color(int piece)
    //{
    //    return ChessTypes.Get_Piece_Color(piece);

    //}

}
