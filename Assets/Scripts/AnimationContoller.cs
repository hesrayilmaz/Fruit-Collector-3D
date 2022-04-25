using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationContoller : MonoBehaviour
{
    private Animator animator;
    PlayerController player;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.isJumped)
        {
            animator.SetBool("isJumped", true);
            
        }
        else
        {
            animator.SetBool("isJumped", false);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("isJumped", true);
        }
        else
        {
            animator.SetBool("isJumped", false);
        }
    }
}
