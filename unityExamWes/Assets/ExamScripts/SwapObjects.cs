using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapObjects : MonoBehaviour
{
    // Brute forcing the swap function, we have the origional object and the new one, and just move the new one to where the old one was. 
    public GameObject thisObj;
    public GameObject newObj;


    public void swap()
    {
        // Move the new object into position, the active states are managed un the gaze over event on the corn
        newObj.transform.position = thisObj.transform.position;
    }
}
