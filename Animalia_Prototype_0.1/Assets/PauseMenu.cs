using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseMenu : MonoBehaviour {
    public GameObject pauseImage;
    
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape)) //pauses game with P or Esc
        {
            if (Time.timeScale == 1)//pauses the game and opens the pause menu
            {
                Time.timeScale = 0;
                pauseImage.SetActive(true);
            }
            else // unpauses the game and closes the pause menu
            {
                Time.timeScale = 1;
                pauseImage.SetActive(false);
            }

        }
      

    }
    

    public void OnClick(int pauseButton)
    {
        if(pauseButton == 1)//Returns you to main menu
        {
            SceneManager.LoadScene(0);
        }

        if(pauseButton == 2)//Resumes the game
        {
            Time.timeScale = 1;
            pauseImage.SetActive(false);
        }
        if(pauseButton == 3)//Resets the level
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(pauseButton == 4)//Quits the game
        {
            Application.Quit();
        }
    }
}
