using UnityEngine;

public class DestroyOnPlayerCollision : MonoBehaviour
{
    // This method is called when a collision occurs.
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision occurred with the player.
        if (collision.gameObject.CompareTag("Player"))
        {
            
            // Destroy the object this script is attached to.
            Destroy(gameObject);
        }
    }
}
