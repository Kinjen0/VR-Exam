using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Hold the amount of time remaining
    public double timeCount;
    // unimplemented object to help me give it an object to start up the next scene. not functional
    public GameObject EndScene;
    // Text object to display the timer
    public Text timer;

    void Update()
    {
        // Decriment the time by the delta time
        timeCount -= Time.deltaTime;
        // Calculate the first number, not needed, but it will allow for multi minute timers later on
        int firstNum = (int)timeCount / 60;
        // Calculate the number of seconds left
        int SecondsCounter = (int)timeCount % 60;
        timer.text = "Time Remaining: " + firstNum + ":" + SecondsCounter;
        // A function to allow me to end the game after thirty seconds. 
        endGame();
    }

    void endGame()
    {
        if(XRInputManager.IsButtonDown())
        {
            if (timeCount <= 0)
            {
                timer.text = "ended game";
                Application.Quit();
            }
        }

    }
}
