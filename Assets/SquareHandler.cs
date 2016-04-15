using UnityEngine;
using System.Collections;

public class SquareHandler : MonoBehaviour
{
    public ChessTypes.XY location { get; set; }//= new ChessTypes.XY();

	// Use this for initialization
	void Start ()
    {
        string name = this.name;
        string x = name.Substring(0,1);
        string y = name.Substring(1,1);
        switch (x)
        {
            case ("A"):
                {
                    x = "0";
                    break;
                }
            case ("B"):
                {
                    x = "1";
                    break;
                }
            case ("C"):
                {
                    x = "2";
                    break;
                }
            case ("D"):
                {
                    x = "3";
                    break;
                }
            case ("E"):
                {
                    x = "4";
                    break;
                }
            case ("F"):
                {
                    x = "5";
                    break;
                }
            case ("G"):
                {
                    x = "6";
                    break;
                }
            case ("H"):
                {
                    x = "7";
                    break;
                }
            default:
                {
                    x = "0";
                    break;
                }

        }

        location = new ChessTypes.XY(int.Parse(x),int.Parse(y) - 1);
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnMouseOver()
    {
        //print("OnMouseOver in SquareHandler");
        if (Input.GetMouseButtonDown(0))
        {
            if (GameLogic.PieceSelected == true)
            {
                //print("SquareHandler trying to move "+GameLogic.SelectedPieceName);
                GameLogic.MovePiece(location);
                GameLogic.PieceSelected = false;
                GameLogic.SelectedPieceName = "";

            }

        }

    }

}
