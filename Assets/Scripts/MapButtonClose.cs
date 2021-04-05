using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapButtonClose : MonoBehaviour
{
    public GameObject mapButton2;
    public GameObject map;
    public GameObject mapButton;
    public GameObject mapBack;
    public void OnClose()
    {
        map.SetActive(false);
        mapButton2.SetActive(false);
        mapButton.SetActive(true);
        mapBack.SetActive(false);
    }
}
