using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityFlip : MonoBehaviour
{
    public Rigidbody2D avatarRigidbody;
    public float gravityScale = -1f;
    private Rigidbody2D rb;
    private bool isBelowGround = false;
    private Vector3 originalScale;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        originalScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.gravityScale *= -1;
            ToggleBelowGround();

        }
    }

    void ToggleBelowGround()
    {
        isBelowGround = !isBelowGround;

       if (isBelowGround)
        {
            // Set player's scale to half in y direction
            transform.localScale = new Vector3(originalScale.x, originalScale.y / -1f, originalScale.z);
        }
        else
        {
            // Set player's scale back to original
            transform.localScale = originalScale;
        }
    }
}
