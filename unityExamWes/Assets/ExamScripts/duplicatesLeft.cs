using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duplicatesLeft : MonoBehaviour
{
    // Unfinished object, this would have allowed me to limit the total number of duplicates
    int totalDuplicated = 3;
    public void duplicate()
    {
        totalDuplicated--;
    }

    public bool checkRemaining()
    {
        if(totalDuplicated > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
