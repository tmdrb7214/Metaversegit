using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public string Flap;
    private bool isPlayerNear = false;

    void Start()
    {
        
    }

   
    void Update()
    {
        if(isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            LoadScene();
        }
    }


    private void LoadScene()
    {
      SceneManager.LoadScene(Flap);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isPlayerNear = false;
        }
    }

}
