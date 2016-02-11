using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuButtons : MonoBehaviour {

	
	
	public void Onclick(int button)
    {
        if(button == 1)//Loads the game
        {
            SceneManager.LoadScene(1);
        }

        if(button == 2)// Quits the game
        {
            Application.Quit();
        }


    }
}
