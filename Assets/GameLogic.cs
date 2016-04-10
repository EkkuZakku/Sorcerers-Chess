using UnityEngine;
using System.Collections;

public static class GameLogic : MonoBehaviour
{
    
    private static Board game_board = new Board();
    public static bool PieceSelected { get; set; }
    public static ChessTypes.XY SelectedPieceLocation { get; set; }

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
        GameObject a2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject b2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject c2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject d2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject e2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject f2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject g2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        GameObject h2pawn = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        a2pawn.AddComponent<PieceHandler>();
        PieceHandler a2pawnhandler = a2pawn.GetComponent<PieceHandler>();
        a2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._A, ChessTypes.BoardY._2);
        a2pawn.transform.position = new Vector3((float)a2pawnhandler.location.x, 0.5f, (float)a2pawnhandler.location.y);
        b2pawn.AddComponent<PieceHandler>();
        PieceHandler b2pawnhandler = a2pawn.GetComponent<PieceHandler>();
        a2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._B, ChessTypes.BoardY._2);
        b2pawn.transform.position = new Vector3((float)b2pawnhandler.location.x, 0.5f, (float)b2pawnhandler.location.y);
        c2pawn.AddComponent<PieceHandler>();
        PieceHandler c2pawnhandler = a2pawn.GetComponent<PieceHandler>();
        a2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._C, ChessTypes.BoardY._2);
        c2pawn.transform.position = new Vector3((float)c2pawnhandler.location.x, 0.5f, (float)c2pawnhandler.location.y);
        d2pawn.AddComponent<PieceHandler>();
        PieceHandler d2pawnhandler = a2pawn.GetComponent<PieceHandler>();
        a2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._D, ChessTypes.BoardY._2);
        d2pawn.transform.position = new Vector3((float)d2pawnhandler.location.x, 0.5f, (float)d2pawnhandler.location.y);
        e2pawn.AddComponent<PieceHandler>();
        PieceHandler e2pawnhandler = a2pawn.GetComponent<PieceHandler>();
        a2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._E, ChessTypes.BoardY._2);
        e2pawn.transform.position = new Vector3((float)e2pawnhandler.location.x, 0.5f, (float)e2pawnhandler.location.y);
        f2pawn.AddComponent<PieceHandler>();
        PieceHandler f2pawnhandler = a2pawn.GetComponent<PieceHandler>();
        a2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._F, ChessTypes.BoardY._2);
        f2pawn.transform.position = new Vector3((float)f2pawnhandler.location.x, 0.5f, (float)f2pawnhandler.location.y);
        g2pawn.AddComponent<PieceHandler>();
        PieceHandler g2pawnhandler = a2pawn.GetComponent<PieceHandler>();
        a2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._G, ChessTypes.BoardY._2);
        g2pawn.transform.position = new Vector3((float)g2pawnhandler.location.x, 0.5f, (float)g2pawnhandler.location.y);
        h2pawn.AddComponent<PieceHandler>();
        PieceHandler h2pawnhandler = a2pawn.GetComponent<PieceHandler>();
        a2pawnhandler.location = new ChessTypes.XY(ChessTypes.BoardX._H, ChessTypes.BoardY._2);
        h2pawn.transform.position = new Vector3((float)h2pawnhandler.location.x, 0.5f, (float)h2pawnhandler.location.y);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Update is called once per frame
    public static void MovePiece(ChessTypes.XY destination)
    {
        ChessTypes.XY origin = SelectedPieceLocation;
        //ChessTypes.Piece originpiece = game_board.Get_Piece_At_Location(origin);
        game_board.Make_Move(origin, destination);

    }

}
