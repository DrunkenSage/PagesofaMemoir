using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Witch : MonoBehaviour
{

    float speed = 1;
    public GameObject witch;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0f, -5f) * speed * Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(0);
    }

    

}
