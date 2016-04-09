using UnityEngine;
using System.Collections;

public class GameLogic : MonoBehaviour
{
    
    private Board game_board = new Board();

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
        //a2pawn.transform.position = new Vector3(-2, 1, 0);
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}

}
