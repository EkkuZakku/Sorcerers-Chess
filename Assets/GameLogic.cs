using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour
{
    
    private static Board game_board = new Board();
    public static bool PieceSelected { get; set; }
    public static ChessTypes.XY SelectedPieceLocation { get; set; }
    public static string SelectedPieceName { get; set; }
    GameObject a2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
    GameObject b2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
    GameObject c2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
    GameObject d2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
    GameObject e2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
    GameObject f2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
    GameObject g2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
    GameObject h2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);

    public GameLogic()
    {
        PieceSelected = false;
        
    }

	// Use this for initialization
	void Start ()
    {
        PlacePieces();

	}

    private void PlacePieces()
    {
        a2pawn.AddComponent<PieceHandler>();
        a2pawn.name = "A2PAWN";
        PieceHandler a2pawnhandler = a2pawn.GetComponent<PieceHandler>();
        a2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._A, ChessTypes.BoardY._2);
        a2pawn.transform.position = new Vector3((float)a2pawnhandler.location.x, 0.5f, (float)a2pawnhandler.location.y);
        b2pawn.AddComponent<PieceHandler>();
        b2pawn.name = "B2PAWN";
        PieceHandler b2pawnhandler = b2pawn.GetComponent<PieceHandler>();
        b2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._B, ChessTypes.BoardY._2);
        b2pawn.transform.position = new Vector3((float)b2pawnhandler.location.x, 0.5f, (float)b2pawnhandler.location.y);
        c2pawn.AddComponent<PieceHandler>();
        c2pawn.name = "C2PAWN";
        PieceHandler c2pawnhandler = c2pawn.GetComponent<PieceHandler>();
        c2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._C, ChessTypes.BoardY._2);
        c2pawn.transform.position = new Vector3((float)c2pawnhandler.location.x, 0.5f, (float)c2pawnhandler.location.y);
        d2pawn.AddComponent<PieceHandler>();
        d2pawn.name = "D2PAWN";
        PieceHandler d2pawnhandler = d2pawn.GetComponent<PieceHandler>();
        d2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._D, ChessTypes.BoardY._2);
        d2pawn.transform.position = new Vector3((float)d2pawnhandler.location.x, 0.5f, (float)d2pawnhandler.location.y);
        e2pawn.AddComponent<PieceHandler>();
        e2pawn.name = "E2PAWN";
        PieceHandler e2pawnhandler = e2pawn.GetComponent<PieceHandler>();
        e2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._E, ChessTypes.BoardY._2);
        e2pawn.transform.position = new Vector3((float)e2pawnhandler.location.x, 0.5f, (float)e2pawnhandler.location.y);
        f2pawn.AddComponent<PieceHandler>();
        f2pawn.name = "F2PAWN";
        PieceHandler f2pawnhandler = f2pawn.GetComponent<PieceHandler>();
        f2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._F, ChessTypes.BoardY._2);
        f2pawn.transform.position = new Vector3((float)f2pawnhandler.location.x, 0.5f, (float)f2pawnhandler.location.y);
        g2pawn.AddComponent<PieceHandler>();
        g2pawn.name = "G2PAWN";
        PieceHandler g2pawnhandler = g2pawn.GetComponent<PieceHandler>();
        g2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._G, ChessTypes.BoardY._2);
        g2pawn.transform.position = new Vector3((float)g2pawnhandler.location.x, 0.5f, (float)g2pawnhandler.location.y);
        h2pawn.AddComponent<PieceHandler>();
        h2pawn.name = "H2PAWN";
        PieceHandler h2pawnhandler = h2pawn.GetComponent<PieceHandler>();
        h2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._H, ChessTypes.BoardY._2);
        h2pawn.transform.position = new Vector3((float)h2pawnhandler.location.x, 0.5f, (float)h2pawnhandler.location.y);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Update is called once per frame
    public static void MovePiece(ChessTypes.XY destination,string sender)
    {
        ChessTypes.XY origin = SelectedPieceLocation;
        //ChessTypes.Piece originpiece = game_board.Get_Piece_At_Location(origin);
        print("GameLogic MovePiece trying to move "+sender);
        if (game_board.Make_Move(origin, destination))
        {
            UpdateLocation(destination, sender);

        }

    }

    private static void UpdateLocation(ChessTypes.XY destination, string sender)
    {
        GameObject piece = GameObject.Find(sender);
        //print("GameLogic UpdateLocation trying to move " + sender + " to " + destination.x.ToString() + "," + destination.y.ToString());
        piece.transform.position = new Vector3((float)destination.x, 0.5f, (float)destination.y);
        PieceHandler piecehandler = piece.GetComponent<PieceHandler>();
        piecehandler.location = destination;

    }

}
