using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cross : MonoBehaviour
{ 
    private SpriteRenderer spriteRenderer;
    public Sprite crossSprite;
    public Sprite zeroSprite;
    public bool locked;
    public int x, y;
    static public bool ok;
    public SpriteRenderer[] allSprites;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.enabled = false;
        locked = false;
        //allSprites = GetComponents<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Board.theWinner > 0)
        {
            StartCoroutine(Wait(2));
            for( int i = 0; i < allSprites.Length; i++)
            {
                allSprites[i].enabled = false;
            }
            //spriteRenderer.enabled = false;

            Debug.Log("samdasdk");
            //StartCoroutine(Wait(20));
            Board.boardSpread.enabled = false;
            spriteRenderer.enabled = false;
            Board.showRestartMenu = true;
            Board.no_player = 0;
            //Timer.resetTimer = true;
            ok = true;
        }
        else if (Board.theWinner <= 0 && Board.no_player >= 9)
        { 
            StartCoroutine(Wait(2));
            for (int i = 0; i < allSprites.Length; i++)
            {
                allSprites[i].enabled = false;
            }

            Debug.Log("samdasdk");
            //StartCoroutine(Wait(20));
            Board.boardSpread.enabled = false;

            spriteRenderer.enabled = false;
            Board.showRestartMenu = true;
            Board.no_player = 0;
            Board.no_player = 0;
            //Timer.resetTimer = true;

            ok = true;
        }

        if (Board.restart == true)
            locked = false;
    }

    void OnMouseOver()
    {
        //Debug.Log(Board.no_player + " " + locked + " " + Board.theWinner + "");

        
        if ((Input.GetMouseButtonDown(0) && locked == false && Board.restart == false) && ( Board.no_player % 2 == 0 && Board.theWinner <= 0 && Board.restart == false) )
        {
            spriteRenderer.sprite = crossSprite;
            spriteRenderer.enabled = true;
            locked = true;
            Debug.Log(Board.no_player);
            Board.no_player++;
            Board.Move(x, y);
            Timer.theMoveWasMade = true;
            Board.theWinner = Board.VerifyWin();
        }
        else if((Input.GetMouseButtonDown(0) && locked == false && Board.restart == false) && (Board.no_player % 2 == 1 && Board.theWinner <= 0 && Board.restart == false))
        {
            spriteRenderer.sprite = zeroSprite;
            spriteRenderer.enabled = true;
            locked = true;
            Debug.Log(Board.no_player);
            Board.no_player++;
            Board.Move(x, y);
            Timer.theMoveWasMade = true;
            Board.theWinner = Board.VerifyWin();
        }
        Timer.theMoveWasMade = false;
    }
    IEnumerator Wait( float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }

}


