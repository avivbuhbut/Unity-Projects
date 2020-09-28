using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;


public class Player : MonoBehaviour
{
    [Tooltip("in ms")] [SerializeField] float Xspeed = 40f;
    [Tooltip("in m")] [SerializeField] float Yspeed = 40f;

    [SerializeField] float positionPitchFactor = -2.46f;
    [SerializeField] float controlPitchFactor = -20f;
    [SerializeField] float  positionYawFactor = 5f;
    [SerializeField] float controlRollFactor = 5f; 

    float XThrow; /*teset*/
    float YThrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessTranslation();
        ProcessRotation();


        // attamting to create a rotation when turning left

    }

    private void ProcessRotation() //rotate the ship
    {
        float pitch = transform.localPosition.y * positionPitchFactor + YThrow * controlPitchFactor;
        float yaw = transform.localPosition.x * positionYawFactor;
        float roll = XThrow * controlRollFactor;

        transform.localRotation = Quaternion.Euler(pitch, yaw, roll);
    }

    private void ProcessTranslation()
    {
         XThrow = CrossPlatformInputManager.GetAxis("Horizontal"); // getting the current axis
         float xOffset = XThrow * Xspeed * Time.deltaTime; // how many cm or meters i need to move in the frame 
        print(xOffset);

        float rawNewXPos = transform.localPosition.x + xOffset;


        /*MOVING LEFT AND RIGHT:
         * change the x only of the  ship (to move left and right), z and y  stays as they are
         *Mathf.clamp is a method to restrict the movemnt of one of the axis, in that case its the x*/
        transform.localPosition = new Vector3(Mathf.Clamp(rawNewXPos, -10f, 10f), transform.localPosition.y, transform.localPosition.z);

        /*Moving Up and Down*/

        float YThrow = CrossPlatformInputManager.GetAxis("Vertical"); // getting the current axis
        float yOffset = YThrow * Yspeed * Time.deltaTime; // Time.deltaTime is the time passed between the last frame to the current
        print(yOffset);

        float rawNewYPos = transform.localPosition.y + yOffset;

        transform.localPosition = new Vector3(transform.localPosition.x, Mathf.Clamp(rawNewYPos, -10f, 10f), transform.localPosition.z);
    }
}
