using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SAE.GAD176.Project1
{
    public class Bullet : MonoBehaviour
    {
        private Rigidbody rigid;
        private float bulletSpeed = 10;
        private Enemy enemy;

        // Start is called before the first frame update
        void Start()
        {
            // here lets use a get component and grab the Rigibody attached to the bullet
            rigid = GetComponent<Rigidbody>();

            if (rigid)
            {
                // here let's set the rigidbody's velocity to 
                // be the the transform of what this script is attached to and access it's forward direction
                // we should then multiply this by the bullet speed.
                rigid.linearVelocity = transform.forward * bulletSpeed;
            }
        }
        private void OnTriggerEnter(Collider other)
        {
            // Check if the thing that has entered this trigger is the player by comparing the tag to Player.
            if (other.tag == "Enemy")
            {
                Destroy(gameObject);
            }
        }
    }
}
