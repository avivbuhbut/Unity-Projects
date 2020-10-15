using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipAcourdMouse : MonoBehaviour


{

    public Transform playerTransform;
    public Collider playerCollider;


    Camera myCamera;
    public Camera m_CameraTwo;


    // Start is called before the first frame update
    void Start()
    {
        GameObject cameraObject = GameObject.Find("Camera1");
        myCamera = cameraObject.GetComponent<Camera>();
        Vector2 mousePosition =
                        new Vector2(myCamera.ScreenToWorldPoint(Input.mousePosition).x,
                        myCamera.ScreenToWorldPoint(Input.mousePosition).y);

    
}

    // Update is called once per frame
    void Update()
    {
        /*
        if (myCamera.ScreenToWorldPoint(Input.mousePosition).x > playerCollider.bounds.center.x)
        {
            playerTransform.localScale = new Vector3(1, 1, 1);
        }

        if (myCamera.ScreenToWorldPoint(Input.mousePosition).x < playerCollider.bounds.center.x)
        {
            playerTransform.localScale = new Vector3(-1, 1, 1);
        }
    */
    }
}
