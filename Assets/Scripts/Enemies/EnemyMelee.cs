using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SAE.GAD176.Project1
{
    public class EnemyMelee : Enemy, IDamageable
    {
        protected override void Shout()
        {
            base.Shout();
            
            if (playerReference != null)
            {
                if (Vector3.Distance(playerReference.transform.position, transform.position) < 10)
                {
                    Debug.Log("TASTE MY BLADE YOU FILTHY CASUAL! " + transform.name);
                }
            }

            //base.Shout();
        }


        protected override void HitPlayer()
        {
            if (playerReference)
            {
                if (Vector3.Distance(transform.position, playerReference.transform.position) <= 3)
                {
                    Debug.Log("Dealing Knife Damage to the filthy casual! " + transform.name);
                }
            }
        }


        //public override void ChangeHealth(float amount)
        //{
        //    base.ChangeHealth(amount);

        //    Debug.Log("Tactical Retreat! " + transform.name);
        //}
    }
}
