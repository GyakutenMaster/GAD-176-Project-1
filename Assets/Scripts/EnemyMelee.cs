using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SAE.GAD176.Project1
{
    public class EnemyMelee : Enemy
    {
        protected override void Shout()
        {
            base.Shout();
            
            if (playerReference != null)
            {
                if (Vector3.Distance(playerReference.transform.position, transform.position) < 3)
                {
                    Debug.Log("TASTE MY BLADE YOU FILTHY CASUAL! " + transform.name);
                }
            }

            //base.Shout();
        }

        // Update is called once per frame
        protected override void Update()
        {
                Move();
                Rotate();
                Retreat();
        }


        //public override void ChangeHealth(float amount)
        //{
        //    base.ChangeHealth(amount);

        //    Debug.Log("Tactical Retreat! " + transform.name);
        //}
    }
}
