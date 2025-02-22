using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SAE.GAD176.Tutorials.Kinematics // Kinematics are not affected by the game physics.
                                          // these will move/transform our objects, it all depends on the feel of the game you want to do.
{
    public class Kinematics : MonoBehaviour
    {
        [SerializeField] private Transform targetPosition;
        [SerializeField] private float moveSpeed = 1;
        private Vector3 referenceVelocity = Vector3.zero; // this used to store our previous velocity
        [SerializeField] private float smoothness = 0.5f;
        [SerializeField] private Vector3 targetRotation;
        [SerializeField] private float scaleSpeed = 1;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            Move();
            Rotate();
        }

        private void Move()
        {
            // Lerp = linear interpolation
            transform.position = Vector3.Lerp(transform.position, targetPosition.position, moveSpeed * Time.deltaTime);
            // smooth damp = gradually moving to a point, using velocity.
            //transform.position = Vector3.SmoothDamp(transform.position, targetPosition.position, ref referenceVelocity, moveSpeed);
            // move towards = effectively a straight line movement at a fixed pace.
            //transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, moveSpeed * Time.deltaTime);
        }

        private void Rotate()
        {
            // lerp
            //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(targetRotation), smoothness * Time.deltaTime);
            // slerp = spherical linear interpolation
            //transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(targetRotation), smoothness * Time.deltaTime);
            // rotatetowards
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(targetRotation), smoothness);
        }
    }
}
