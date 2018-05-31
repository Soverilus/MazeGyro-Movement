using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class MovementScript : MonoBehaviour {
    Rigidbody2D playerRB;
    public float maxVel;
    Vector2 moveInput;
    Vector2 moveInputRaw;
    public float velMult;

	void Start () {
        playerRB = GetComponent<Rigidbody2D>();
	}
	
	void Update () {

	}

    private void FixedUpdate() {
        moveInputRaw = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            playerRB.AddForce(moveInput * velMult);
        if (playerRB.velocity.magnitude > maxVel) {
            playerRB.AddForce(playerRB.velocity.normalized *- velMult);
        }
    }
}
