using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
{


    public float firespeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * firespeed * Time.deltaTime, Space.Self);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject, 7f);
    }
}
