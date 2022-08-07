using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.y < -30)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
