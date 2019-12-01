using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private float speed = 20.0f;
    public GameObject character;
    public Rigidbody rb;

    // We marked this as "Fixed"Update because we
    // are using it to mess with physics.
 
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(0, 10, 0, ForceMode.VelocityChange);
            Debug.Log("jump");
          
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.forward * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
        }

       
    }
}