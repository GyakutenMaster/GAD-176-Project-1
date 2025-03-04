using StarterAssets;
using UnityEngine;
using UnityEngine.AI;

namespace SAE.GAD176.Project1
{
    public class Enemy : MonoBehaviour, IDamageable
    {
        protected FirstPersonController playerReference; // protected acts just like private, no other scrpts can access or modify it, unless it is inheriting from this class.
        [SerializeField] protected float health = 100;

        [SerializeField] protected Transform targetPosition;
        [SerializeField] protected float moveSpeed = 0.5f;
        private Vector3 referenceVelocity = Vector3.zero; // this used to store our previous velocity
        [SerializeField] protected float smoothness = 5f;
        [SerializeField] protected Vector3 targetRotation;

        protected NavMeshAgent agent;
        protected RetreatPoint retreatPoint;

        // Start is called before the first frame update
        protected virtual void Start()
        {
            // get a refenrence to the player
            playerReference = FindAnyObjectByType<FirstPersonController>();
            Shout();
        }

        // Update is called once per frame
        protected virtual void Update()
        {
            Move();
            Rotate();
        }

        protected virtual void Shout() // If we want to override a function, it has to be a 'virtual' function.
        {
            if (playerReference)
            {
                if (Vector3.Distance(transform.position, playerReference.transform.position) < 10)
                {
                    Debug.Log("Shouting out to others. " + transform.name);
                }
            }
            // play default shouting effect
        }

        public virtual void ChangeHealth(float amount)
        {
            health += amount;
        }

        protected virtual void Move()
        {
            // Lerp = linear interpolation
            transform.position = Vector3.Lerp(transform.position, targetPosition.position, moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, playerReference.transform.position) < 3)
            {
                moveSpeed = 0;
                HitPlayer();
            }
        }

        protected virtual void Rotate()
        {
            // lerp
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(targetRotation), smoothness * Time.deltaTime);
        }

        protected virtual void Retreat()
        {
            if(health <= 50)
            {
                //agent.SetDestination(retreatPoint.OnDrawGizmos());
            }
        }

        protected virtual void HitPlayer()
        {
            if (playerReference)
            {
                if (Vector3.Distance(transform.position, playerReference.transform.position) < 3)
                {
                    Debug.Log("Dealing Damage to the player!");
                }
            }
        }

        public void Kill()
        {
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }

        public bool IsAlive() => health > 0;
    }
}
