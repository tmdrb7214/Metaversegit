using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapPlayer : MonoBehaviour
{
    public GameObject Bullet;


    void Start()
    {
        InvokeRepeating("MakeBullet", 0, 0.2f);// 볼랫을 시작하자마자 0.2초마다 생성
    }

    private void Update()
    {
        Vector2 mousPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float y = mousPos.y;
        if(y > 4.5f)
        {
            y = 4.5f;
        }
        else if (y < -4.5f)
        {
            y = -4.5f;
        }
        transform.position = new Vector2(transform.position.x,y);
    }

    void MakeBullet()
    {
        float x = transform.position.x;
        float y = transform.position.y;
        Instantiate(Bullet, new Vector2(x,y),Quaternion.identity);
    }
}
