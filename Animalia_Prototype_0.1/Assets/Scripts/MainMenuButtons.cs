using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuButtons : MonoBehaviour {
    public GameObject MenuButton1;
    public GameObject MenuButton2;
    public GameObject MenuButton3;
    public GameObject HelpButton1;
    public GameObject HelpButton2;
    public GameObject HelpButton3;
    public GameObject[] helppics;
    int currentPic;

    public void RightButton()
    {
        helppics[currentPic].SetActive(false);
        currentPic = (currentPic + 1) % helppics.Length;
        helppics[currentPic].SetActive(true);

    }
    public void LeftButton()
    {
        helppics[currentPic].SetActive(false);
        currentPic--;
        if (currentPic < 0)
        {
            currentPic = helppics.Length-1;
        }
        helppics[currentPic].SetActive(true);
    
    }

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
        if (button == 3)
        {
            helppics[currentPic].SetActive(true);
            HelpButton1.SetActive(true);
            HelpButton2.SetActive(true);
            HelpButton3.SetActive(true);
            MenuButton1.SetActive(false);
            MenuButton2.SetActive(false);
            MenuButton3.SetActive(false);
        }

        if(button == 4)
        {
            RightButton();
        }
        if(button == 5)
        {
            LeftButton();
        }
        if(button == 6)
        {
            helppics[currentPic].SetActive(false);
            HelpButton1.SetActive(false);
            HelpButton2.SetActive(false);
            HelpButton3.SetActive(false);
            MenuButton1.SetActive(true);
            MenuButton2.SetActive(true);
            MenuButton3.SetActive(true);
        }
       


    }
}
