using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    float cntdnw = 30.0f;
    public TMP_Text disvar;
    static public bool theMoveWasMade;

    void Start()
    {
        theMoveWasMade = false;
    }


    void Update()
    {
        if (cntdnw > 0 && theMoveWasMade != true)
        {
            cntdnw -= Time.deltaTime;
        }
        double b = System.Math.Round(cntdnw, 2);
        disvar.text = b.ToString();
        if (cntdnw < 0)
        {
            Debug.Log("Completed");
            if (Board.no_player % 2 == 0)
                Board.theWinner = 1;
            else
                Board.theWinner = 2;
        }
    }
}
