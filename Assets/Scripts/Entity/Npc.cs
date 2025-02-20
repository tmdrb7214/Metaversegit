using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Npc : MonoBehaviour
{
    public GameObject dialoguePanel;//대화창
    public Text dialogueText; //대화내용

    private bool isPlayerNear = false;
    private bool isDialogueActive = false;
    private int dialogueState = 0;

    void Update()
    {
        if(isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            if (!isDialogueActive)
            {
                StartDialogue();
            }
            else
            {
                EndDialogue();
            }
        }
        
        if (isDialogueActive)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                ChoiseNumber(1);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                ChoiseNumber(2);
            }
        }
    }
    private void StartDialogue()
    {
        dialoguePanel.SetActive(true);
        isDialogueActive = true;
        dialogueState = 0;
        dialogueText.text = "1. 게임하기      2. 아무것도하지않기";
    }

    private void EndDialogue()
    {
        dialoguePanel.SetActive(false);
        isDialogueActive = false;
    }
    private void ChoiseNumber(int choice)
    {
        switch (choice)
        {
            case 1:
                dialogueText.text = "게임을 시작합니다.";
                dialogueState = 1;
                SceneManager.LoadScene("Flap");
                break;
            case 2:
                dialogueText.text = "아무것도 하지 않습니다.";
                dialogueState = 2;
                break;
        }
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
            dialoguePanel.SetActive(false);
        }
    }
}
