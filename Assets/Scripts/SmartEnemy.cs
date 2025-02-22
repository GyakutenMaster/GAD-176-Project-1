using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SAE.GAD176.Tutorials.Polymorphism
{
    public class SmartEnemy : Enemy
    {
        // Start is called before the first frame update
        protected override void Start()
        {
            base.Start();
            RunAtPlayer();
        }

        // Update is called once per frame
        protected override void Update()
        {

            //HitPlayer();
        }

        protected override void Shout()
        {
            if (playerReference != null)
            {
                if (Vector3.Distance(playerReference.transform.position, transform.position) < 1)
                {
                    Debug.Log("Stop Right There Criminal Scum " + transform.name);
                }
            }
        }

        public override void ChangeHealth(float amount)
        {
            base.ChangeHealth(amount);

            Debug.Log("RUNS STRIGHT AT THE PLAYER AND EXPLODED " + transform.name);
        }

        protected void HitPlayer()
        {
            if (playerReference)
            {
                if (Vector3.Distance(transform.position, playerReference.transform.position) < 1)
                {
                    Debug.Log("Dealing Damage to the player!");
                }
            }
        }
    }
}

