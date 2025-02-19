using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject Bat;
    public GameObject Eagle;

    public Text timeText;

    float time = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeEmemy", 0.5f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        timeText.text = time.ToString("N2");
    }

    void MakeEmemy()
    {
        Instantiate(Bat);
        Instantiate(Eagle);
    }
}
