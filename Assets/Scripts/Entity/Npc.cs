using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Npc : MonoBehaviour
{
    public GameObject dialoguePanel;//��ȭâ
    public Text dialogueText; //��ȭ����

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
        dialogueText.text = "1. �����ϱ�      2. �ƹ��͵������ʱ�";
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
                dialogueText.text = "������ �����մϴ�.";
                dialogueState = 1;
                SceneManager.LoadScene("Flap");
                break;
            case 2:
                dialogueText.text = "�ƹ��͵� ���� �ʽ��ϴ�.";
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
