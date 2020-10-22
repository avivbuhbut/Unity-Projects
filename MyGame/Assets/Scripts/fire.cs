using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{


    GameObject other;
    GameObject EnemieNew;
    GameObject heavyBullet1;

    public float firespeed;
    // Start is called before the first frame update
    void Start()
    {
        EnemieNew = GameObject.Find("EnemieNew");
        heavyBullet1 = GameObject.Find("Heavy_Bullet1");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * firespeed * Time.deltaTime, Space.Self);
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("HITTT");
        if (other.name == "EnemieNew")
        {
            
            Destroy(EnemieNew, 2f);
            Destroy(heavyBullet1, 2f);
            // playerCollides with the Enemy

        }
    }



}
