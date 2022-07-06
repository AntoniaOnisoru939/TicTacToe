using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    //public int n;
    //public Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
       // scene = GetComponent<Scene>();
        //restartButton = restartButton.GetComponent<Button>();
        //restartButton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        /*if (restartButton.clicked == true)
        {

            Debug.Log("It worked :D");

        }*/
    }
    public void OnButtonPress()
    {
        Debug.Log("pitici!!!!!!!!!!!!");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //int x;
        //x = SceneManager.GetActiveScene();
        //SceneManager.LoadScene(scene);
        Board.boardSpread.enabled = true;
        Board.showRestartMenu = false;
        Board.afisareMat = false;
        Board.restart = true;
        ScoreBoard.dontShow = false;
        //Timer.resetTimer = false;

        gameObject.SetActive(false);
        GameOverMenu.results.text = "";
    }
    void OnMouseOver()
    {
        Debug.Log(Board.no_player);
            Debug.Log("pitici!!!!!!!!!!!!");
       // SceneMenager.LoadScean(SceneMenager.GetActiveScene());

            //button.SetActive(false);
        }
}
