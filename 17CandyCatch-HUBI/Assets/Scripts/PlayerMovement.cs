using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{

    private float speedPlayer = 10f;
    private Rigidbody2D playerBody;

    void Awake ()
    {
        playerBody = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        Vector2 vel =  playerBody.velocity;
        vel.x = Input.GetAxis("Horizontal") * speedPlayer;
        playerBody.velocity = vel;
    }
}
