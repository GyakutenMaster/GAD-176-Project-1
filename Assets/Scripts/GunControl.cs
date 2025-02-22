using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunControl : MonoBehaviour
{
    public Transform gunTransform;
    public Transform gunFirePoint;
    public GameObject bulletPrefab; // the thing to shoot.
    public float projectileSpeed = 50;

    void Update()
    {
        RotateGunWithMouse();
    }

    void RotateGunWithMouse()
    {
        // grab the current mouse position screen
        //Vector3 mousePosition = Input.mousePosition;

        // convert the mouse position to a point world space.
        //Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, Camera.main.nearClipPlane));

        // calculate the direction from the cannon to the mouse position
        //Vector3 directionToMouse = worldMousePosition - cannonTransform.position;

        // calculate the launch angle in radians
        //float launchingAngleInRadians = Mathf.Atan2(directionToMouse.y, directionToMouse.x);

        // converting my radians to degrees.
        //float launchAngleInDegrees = launchingAngleInRadians * Mathf.Rad2Deg;

        // rotate the cannon to face the mouse cursor.
        //cannonTransform.rotation = Quaternion.Euler(0, 0, launchAngleInDegrees);

        if (Input.GetMouseButtonDown(0))
        {
            Fire(); 
        }
    }

    public void Fire()
    {
        GameObject clone = Instantiate(bulletPrefab, gunFirePoint.position, Quaternion.identity);

        clone.GetComponent<Rigidbody>().linearVelocity = gunFirePoint.forward * projectileSpeed;
    }
}