using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int maximumXPosition;
    public int minimumXPosition;
    public float yForce;
    public float xForce;
    public float xDirection;

    private Rigidbody2D enemyRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

         if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }

        if (collision.GetContact(0).normal.x > .1f)
        {
            xDirection = 1;
        }
        if (collision.GetContact(0).normal.x < -.1f)
        {
            xDirection = -1;
        }
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        enemyRigidBody.AddForce(Vector2.right * xForce * xDirection);
    }
}
