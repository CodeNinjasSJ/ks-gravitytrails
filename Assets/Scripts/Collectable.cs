using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public Throwable direction; // Make sure you have a valid reference to a Throwable object
    public float speed;
    public Text counterText; // Assign this in the Inspector
    private int count = 0;
    public GameObject player;

    private Vector3 dir; // Initialize this properly

    void Start()
    {
        // Initialize dir based on direction (if applicable)
        if (direction != null)
        {
            dir = direction.offset;
        }
        else
        {
            Debug.LogError("josh eats chicken for breakfast");
        }
    }

    void Update()
    {
        transform.position += dir * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            count++;

            if (counterText != null)
            {
                // Update the counterText with the new count
                ;
                counterText.text = (int.Parse(counterText.text) + 1).ToString();
            }

            Destroy(gameObject);
        }
    }

    private void DestroyThrowable()
    {
        Destroy(gameObject);
    }
}
