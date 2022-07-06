using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Board : MonoBehaviour
{
    static public SpriteRenderer boardSpread;
    static public int no_player;
    static public int theWinner;
    static int[,] matrix = new int[4, 4];
    static public bool afisareMat;
    static int i, j;
    static public bool showRestartMenu;
    static public bool restart;
    static public int scorePlayer1, scorePlayer2;

    //public string message;
    // Start is called before the first frame update
    void Start()
    {
        //message = GameObject.Find("Canvas/Text").GetComponent<Text>();
        boardSpread = GetComponent<SpriteRenderer>();
        no_player = 0;
        afisareMat = false;
        theWinner = -1;
        showRestartMenu = false;
        restart = false;
        scorePlayer1 = 0;
        scorePlayer2 = 0;
        for (int i = 1; i < 4; i++)
        {
            for (int j = 1; j < 4; j++)
                matrix[i, j] = 100;
        }

    }

    static public void Move(int x, int y)
    {
        matrix[x, y] = (no_player - 1) % 2;

        //Debug.Log(no_player + 1);
    }

    // Update is called once per frame
    void Update()
    {
        if ((no_player == 9 && afisareMat == false) || ( theWinner > 0 && afisareMat == false)  )
        {
            Debug.Log("inainte de if");
            if (theWinner == -1)
            {

                //StartCoroutine(Wait(4));
                //textGameObject.GetComponent<UnityEngine.UI.Text>().text = "text";
                //message = "I's a tie";
            }
            else
            {
                //StartCoroutine(Wait(4));
                Debug.Log("The winner is player " + theWinner);
                //message = "Player " + theWinner + "is the winner";
            }
            afisareMat = true;
            /*for( i = 1; i < 4; i++)
            {
                for( j = 1; j < 4; j++)
                {
                    Debug.Log("Mat: " + matrix[i, j]+ " " );
                }
            }*/
            
        }

        if (restart == true)
        {
            StartCoroutine(Wait(0.02f));
            restart = false;
            resetMatrix();
        }
    }

    static public int VerifyWin()
    {
        int winner, cnt;
        winner = -1;
        cnt = 0;
        for (i = 1; i < 4; i++)
        {
            for (j = 1; j < 4; j++)
            {
                cnt += matrix[i, j];
            }
            if (cnt == 0)
            {
                winner = 1;
                i = 5;
            }
            if (cnt == 3)
            {
                winner = 2;
                i = 5;
            }
            cnt = 0;

        }
        //Debug.Log("Case 1 " + winner);
        if (winner == -1)
        {
            for (i = 1; i < 4; i++)
            {
                for (j = 1; j < 4; j++)
                {
                    cnt += matrix[j, i];
                }
                if (cnt == 0)
                {
                    winner = 1;
                    i = 5;
                }
                if (cnt == 3)
                {
                    winner = 2;
                    i = 5;
                }
                cnt = 0;
            }
        }
        //Debug.Log("Case 2 " + winner);
        if (winner == -1)
        {
            for (i = 1; i < 4; i++)
            {
                cnt += matrix[i, i];
            }

            if (cnt == 0)
            {
                winner = 1;
            }
            if (cnt == 3)
            {
                winner = 2;
            }
            cnt = 0;
        }
        //Debug.Log("Case 3 " + winner);
        if (winner == -1)
        {
            for (i = 1; i < 4; i++)
            {
                cnt += matrix[i, 4 - i];
            }

            if (cnt == 0)
            {
                winner = 1;
            }
            if (cnt == 3)
            {
                winner = 2;
            }
        }

        if (winner == 2)
            scorePlayer2++;
        else if (winner == 1)
            scorePlayer1++;

        //Debug.Log("Case 4 " + winner);

        return winner;
    }

    public void resetMatrix()
    {
        for( i = 1; i < 4; i++)
        {
            for (j = 1; j < 4; j++)
                matrix[i, j] = 1000;
        }
    }

    IEnumerator Wait( float seconds)
    {
        yield return new WaitForSeconds(seconds);
        
    }

}
