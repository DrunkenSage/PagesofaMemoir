using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour
{
    public GameObject page;

    public GameObject button;

    // Update is called once per frame
    public void OnButtonClick()
    {
        page.SetActive(true);

        button.SetActive(false);
        
    }

}
