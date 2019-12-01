using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public playerMove movement;     // A reference to our PlayerMovement script


    void OnCollisionEnter(Collision collisionInfo)
    {
        // We check if the object we collided with has a tag called "Obstacle".
        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
