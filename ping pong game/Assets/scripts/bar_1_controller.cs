using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar_1_controller : MonoBehaviour {
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = new Vector2(0f, 12f);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = new Vector2(0f, -12f);
        }
        else
        {
            rb.velocity = new Vector2(0f, 0f);
        }
	}
}
