using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float stop = Movement.speed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Movement.speed = 0f;
    }
}
