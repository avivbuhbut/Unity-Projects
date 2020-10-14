using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform Gun;

    Vector2 direction;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
       
        direction = mousePos - (Vector2)Gun.position;
        faceMouse();


    }

    void faceMouse()
    {
        Gun.transform.right = direction;
    }
}
