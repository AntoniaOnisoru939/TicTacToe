using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    static public TMP_Text results;
    private GameObject button;
    void Start()
    {
        results = GetComponent<TMP_Text>();
        button = GameObject.Find("Button");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("innte " + Board.theWinner);
        if ((Board.theWinner > 0 && Board.showRestartMenu == true) && cross.ok == true)
        {
            results.text = "PLayer" + Board.theWinner + " is the winner";
            Board.theWinner = -1;
            button.SetActive(true);
            Debug.Log("innte " + Board.theWinner);
            Board.showRestartMenu = false;
            ScoreBoard.dontShow = true;
        }
        else if ((Board.theWinner <= 0 && Board.showRestartMenu == true) && cross.ok == true)
        {
            results.text = "It's a Tie";
            Board.theWinner = -1;
            button.SetActive(true);
            Board.showRestartMenu = false;
            ScoreBoard.dontShow = true;
        }
        else
        {
            Debug.Log("");
        }
    }
}
