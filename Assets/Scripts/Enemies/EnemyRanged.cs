using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace SAE.GAD176.Project1
{
    public class EnemyRanged : Enemy, IDamageable
    {
        // Start is called before the first frame update
        protected override void Start()
        {
            base.Start();
        }


        protected override void Shout()
        {
            if (playerReference != null)
            {
                if (Vector3.Distance(playerReference.transform.position, transform.position) < 10)
                {
                    Debug.Log("EAT BULLETS YOU FILTHY CASUAL! " + transform.name);
                }
            }
        }


        //public override void ChangeHealth(float amount)
        //{
        //    base.ChangeHealth(amount);

        //    Debug.Log("RUNS STRIGHT AT THE PLAYER AND EXPLODED " + transform.name);
        //}

        protected override void HitPlayer()
        {
            if (playerReference)
            {
                if (Vector3.Distance(transform.position, playerReference.transform.position) < 10)
                {
                    Debug.Log("Dealing Gun Damage to the filthy casual! " + transform.name);
                }
            }
        }
    }
}

