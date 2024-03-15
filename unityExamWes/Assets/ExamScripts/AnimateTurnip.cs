using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateTurnip : MonoBehaviour
{
    // Base Animator to hold the animation for the turnup. 
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void startBouncing()
    {
        // Begin the bouncing animation.
        animator.SetBool("isBouncing", true);

    }
}
