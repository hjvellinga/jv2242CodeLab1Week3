using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool playersCollided = false;
    public static GameManager Instance;
    public int currentLevel = 0;

    public GameObject playerOne;
    public GameObject playerTwo;
    
    public Vector2 originalPosPl1; //declare variable original position player 2
    public Vector2 originalPosPl2; //declare variable original position player 2
    void Awake()
    {
        if (Instance == null)  //if instance has not been set to anything yet
        {
            DontDestroyOnLoad(gameObject); //don't destroy the game manager (?)
            Instance = this; //instance is now called "this"
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        //set original position of both players
        originalPosPl1 = playerOne.transform.position;
        originalPosPl2 = playerTwo.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (playersCollided)
        {
            currentLevel++;
            SceneManager.LoadScene(currentLevel);
            playersCollided = false;
            playerOne.transform.position = originalPosPl1; //reset position Player 1.
            playerTwo.transform.position = originalPosPl2; //reset position Player 2. 

        }
        
    }
}
