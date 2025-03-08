using StarterAssets;
using UnityEngine;
using UnityEngine.AI;

namespace SAE.GAD176.Project1
{
    public class Enemy : MonoBehaviour, IDamageable
    {
        protected FirstPersonController playerReference; // protected acts just like private, no other scrpts can access or modify it, unless it is inheriting from this class.
        [SerializeField] protected float health = 200;

        [SerializeField] protected Transform targetPosition;
        [SerializeField] protected float moveSpeed = 0.5f;
        private Vector3 referenceVelocity = Vector3.zero; // this used to store our previous velocity
        [SerializeField] protected float smoothness = 5f;
        [SerializeField] protected Vector3 targetRotation;

        public NavMeshAgent agent;
        public Transform retreatPoint;
        bool isFollowing = true;

        // Start is called before the first frame update
        protected virtual void Start()
        {
            // get a refenrence to the player
            playerReference = FindAnyObjectByType<FirstPersonController>();
            Debug.Log("Player Reference = " + playerReference.name);
            agent = GetComponent<NavMeshAgent>();
            isFollowing = true;
            Shout();
        }

        // Update is called once per frame
        protected virtual void Update()
        {
            if (health <= 100)
            {
                isFollowing = false;
                Retreat();
            }
            else if (isFollowing)
            {
                Move();
            } 
            Kill();
        }

        protected virtual void Shout() // If we want to override a function, it has to be a 'virtual' function.
        {
            if (playerReference)
            {
                Debug.Log("Shouting out to others. " + transform.name);
            }
            // play default shouting effect
        }

        private void OnTriggerEnter(Collider other)
        {
            // Check if the thing that has entered this trigger is the player by comparing the tag to Player.
            if (other.tag == "Bullet")
            {
                ChangeHealth(-20);
            }
        }

        protected virtual void ChangeHealth(float amount)
        {
            health += amount;
        }

        protected virtual void Move()
        {
            agent.SetDestination(playerReference.transform.position);
        }

        protected virtual void Rotate()
        {
            // lerp
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(targetRotation), smoothness * Time.deltaTime);
        }

        protected virtual void Retreat()
        {
            agent.SetDestination(retreatPoint.position);
        }

        protected virtual void HitPlayer()
        {
            if (playerReference)
            {
                if (Vector3.Distance(transform.position, playerReference.transform.position) < 3)
                {
                    Debug.Log("Dealing Damage to the filthy casual!");
                }
            }
        }

        public void Kill()
        {
            if (health <= 0)
            {
                Destroy(gameObject);
                Debug.Log("You killed the enemy, you filthy casual!");
            }
        }
    }
}
