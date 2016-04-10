using UnityEngine;
using System.Collections;

public static class ChessTypes
{
    public class Piece
    {
        public int PieceType;
        public int Color;
        private int p1;
        private int p2;

        public Piece()
        {
            PieceType = Pieces.None;
            Color = Pieces.White;

        }

        public Piece(int piece_type, int piece_color)
        {
            PieceType = piece_type;
            Color = piece_color;

        }

        public Piece(int piece_type)
        {
            PieceType = piece_type;
            Color = Pieces.White;

        }

    }

    public struct Pieces
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

    public static int Get_Piece_Color(int piece)
    {
        if (piece > Pieces.Black)
        {
            return Pieces.Black;
        }
        else
        {
            return Pieces.White;
        }

    }

    public static int Get_Piece(int piece)
    {
        return piece - Get_Piece_Color(piece);

    }

    public struct XY
    {
        public int x;
        public int y;

        public XY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

    }

    public class BoardX
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

    public class BoardY
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

    public static bool Check_Valid_Movement(ChessTypes.XY origin, ChessTypes.XY destination, Board board)
    {
        ChessTypes.Piece origin_piece = board.Get_Piece_At_Location(origin);
        //ChessTypes.Piece destination_piece = board.Get_Piece_At_Location(origin);
        switch (origin_piece.PieceType)
        {
            case (ChessTypes.Pieces.Pawn):
                {
                    if (Valid_Pawn_Movement(origin_piece, origin, destination))
                        return true;
                    break;
                }
            case (ChessTypes.Pieces.Knight):
                {
                    if (Valid_Knight_Movement(origin_piece, origin, destination))
                        return true;
                    break;
                }
            case (ChessTypes.Pieces.Bishop):
                {
                    if (Valid_Bishop_Movement(origin_piece, origin, destination))
                        return true;
                    break;
                }
            case (ChessTypes.Pieces.Rook):
                {
                    if (Valid_Rook_Movement(origin_piece, origin, destination))
                        return true;
                    break;
                }
            case (ChessTypes.Pieces.Queen):
                {
                    if (Valid_Bishop_Movement(origin_piece, origin, destination) || Valid_Rook_Movement(origin_piece, origin, destination))
                        return true;
                    break;
                }
            case (ChessTypes.Pieces.King):
                {
                    if (Valid_King_Movement(origin_piece, origin, destination))
                        return true;
                    break;
                }
            default:
                return false;

        }
        return false;

    }

    private static bool Valid_Pawn_Movement(Piece origin_piece, XY origin, XY destination)
    {
        if (origin_piece.Color == ChessTypes.Pieces.White)
        {
            if (destination.y < origin.y)
            {
                if (origin.y == BoardY._2)
                {
                    if (origin.x == destination.x)
                    {
                        if (destination.y > origin.y && destination.y <= BoardY._4)
                            return true;
                        else
                            return false;
                    }
                    else if (origin.x - 1 == destination.y || origin.x + 1 == destination.y)
                    {
                        if (origin.y + 1 == destination.y)
                            return true;
                        else
                            return false;
                    }
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }
        else// if (origin_piece.Color == ChessTypes.Pieces.Black)
        {
            if (destination.y < origin.y)
            {
                if (origin.y == BoardY._7)
                {
                    if (origin.x == destination.x)
                    {
                        if (destination.y >= BoardY._5)
                            return true;
                        else
                            return false;
                    }
                    else if (origin.x - 1 == destination.y || origin.x + 1 == destination.y)
                    {
                        if (origin.y - 1 == destination.y)
                            return true;
                        else
                            return false;
                    }
                    else
                        return false;
                }
                else
                {
                    return false;
                }
            }
            else
                return false;
        }
        //else
        //    return false;

    }

    private static bool Valid_Knight_Movement(Piece origin_piece, XY origin, XY destination)
    {
        return true;

    }

    private static bool Valid_Bishop_Movement(Piece origin_piece, XY origin, XY destination)
    {
        return true;

    }

    private static bool Valid_Rook_Movement(Piece origin_piece, XY origin, XY destination)
    {
        return true;

    }

    private static bool Valid_King_Movement(Piece origin_piece, XY origin, XY destination)
    {
        return true;

    }

    public static bool In_Check(Board temp_board)
    {
        return false;
    }
}
