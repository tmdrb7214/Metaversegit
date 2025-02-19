using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ememy : MonoBehaviour
{
    public GameObject EmemyImage;
    public GameObject Die;

    public RectTransform front;
    float full = 5.0f;
    float energy = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        float y = Random.Range(-3.0f, 3.0f);
        float x = 10.0f;
        transform.position = new Vector2(x, y);
    }

    // Update is called once per frame
    void Update()
    {
        if (energy < full)
        {
            transform.position += Vector3.left * 0.08f;
        }
        else
        {
            
            if(transform.position.y > 0.0f)
            {
                transform.position += Vector3.up * 0.05f;
            }
            else if (transform.position.y < -0.0f)
            {
                transform.position += Vector3.down * 0.05f;
            }
        }

        if (transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            
            if (energy >= full)
            {
                energy += 1.0f;
                front.localScale = new Vector3(energy / full, 1.0f, 1.0f);
                Destroy(collision.gameObject);
                if(energy == 5.0f)
                {
                    EmemyImage.SetActive(false);
                    Die.SetActive(true);
                }
            }
            
        }
       
        
    }
}
