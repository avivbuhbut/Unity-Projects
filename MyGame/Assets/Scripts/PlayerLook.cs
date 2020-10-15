using UnityEngine;
using System.Collections;

public class PlayerLook : MonoBehaviour
{

    public int shootingForce;

    public GameObject weapon;
    public GameObject projectile;
    public Transform parent;
    public Transform firePoint;

    //Cache
    Transform myTransform;
    Transform weaponsTrasform;
    Transform firePointTransform;



    Camera myCamera;
    public Camera m_CameraTwo;



    void Start()
    {
        myTransform = transform;
        weaponsTrasform = weapon.transform;
        firePointTransform = firePoint.transform;


        GameObject cameraObject = GameObject.Find("Camera1");
        myCamera = cameraObject.GetComponent<Camera>();
        Vector2 mousePosition =
                        new Vector2(myCamera.ScreenToWorldPoint(Input.mousePosition).x,
                        myCamera.ScreenToWorldPoint(Input.mousePosition).y);

    }

    void Update()
    {
        WeaponLookRotation();

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }

    }

    void WeaponLookRotation()
    {
        //Gets normalized rotation based on the position of the mouse
        Vector3 difference = myCamera.ScreenToWorldPoint(Input.mousePosition) - weaponsTrasform.position;
        difference.Normalize();

        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        //Updates the weapon's rotation depending on which way the player is looking
        if (parent.localScale.x == 1)
        {
            weaponsTrasform.rotation = Quaternion.Euler(0f, 0f, rotZ);
        }

        if (parent.localScale.x == -1)
        {
            weaponsTrasform.rotation = Quaternion.Euler(0f, 0f, -rotZ);
        }
    }

    void Fire()
    {
        if (parent.localScale.x == 1)
        {
            GameObject missile = Instantiate(projectile, firePoint.position, Quaternion.identity) as GameObject;
            firePointTransform.rotation = Quaternion.Euler(0f, 0f, -transform.rotation.z);
            missile.GetComponent<Rigidbody2D>().AddForce(firePointTransform.right * shootingForce);
        }

        if (parent.localScale.x == -1)
        {
            GameObject missile = Instantiate(projectile, firePoint.position, Quaternion.identity) as GameObject;
            firePointTransform.rotation = Quaternion.Euler(0f, 180f, -transform.rotation.z);
            missile.GetComponent<Rigidbody2D>().AddForce(firePointTransform.right * -shootingForce);
        }
    }
}