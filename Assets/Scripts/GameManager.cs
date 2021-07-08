using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //public Text playText;
    public Text scoreText;
    public Text nameText;

    public GameObject menu;
    public GameObject stats;
    public GameObject gameOver;

    //let's try spawning after play buttong click
    public GameObject spawnPrefab;

    public static GameManager Instance { get; private set; }

    public enum State { MENU, PLAY, GAMEOVER, INIT };
    State pstate;

    public void playClicked()
    {
        switchState(State.INIT); //init??? 
    }

    private int pscore;

    public int Score
    {
        get { return pscore; }
        set { pscore = value;
            scoreText.text = "SCORE: " + pscore;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        switchState(State.MENU);
    }

   

    public void switchState(State newState)
    {
        endState();
        beginState(newState);
    }
    
    void beginState(State newState)
    {
        switch (newState)
        {
            case State.MENU:
                menu.SetActive(true);
                break;
            case State.PLAY:
                break;
            case State.GAMEOVER:
                gameOver.SetActive(true);
                break;
            case State.INIT:
                stats.SetActive(true);
                Instantiate(spawnPrefab);
                break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void endState()
    {
        switch (pstate)
        {
            case State.MENU:
                menu.SetActive(false);
                break;
            case State.PLAY:
                break;
            case State.GAMEOVER:
                stats.SetActive(false);
                gameOver.SetActive(false);
                break;
            case State.INIT:
                break;
        }
    }
}
