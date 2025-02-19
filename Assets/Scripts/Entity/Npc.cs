using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class Npc : MonoBehaviour
{
    public GameObject dialoguPanel;
    public Text dialogueText;

    private bool isPlayerNear = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }
    private void Interact()
    {
        dialoguPanel.SetActive(true);
        dialogueText.text = "æ»≥Á«œººø‰";
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
