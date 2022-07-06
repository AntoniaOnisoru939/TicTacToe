using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    static public TMP_Text tableScore;
    static public bool dontShow;
    // Start is called before the first frame update
    void Start()
    {

        tableScore = GetComponent<TMP_Text>();
        dontShow = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (dontShow == false)
            tableScore.text = "Score : " + Board.scorePlayer1 + " - " + Board.scorePlayer2;
        else
            tableScore.text = "";
    }
}
