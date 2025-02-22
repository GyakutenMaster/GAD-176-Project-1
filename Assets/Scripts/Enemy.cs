using SAE.GAD176.Tutorials.Polymorphism;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected Player playerReference; // protected acts just like private, no other scrpts can access or modify it, unless it is inheriting from this class.
    [SerializeField] protected float health = 100;

    // Start is called before the first frame update
    protected virtual void Start()
    {
        // get a refenrence to the player
        playerReference = FindAnyObjectByType<Player>();
        Shout();
    }

    // Update is called once per frame
    protected virtual void Update()
    {

    }

    protected virtual void Shout() // If we want to override a function, it has to be a 'virtual' function.
    {
        if (playerReference)
        {
            if (Vector3.Distance(transform.position, playerReference.transform.position) < 5)
            {
                Debug.Log("Shouting out to others. " + transform.name);
            }
        }
        // play default shouting effect
    }

    protected virtual void RunAtPlayer()
    {
        if (playerReference)
        {
            if (Vector3.Distance(transform.position, playerReference.transform.position) < 10)
            {
                Debug.Log("Running straight at the player! " + transform.name);
            }
        }
    }

    public virtual void ChangeHealth(float amount)
    {
        health += amount;
    }
}
