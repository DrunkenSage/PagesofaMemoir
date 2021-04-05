using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JorunalCollsion : MonoBehaviour
{
    public GameObject mapButton;
    public GameObject mapButton2;
    public GameObject map;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        mapButton.SetActive(true);
        mapButton2.SetActive(true);
        map.SetActive(false);
    }
}
