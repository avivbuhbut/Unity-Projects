using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag.Equals("Bullet1"))
        {
            Debug.Log("hit");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("ihit=" + other.gameObject.name);
    }
}
