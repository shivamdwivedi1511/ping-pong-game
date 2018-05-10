using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score_calculator : MonoBehaviour {

    public Text scoreboard;
    public static bool bar1win=false;
    public static bool bar2win=false;

    public GameObject ball;
    private int bar_1_score = 0;
    private int bar_2_score = 0;
    public static bool canaddscore = true;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
        if (ball.transform.position.x > 17f && canaddscore)
        {
            canaddscore = false;
            bar_1_score++;
        }
        if (ball.transform.position.x < -17f && canaddscore)
        {
            canaddscore = false;
            bar_2_score++;
        }
        scoreboard.text =bar_1_score.ToString() + "-" + bar_2_score.ToString() ;
        if(bar_1_score==7 || bar_2_score == 7)
        {
            if (bar_1_score == 7)
            {
                bar1win = true;
            }
            else
            {
                bar2win = true;
            }
            SceneManager.LoadScene(2);
        }
        

	}
}
