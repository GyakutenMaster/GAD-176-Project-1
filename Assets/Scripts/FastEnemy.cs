using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SAE.GAD176.Tutorials.Polymorphism
{
    public class FastEnemy : Enemy
    {
        protected override void Shout()
        {
            //base.Shout();

            // do my base Shout first, then do my extra functionality here, or swap it around to functionality first then base Shout.
            if (playerReference != null)
            {
                if (Vector3.Distance(playerReference.transform.position, transform.position) < 10)
                {
                    Debug.Log("REEEEEEEhh " + transform.name);
                }
            }

            //base.Shout();
        }

        // Update is called once per frame
        protected override void Update()
        {
            RunAtPlayer();
        }

        public override void ChangeHealth(float amount)
        {
            base.ChangeHealth(amount);

            Debug.Log("Run AWAY I'm Scareds! " + transform.name);
        }
    }
}
