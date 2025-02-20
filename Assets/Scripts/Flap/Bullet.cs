using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    

    void Update()
    {
        transform.position += Vector3.right *4f *Time.deltaTime;

        if(transform.position.x > 10.0f)
        {
            Destroy(gameObject);
        }
    }
}
