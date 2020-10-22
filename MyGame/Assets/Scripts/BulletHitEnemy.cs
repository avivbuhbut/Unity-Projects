using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHitEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D colisor)
    {
        Debug.Log("Okay");
        if (colisor.gameObject.tag == "Bullet1")
        {
            Destroy(colisor.gameObject);
 
            Debug.Log("Okay2");
        }
    }
}
