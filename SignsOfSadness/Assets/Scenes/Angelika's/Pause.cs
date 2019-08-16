using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour 
{
    bool isPaused = false; 

    public void pauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }
    
    public void resumeGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
    }
 
}

