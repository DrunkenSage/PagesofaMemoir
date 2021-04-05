using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Walkspeed = 5f;
    public float Runspeed = 8f;
    public static float speed = 5f;
    bool isRunning = false;
    public Rigidbody2D rb;
    Vector2 move;
    public AudioSource footsteps;
    public Animator animator;
    void Update()
    {
        move.x = Input.GetAxisRaw("Horizontal");
        move.y = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Horizontal", move.x);
        animator.SetFloat("Vertical", move.y);
        animator.SetFloat("Speed", move.sqrMagnitude);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = Runspeed;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = Walkspeed;
        }

    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
        if (isRunning == true)
        {
            footsteps.Play();
        }
        else if (isRunning == false)
        {
            footsteps.Stop();
        }
    }

}
