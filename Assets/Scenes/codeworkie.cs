using UnityEngine;

public class codeworkie : MonoBehaviour
{
    public GameObject targetObject; // Assign the object you want to activate in the Inspector

    private void Start()
    {
        if (targetObject != null)
        {
            print("working1");
            targetObject.SetActive(false); // Ensure the target object is inactive at the start
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            print("working");
            if (targetObject != null)
            {
                targetObject.SetActive(true); // Activate the target object on collision
            }
        }
    }
}
