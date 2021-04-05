using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interact : MonoBehaviour
{
    public Text interactWithMeText;
    public Transform player;
    public GameObject npcChatBox;
    


    private bool isNear = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            reactwithObject();
           

        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
       // Debug.Log("In Range");
        isNear = true;
        interactWithMeText.text = "Press F";
    }

    public void reactwithObject()
    {
        if (isNear)
        {
           npcChatBox.SetActive(true);
            
        }
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isNear = false;
        //Debug.Log("Walked Away");
        interactWithMeText.text = "";

    }

}
