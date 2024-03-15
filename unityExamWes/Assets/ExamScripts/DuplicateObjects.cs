using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateObjects : MonoBehaviour
{
    // Allow the object to only be duplicated once
    int duplicateLimit = 1;
    // Seperate object to help manage the TOTAL duplicates, currently not functional
    public duplicatesLeft totalDuplicatesHolder;
    // Score object to allow us to add a score from inside this script
    public Score score;
    // Offset so that the Objects dont spawn on top of one another
    public Vector3 offset = new Vector3(1, 0, 0);

    public AudioSource audioSource; 
    // Function to allow me to duplicate the turnup,
    public void duplicate()
    {
        if(duplicateLimit > 0) // Not checking for duplicates remaining because I didnt have time to fix it durring class time. But I have the framework
        {
            Debug.Log(totalDuplicatesHolder.checkRemaining()); // testing code,
            totalDuplicatesHolder.duplicate(); // Basically let the duplicates holder know that its time to duplicate
            // Create a copy of this object
            Instantiate(this, this.transform.position + offset, this.transform.rotation);
            // Manage all of the actions we need afterwords
            duplicateLimit--;
            score.addScore(1);
            audioSource.Play();
        }
    }
}
