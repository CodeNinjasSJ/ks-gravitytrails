using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Throwable : MonoBehaviour
{
    public GameObject objectThrown;
    public Vector3 offset;
    public Text collectableCounter;
    public float throwForce = 10f; // Add a throw force variable

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        offset = transform.localScale.x * new Vector3(1, 0, 0);
        Vector3 throwablePosition = transform.position + offset;

        if (Input.GetButtonDown("Fire1"))
        {
            GameObject thrownObject = Instantiate(objectThrown, throwablePosition, transform.rotation);
            Rigidbody rb = thrownObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
            }
        }
    }
}
