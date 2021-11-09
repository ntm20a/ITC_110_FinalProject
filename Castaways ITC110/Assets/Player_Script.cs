using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
    public float moveSpeed = 10.0f;

    Rigidbody2D PlayerRigidBody;


    // Start is called before the first frame update
    void Start()
    {
        PlayerRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // How we move
        float horizontalInput = Input.GetAxis("Horizontal");

        // Get the horizontal input value
        transform.Translate(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime);
        // Move the object to XYZ coordinates defined as horizontalInput, 0, and 0 respectively

    }
}
