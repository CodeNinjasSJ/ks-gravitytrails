using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Updater : MonoBehaviour
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
        // Initialize any necessary variables here
    }

    // Update is called once per frame
    void Update()
    {
        // Update logic here
    }

    // Handle collisions
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (counterText != null)
            {
                IncrementScore();
            }

            Destroy(gameObject);
        }
    }

    // Method to increment the score
    private void IncrementScore()
    {
        count++;
        counterText.text = "Score: " + count.ToString();
    }
}
