using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Bat;
    public GameObject Eagle;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeEmemy", 0.5f, 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void MakeEmemy()
    {
        Instantiate(Bat);
        Instantiate(Eagle);
    }
}
