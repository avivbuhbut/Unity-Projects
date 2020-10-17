using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{

    public GameObject bulet;
    public Transform start;
    private AudioSource audioSrc;

    Camera myCamera;
    public Camera m_CameraTwo;



    void Start()
    {


        GameObject cameraObject = GameObject.Find("Camera1"); // change for the name of the tag of the camera
        myCamera = cameraObject.GetComponent<Camera>();
        Vector2 mousePosition =
                        new Vector2(myCamera.ScreenToWorldPoint(Input.mousePosition).x,
                        myCamera.ScreenToWorldPoint(Input.mousePosition).y);

        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 gunpos = myCamera.ScreenToWorldPoint(Input.mousePosition);
        if (gunpos.x < transform.position.x)
        {
            transform.eulerAngles = new Vector3(transform.rotation.x, 180f, transform.rotation.z);

        }else {
                transform.eulerAngles = new Vector3(transform.rotation.x, 0f, transform.rotation.z);
            }


            if (Input.GetMouseButtonDown(0))
            {
            audioSrc.Play();
                shooting();
            }

        }


        void shooting()
        {
     
        GameObject shoot = Instantiate(bulet, start.transform.position, start.transform.rotation);
            Destroy(shoot, .5f);
        }
    }

