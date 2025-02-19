using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right *4f *Time.deltaTime;

        if(transform.position.x > 10.0f)
        {
            Destroy(gameObject);
        }
    }
}
