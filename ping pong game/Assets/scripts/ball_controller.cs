using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_controller : MonoBehaviour {

    private Rigidbody2D ball;
    public GameObject bar_1;
    public GameObject bar_2;


	void Start () {
        ball = GetComponent<Rigidbody2D>();
        StartCoroutine(pause());
	}
	
	// Update is called once per frame
	void Update () {
		if(Mathf.Abs(transform.position.x)>=18)
        {
            Score_calculator.canaddscore = true;
            transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine(pause());
        }

	}

    IEnumerator pause()
    {
        int dirx = Random.Range(-1, 2);
        int diry = Random.Range(-1, 2);

        if (dirx == 0)
        {
            dirx = 1;
        }
        ball.velocity = new Vector2(0f, 0f);
        yield return new WaitForSeconds(2);
        ball.velocity = new Vector2(10f * dirx, 10f * diry);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bar_1")
        {
            if (bar_1.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                ball.velocity = new Vector2(10f, 10f);
            }
            else if (bar_1.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                ball.velocity = new Vector2(10f, -10f);
            }
            else {
                ball.velocity = new Vector2(18f, 0f);
            }
        }

        if (collision.gameObject.name == "bar_2")
        {
            if (bar_2.GetComponent<Rigidbody2D>().velocity.y > 0.5f)
            {
                ball.velocity = new Vector2(-10f, 10f);
            }
            else if (bar_2.GetComponent<Rigidbody2D>().velocity.y < -0.5f)
            {
                ball.velocity = new Vector2(-10f, -10f);
            }
            else
            {
                ball.velocity = new Vector2(-18f, 0f);
            }
        }
    }
}
