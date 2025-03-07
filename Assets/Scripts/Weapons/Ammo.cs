using UnityEngine;

namespace GAD176.Project1
{
    public class Ammo : MonoBehaviour
    {
        public int increasedAmmo = 30;
        public AudioClip collectedSound;
        public AudioSource sfx;
        private void OnTriggerEnter(Collider other)
        {
            // Check if the thing that has entered this trigger is the player by comparing the tag to Player.
            if (other.tag == "Player")
            {
                // Then access the player Character script by searching the collider for the script, GetComponent might be handy.
                // Do not forget to check that we have a reference before accessing functions/variables.
                if (other.GetComponent<PlayerInventory>() != null)
                {
                    // Increase the player's number of eggs by one.
                    other.GetComponent<PlayerInventory>().PickupAmmo();
                    // Check that we have a sound and sfx reference.
                    if (sfx != null && collectedSound != null)
                    {
                        // Call the play oneshot of the sfx source and pass in the collected sound.
                        sfx.PlayOneShot(collectedSound);
                    }
                    // Then destroy the egg.
                    Destroy(gameObject);
                }
            }
        }
    }
}
