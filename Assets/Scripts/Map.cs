using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
   
    public GameObject mapButton;
    public GameObject map;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        mapButton.SetActive(true);
        map.SetActive(false);
    }
}
