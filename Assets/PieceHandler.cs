using UnityEngine;
using System.Collections;

public class PieceHandler : MonoBehaviour
{
    public ChessTypes.XY location { get; set; }//= new ChessTypes.XY();

	// Use this for initialization
	void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (GameLogic.PieceSelected == false)
            {
                GameLogic.PieceSelected = true;
                GameLogic.SelectedPieceLocation = location;

            }
            else
            {
                GameLogic.MovePiece(location);
                GameLogic.PieceSelected = false;

            }

        }

    }

}
