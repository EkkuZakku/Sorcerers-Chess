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
        //print("OnMouseOver in PieceHandler");
        if (Input.GetMouseButtonDown(0))
        {
            if (GameLogic.PieceSelected == false)
            {
                GameLogic.PieceSelected = true;
                GameLogic.SelectedPieceLocation = location;
                GameLogic.SelectedPieceName = this.name;
                //print("PieceHandler name: " + this.name + " and location: " + location.x.ToString() + "," + location.y.ToString());

            }
            else
            {
                GameLogic.MovePiece(location,this.name);
                GameLogic.PieceSelected = false;

            }

        }

    }

}
