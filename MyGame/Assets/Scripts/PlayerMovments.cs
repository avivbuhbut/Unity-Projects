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


 

    


    


    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }


        void FixedUpdate()
        {

            //Moving Left And RIgh
            if (Input.GetKey(KeyCode.A))
                rigidbody2d.velocity = new Vector2(speed * -1, rigidbody2d.velocity.y);
            if (Input.GetKey(KeyCode.D))
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


      

       
   
    }
}
