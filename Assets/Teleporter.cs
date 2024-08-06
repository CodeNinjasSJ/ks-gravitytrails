using UnityEngine;
using UnityEngine.SceneManagement;

public class Timothy : MonoBehaviour
{
    public int enemyCount;
    void Start()
    {
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
    }
}

