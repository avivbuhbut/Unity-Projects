

     using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class gunShooting : MonoBehaviour
{
    public Transform Bullet;
    public Transform MuzzleFlash;
    public Transform Spawn;
    public AudioSource Shot;
    public AudioSource noAmmo;
    public Transform muzzleSpawn;
    public Animation reload;
    //Gun Stuff
    public int bulletsPerMag = 30;
    public int usingBulletPerMag;
    public int overallAmmo;
    public UnityEngine.UI.Text ammoDisplay;
    public UnityEngine.UI.Text gunDisplay;



    void Start()
    {
        usingBulletPerMag = bulletsPerMag;
    }
    void Update()
    {
        ammoDisplay.text = usingBulletPerMag + "/" + overallAmmo;
        if (overallAmmo > 0)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                //overallAmmo -= bulletsPerMag - usingBulletPerMag;
                usingBulletPerMag = bulletsPerMag;
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (usingBulletPerMag > 0)
            {
                Shoot();
            }
            else
            {
                noAmmo.Play();
            }
        }
    }
    void Shoot()
    {
        Vector3 aimPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        aimPos.z = 0;

        //Creating the bullet and shooting it
        var pel = Instantiate(Bullet, Spawn.position, Spawn.rotation);
        pel.GetComponent<Rigidbody2D>().AddForce(aimPos.normalized * 8000f);
        //Playing the bullet noise
        Shot.Play();
        //shooting and reloading
        usingBulletPerMag -= 1;
    }

}
