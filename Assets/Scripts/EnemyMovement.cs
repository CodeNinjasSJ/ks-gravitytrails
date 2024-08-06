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
    public GameObject shuriken;

    private Rigidbody2D enemyRigidBody;
    private List<GameObject> clones = new List<GameObject>(); // List to store clones

    // Start is called before the first frame update
    void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
        clones.Add(gameObject); // Add the original enemy object to the list
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "shuriken")
        {
            print("working");
            Destroy(collision.gameObject);
            Destroy(gameObject); // Destroy the original enemy object
        }

        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);
        }

        if (collision.GetContact(0).normal.x > 0.1f)
        {
            xDirection = 1;
        }
        if (collision.GetContact(0).normal.x < -0.1f)
        {
            xDirection = -1;
        }
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        enemyRigidBody.AddForce(Vector2.right * xForce * xDirection);
    }

    // Method to add clones to the list
    public void AddClone(GameObject clone)
    {
        clones.Add(clone);
    }

    // Method to remove clones from the list
    public void RemoveClone(GameObject clone)
    {
        clones.Remove(clone);
    }
}
