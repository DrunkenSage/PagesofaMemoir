using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapButton : MonoBehaviour
{
   public GameObject mapButton2;
    public GameObject map;
    public GameObject mapButton;
    public GameObject mapBack;
   public void OnClick()
    {
        map.SetActive(true);
        mapButton2.SetActive(true);
        mapButton.SetActive(false);
        mapBack.SetActive(true);
    }
}
