using UnityEngine;
public class EnemyFollowPlayer : MonoBehaviour
{
    public GameObject Player;
    public float movementSpeed = 50;
    void Update()
    {
        transform.LookAt(Player.transform);
        transform.position += transform.forward * movementSpeed * Time.deltaTime;
    }
    void OnCollisionEnter(Collision collisionInfo)
    {
        // We check if the object we collided with has a tag called "Obstacle".
        if (collisionInfo.collider.tag == "Obstacle")
        {
            
           
            

        }
    }
}