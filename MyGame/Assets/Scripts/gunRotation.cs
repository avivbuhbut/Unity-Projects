using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunRotation : MonoBehaviour
{
    Camera myCamera;
    public Camera m_CameraTwo;



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
        Vector3 mousepos = Input.mousePosition;
        Vector3 gunposition = myCamera.WorldToScreenPoint(transform.position);
        mousepos.x = mousepos.x - gunposition.x;
        mousepos.y = mousepos.y - gunposition.y;
        float gunangle = Mathf.Atan2(mousepos.y, mousepos.x) * Mathf.Rad2Deg;
        if (myCamera.ScreenToWorldPoint(Input.mousePosition).x < transform.position.x)
        {
            transform.rotation = Quaternion.Euler(new Vector3(180f, 0f, -gunangle));
        }
        else
            transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, gunangle));
    }
}
