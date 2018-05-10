using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class win_script : MonoBehaviour {
    public Text finaltxt;

    private void Start()
    {
        if (Score_calculator.bar1win == true)
        {
            finaltxt.text = "Player 1 Wins!";
        }
        else if(Score_calculator.bar2win==true)
        {
            finaltxt.text = "Player 2 Wins!";
        }
    }

    public void play()
    {
        SceneManager.LoadScene(1);
    }

    public void quit()
    {
        Application.Quit();
    }
}
