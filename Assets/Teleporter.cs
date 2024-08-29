using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timothy : MonoBehaviour
{
    public int enemyCount;
    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
    private void OnTriggerEnter2D(Collision2D collision)
    {
       if(collision.gameObject.CompareTag ("Player") && enemyCount == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}

