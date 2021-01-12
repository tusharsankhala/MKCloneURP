using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float hMov = Input.GetAxis("Horizontal");
        float vMov = Input.GetAxis("Vertical");

        if (hMov > 0)
        {
            animator.SetBool("Forward", true);
        }

        if (hMov > 0)
        {
            animator.SetBool("Backward", true);
        }

        if (hMov == 0)
        {
            animator.SetBool("Forward", false);
            animator.SetBool("Backward", false);
        }

        if (vMov > 0)
        {
            animator.SetBool("Jump", true);
        }

        if (vMov < 0)
        {
            animator.SetBool("Crouch", true);
        }

        if (vMov == 0)
        {
            animator.SetBool("Jump", false);
            animator.SetBool("Crouch", false);
        }
    }
}
