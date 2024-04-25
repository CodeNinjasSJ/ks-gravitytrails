using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Throwable direction;
    public float speed;

    private Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        dir  = direction.offset;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += dir * Time.deltaTime * speed;  
    }
    private void DestroyThrowable()
    {
        Destroy(gameObject);
    }
}               