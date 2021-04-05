using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject witch; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Movement.speed = 0f;
        witch.SetActive(true);
    }
}
