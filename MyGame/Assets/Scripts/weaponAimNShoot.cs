using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponAimNShoot : MonoBehaviour

   
{


    [SerializeField]
    private Transform WeaponTip;

    [SerializeField]
    private GameObject bullet;

    private Vector2 lookDirection;

    private float lookAngle;


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
        lookDirection = myCamera.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        lookAngle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, lookAngle - 90f);

        if(Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }


    }


    private void FireBullet()
    {
        GameObject firedBullet = Instantiate(bullet, WeaponTip.position, WeaponTip.rotation);
        firedBullet.GetComponent<Rigidbody2D>().velocity = WeaponTip.up *10f;
}




}


