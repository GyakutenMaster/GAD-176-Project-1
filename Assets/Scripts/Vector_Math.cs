using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vector_Math : MonoBehaviour
{
    public Transform otherObject;
    public float moveSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        // addition of vectors.
        // subtraction of vectors.
        // dot product of vectors.
        // Normalisation of vectors.
        // Magnitude of vectors.
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    AddVectors();
        //}
        //if(Input.GetKeyDown(KeyCode.E))
        //{
        //    SubtractVectors();
        //}
        //ShoutIfClose();
        FacingDirection();
    }

    void AddVectors()
    {
        // addition of vectors
        //when we take two vectors and add them together we get a new position.
        transform.position += new Vector3(0, 0, -1);
    }

    void SubtractVectors()
    {
        if(otherObject == null)
        {
            return;
        }
        // subtracting vectors
        // when we subtract two vectors what we get is the direction to and from.
        Vector3 direction = (otherObject.transform.position - transform.position);
        Debug.Log("length is: " + direction.magnitude); // this will give me the length of this vector.
        direction = direction.normalized; // normalised vector is scaling this down between 0 ~ 1
        Debug.Log("normalised length is: " + direction.magnitude);
        Debug.Log(Vector3.Distance(transform.position, otherObject.position)); // the distance function gives the distance between two points.

        transform.position += direction * moveSpeed * Time.deltaTime; 
    }

    void ShoutIfClose()
    {
        if(Vector3.Distance(transform.position, otherObject.position) < 1f)
        {
            Debug.Log("I'm Close!");
        }
    }

    void FacingDirection()
    {
        // this will give me one of the following three numbers.
        // 0 = right angles to each other
        // 1 = facing the same direction
        // -1 = facing the opposite direction
        Debug.Log(Vector3.Dot(transform.forward,otherObject.forward));

        if(Vector3.Dot(transform.forward, otherObject.forward) > 0 && Vector3.Dot(transform.forward, otherObject.forward) <= 1)
        {
            // we are facing the same
        }
        else if (Vector3.Dot(transform.forward, otherObject.forward) < 0 && Vector3.Dot(transform.forward, otherObject.forward) <= -1)
        {
            // we are facing the opposite
        }
        else
        {
            // we are at the right angles to each other
        }
    }
}
