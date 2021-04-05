using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapButton : MonoBehaviour
{
    GameObject mapButton2;
    GameObject map;
    GameObject mapButton;
    void Update()
    {
        map.SetActive(true);
        mapButton2.SetActive(true);
        mapButton.SetActive(false);
    }
}
