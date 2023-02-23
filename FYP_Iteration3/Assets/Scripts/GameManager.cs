using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    [Header("Misc Gameobjects")]

    public GameObject Lose_screen;
    public GameObject Win_screen;

    //public GameObject Welldonetext;
    public GameObject completionPanel;
    public GameObject gameLooseMenu;



    [Header("UI Components")]
    public int totalScore;
    public Text totalScoreText;
    public GameObject mainMenuPanel;
    //time functionality
    public float currentTime = 0f;
    [SerializeField] Text countdownText;
    public int[] levelTimer;
    public int scoreCount = 0;

    [Header("Hits/Collision Detection")]
    public int totalLevels = 10;
    // hits allowed in each level;
    public int[] hitsPerLevel;
    public int currentcollisions;
    public Text failedReason;
    public bool isLevelFailed = false;
    public int currentLevel;
    public static GameManager instance;
    [SerializeField] Text hitCollisionText;
    [SerializeField] Text allowedHitCollisionsText;
    [SerializeField] Text CurrentStep;


    private void Update()
    {
        TimeFunctionality();
        

    }

    private void Awake()
    {
        instance = this;
        currentTime = levelTimer[currentLevel];

        //awaking hurdle collision bar
        hitCollisionText.text = currentcollisions.ToString("0");
        allowedHitCollisionsText.text = hitsPerLevel[currentLevel].ToString("0");

    }

    public void StepsCounter(int scoreCount)
    {
        while (scoreCount<=15)
        {
            scoreCount = scoreCount + 1;
            Debug.Log("score is" + scoreCount);
            CurrentStep.text = scoreCount.ToString("0");
            
            break;
        }
        


    }

    public void UpdateScore()
    {
        totalScoreText.text = totalScore.ToString();
    }
    

    public void UpdateScore01(int totalScore01 )
    {
        totalScoreText.text = totalScore01.ToString();
        if (totalScore01 == 13)
        {
            //gameLooseMenu.SetActive(true);
            //yield return new WaitForSeconds(3);

            //gameLooseMenu.SetActive(false);
            Debug.Log("Welldone!");
            Time.timeScale = 0f;
            Win_screen.SetActive(true);
            
            //Welldonetext.SetActive(true);
            //StartCoroutine(LevelComplete());
            //Welldonetext.text = Welldone.ToString();
            //GameManager.instance.Welldonetext.SetActive(true);
            //yield return new WaitForSeconds(3);
            //GameManager.instance.Welldonetext.SetActive(false);
        }
    }


 

    public void backToMainmenu()
    {
        Debug.Log("main menu called");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }


  

    public void level1HurdlesAllowed(int currentcollisions1)
    {
        Debug.Log("reached in level 1 hurdles ");
        Debug.Log(hitsPerLevel[currentLevel]);
        Debug.Log(currentcollisions1);
        hitCollisionText.text = currentcollisions1.ToString("0");
        allowedHitCollisionsText.text = hitsPerLevel[currentLevel].ToString("0");


        if (hitsPerLevel[currentLevel] == currentcollisions1 && !isLevelFailed)
        {
            gameLooseMenu.SetActive(true);
            failedReason.text = "Level Failed..!! Too many Collisions";
            isLevelFailed = true;
        }
    }

    public void TimeFunctionality()
    {

        Debug.Log("reached in timer func");



        //Debug.Log(currentTime);
        currentTime -= Time.deltaTime;
        //print(currentTime);
        countdownText.text = currentTime.ToString("0");



        if (currentTime <= 0 && !GameManager.instance.isLevelFailed)
        {
            currentTime = 0f;
            GameManager.instance.isLevelFailed = true;
            //GameManager.instance.failedReason.text = "Level Failed..!! Time Over";
            //GameManager.instance.gameLooseMenu.SetActive(true);
            Debug.Log("Game losed");
            Time.timeScale = 0f;
            //isPaused = true;
            Lose_screen.SetActive(true); // Show the lose screen
            backToMainmenu();
        }
    }
}















//vehicle parked functionality is in score count with tag ParkPoint



/*Debug.Log("Collided with hurdle");
int x = 7;
for (int i = 1; i <= totalLevels; i++)
{
    if (i % 2 != 0) //odd level where updation in hits allowed happens
    {
        x = x - 1;
        //hitsperlevel[x] = x;
        Debug.Log("\nlevel no is" + i);
        Debug.Log("\n\tlevel hurdles are" + x);

    }
    if (i % 2 == 0) //even where values repeats of each odd level's hits allowed
    {
        //hitsperlevel[x] = x;
        Debug.Log("");
        Debug.Log("\nlevel no is" + i);
        Debug.Log("\n\tlevel hurdles are" + x);
    }

}

for (int i = 1; i <= totalLevels; i++)
{
    //Debug.Log(hitsperlevel[x]);
}
*/

