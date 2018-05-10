using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_script : MonoBehaviour {

    public void play()
    {
        SceneManager.LoadScene(1);
    }
    
    public void quit()
    {
        Application.Quit();
    }
}
