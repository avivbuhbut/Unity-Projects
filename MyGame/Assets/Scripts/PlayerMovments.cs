using System;
using UnityEngine;

public class PlayerMovments : MonoBehaviour
{



    public float jumpSpeed = 8f;

    public float speed = 2f;

    Rigidbody2D rigidbody2d;

    public float moveSpeed = 5f;
    //public float hitPoints = 100f;
    private Rigidbody2D rb;

    public GameObject bulletToRight, bulletToLeft;
    Vector2 bulletPos;
    public float fireRate = 0.5f;
    float nextFire = 0.0f;
    


    


    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }


        void FixedUpdate()
        {

            //Moving Left And RIgh
            if (Input.GetKey(KeyCode.LeftArrow))
                rigidbody2d.velocity = new Vector2(speed * -1, rigidbody2d.velocity.y);
            if (Input.GetKey(KeyCode.RightArrow))
                rigidbody2d.velocity = new Vector2(speed, rigidbody2d.velocity.y);

            /*JUMPING*/
            if (Input.GetButtonDown("Jump"))
                rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, jumpSpeed);


        }
        // Start is called before the first frame update
        //    void Start()
        //  {

        // }




        // Update is called once per frame
        void Update()
        {

            FixedUpdate();


        
          if(Input.GetButton("Fire1") && Time.time > nextFire )
        {
            nextFire = Time.time + fireRate;
            fire();
        }

       
    }



    

     void fire()
    {

 
        bulletPos = transform.position;
        if (transform.localScale.x > 0) // means the player is facing rihgt
        {
            bulletPos += new Vector2(+1f, -0.43f);
            Instantiate(bulletToRight, bulletPos, Quaternion.identity);
        }
        else
        {
            bulletPos += new Vector2(-1f, -0.43f);
            Instantiate(bulletToLeft, bulletPos, Quaternion.identity);
        }

        
    }
}
