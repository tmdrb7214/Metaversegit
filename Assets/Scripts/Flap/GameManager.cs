using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    public static GameManager instance;

    public GameObject Bat;
    public GameObject Eagle;
    public GameObject EndPanel;

    public Text timeText;
    public Text NowScore;
    public Text BestScore;
    public Text DieEmemy;


    bool isPlay = true;
    float time = 30.0f;
    
    int score = 0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }   
    void Start()
    {
        InvokeRepeating("MakeEmemy", 0.5f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlay && time > 0f) 
        {
            time -= Time.deltaTime;
            timeText.text = time.ToString("N2");
            DieEmemy.text = score.ToString();
        }
        else
        {
            GameOver();
        }

    }

    void MakeEmemy()
    {
        Instantiate(Bat);
        Instantiate(Eagle);
    }

    public void GameOver()
    {
        isPlay = false;
        Time.timeScale = 0;
        NowScore.text = score.ToString();
        if (PlayerPrefs.HasKey("BestScore"))
        {
            float best = PlayerPrefs.GetFloat("BestScore");

            if (best < score)
            {
                PlayerPrefs.SetFloat("BestScore", score);
                BestScore.text = score.ToString();
            }
            else
            {
                BestScore.text = best.ToString();
            }
        }
        else
        {
            PlayerPrefs.SetFloat("BestScore", score);
            BestScore.text = score.ToString();
        }
       
        EndPanel.SetActive(true);
    }

    public void AddScore()
    {
        score += 1;
        NowScore.text = score.ToString();
    }

}
