using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{
    private bool isPaused = false;
    public GameObject pausePanel;
    public GameObject Win_screen;
    public GameObject Lose_screen;
    public void playButton()
    {
        Debug.Log("play button called");
     // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Level1()
    {
        Debug.Log("Level 1 called");
     // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.LoadScene(1);
    }
    public void Pause_btn()
    {
        Debug.Log("Pause Button called");
        
        Time.timeScale = 0f;
        isPaused = true;
        //pausePanel.SetActive(true); // Show the pause panel
    }
    /*
    public void Win_screen()
    {
        Debug.Log("Win Button showed");
        Time.timeScale = 0f;
        isPaused = true;
        Win_screen.SetActive(true); // Show the win screen
    }

    public void Lose_screen()
    {
        Debug.Log("Game losed");
        Time.timeScale = 0f;
        isPaused = true;
        Lose_screen.SetActive(true); // Show the lose screen
    }
    */
}
    

