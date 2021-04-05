using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordEquip : MonoBehaviour
{
    public GameObject sword;
    public GameObject swordInGame;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        sword.SetActive(true);
        swordInGame.SetActive(false);
    }
}
