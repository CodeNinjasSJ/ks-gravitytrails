using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporter : MonoBehaviour
{
    public int enemyCount;
    void Update()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        print("fludglopschmligginss, (und viele eichoenchen");
        if(collision.gameObject.tag == "Player" && enemyCount == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}

