using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectile : MonoBehaviour
{
    public Throwable direction;
    public float speed;
    public Text counterText;
    private int count = 0;
    public GameObject player;

    private Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        dir = direction.offset;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * Time.deltaTime * speed;
    }

    // Handle collisions
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print(collision.gameObject.tag);
        if (collision.gameObject.CompareTag("Ground"))
        {

            Destroy(gameObject);
        }
    }

    private void DestroyThrowable()
    {
        Destroy(gameObject);
    }
}
