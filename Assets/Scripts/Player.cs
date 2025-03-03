using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class Player : MonoBehaviour
    {
        // public Weapon myWeapon;
        // public List<Weapon> inventory = new List<Weapon>();
        // For example, all guns will have the same basic function.

        public List<Enemy> allEnemiesInScene = new List<Enemy>();

        // Start is called before the first frame update
        void Start()
        {
            // search the scene for all the enemies, this include scripts inherit from enemy
            allEnemiesInScene.AddRange(FindObjectsOfType<Enemy>());

            for (int i = 0; i < allEnemiesInScene.Count; i++)
            {
                allEnemiesInScene[i].ChangeHealth(-20);
            }
        }

        // Update is called once per frame
        void Update()
        {
            // if the mouse click is pressed
            // myWeapon.Fire()
        }
    }
