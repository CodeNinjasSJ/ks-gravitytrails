using UnityEngine;

public class DisableCollisionForPlayer : MonoBehaviour
{
    private Collider myCollider; // Reference to the collider of this GameObject

    private void Start()
    {
        myCollider = GetComponent<Collider>(); // Get the collider component of this GameObject
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the colliding GameObject has the tag "Player"
        {
            Physics.IgnoreCollision(myCollider, other, true); // Disable collision between this GameObject and the player
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Check if the colliding GameObject has the tag "Player"
        {
            Physics.IgnoreCollision(myCollider, other, false); // Enable collision between this GameObject and the player
        }
    }
}
