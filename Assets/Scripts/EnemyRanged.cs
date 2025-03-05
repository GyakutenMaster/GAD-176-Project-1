using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace SAE.GAD176.Project1
{
    public class EnemyRanged : Enemy
    {
        // Start is called before the first frame update
        protected override void Start()
        {
            base.Start();
        }

        // Update is called once per frame
        protected override void Update()
        {
            Move();
            Rotate();
            //HitPlayer();
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

        protected override void Move()
        {
            // Lerp = linear interpolation
            transform.position = Vector3.Lerp(transform.position, targetPosition.position, moveSpeed * Time.deltaTime);
            if (Vector3.Distance(transform.position, playerReference.transform.position) < 10)
            {
                moveSpeed = 0;
                HitPlayer();
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
                    Debug.Log("Dealing Damage to the player!");
                }
            }
        }
    }
}

