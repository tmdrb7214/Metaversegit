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
        if (other.CompareTag("Player"))// 플레이어가 가까이있을때
        {
            isPlayerNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))//플레이어가 근처에없을때 
        {
            isPlayerNear = false;
        }
    }

}
