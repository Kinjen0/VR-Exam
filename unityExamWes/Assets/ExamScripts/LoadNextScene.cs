using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour
{
    // Integer to store the index of the next scene. Can be changed for different scenes later.
    public int nextSceneNum;
    public void nextScene()
    {
        SceneManager.LoadScene(nextSceneNum);
    }
}
