using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponAimNShoot : MonoBehaviour
{


    public float bulletVelocity = 5f;

    public GameObject bullet1;
    Camera myCamera;
    // Use this for initialization
    void Start()
    {

        GameObject cameraObject = GameObject.Find("Camera1"); // change for the name of the tag of the camera
        myCamera = cameraObject.GetComponent<Camera>();
        Vector2 mousePosition =
                        new Vector2(myCamera.ScreenToWorldPoint(Input.mousePosition).x,
                        myCamera.ScreenToWorldPoint(Input.mousePosition).y);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 worldMousePos = myCamera.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (Vector2)((worldMousePos - transform.position));
            direction.Normalize();
            // Creates the bullet locally
            GameObject bullet = (GameObject)Instantiate(
                                    bullet1,
                                    transform.position + (Vector3)(direction * 0.5f),
                                    Quaternion.identity);
            // Adds velocity to the bullet
            bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletVelocity;
        }
    }
}