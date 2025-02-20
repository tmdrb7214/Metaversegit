using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CmeraController : MonoBehaviour
{

    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            transform.position =target.position;
        }
    }
}
