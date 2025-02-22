using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angles : MonoBehaviour
{
    public Transform targetObject; // this will be my target that I will be using for angle detection.
    public float rotationalSpeed = 25f; // howfast we should be rotating.

    // Update is called once per frame
    void Update()
    {
        //CheckAngle();
        RotationalExample();
    }

    void RotationalExample()
    {
        // grabbing our input from unity, this will be between -1 and 1;
        float rotationalInput = Input.GetAxis("Horizontal");
        // calculating the rotation in radians using Mathf.Deg2Rad
        float rotationInRadians = rotationalInput * Mathf.Deg2Rad;

        // apply the roation
        transform.Rotate(Vector3.up, rotationInRadians * rotationalSpeed);
    }

    void CheckAngle()
    {
        if (targetObject == null)
        {
            return;
        }

        // is I want to get the direction from this object to my target.
        Vector3 directionToTarget = targetObject.position - transform.position;

        // calculate the angle between my forward direction to my target.
        float angle = Vector3.Angle(transform.forward, directionToTarget);

        Debug.Log("The angle is: " + angle);
        if(angle < 10)
        {
            // maybe I'm in the view cone range.
        }

        // in this case returning a signed angle i.e. positive or negative based on the axis we are checking against, in this case rotating the Y axis.
        float signedAngle = Vector3.SignedAngle(transform.forward, directionToTarget, Vector3.up);

        Debug.Log("The Signed angle is: " + signedAngle);

        if(signedAngle > -10 && signedAngle < 10)
        {
            if(Vector3.Distance(transform.position, targetObject.position) < 10)
            {
                Debug.Log("We are in the player's 20 degree view cone");
            } 
        }
    }
}
