using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyScript : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] int damage;

    private PlayerStatus playerStatus;
    private Rigidbody playerRB;
    private float pushBackModifier = 5000;

    private void Start()
    {
        playerStatus = player.GetComponent<PlayerStatus>();
        playerRB = player.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -30)
        {
            Destroy(gameObject);
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            playerStatus.AttackPlayer(damage);

            // Assigned position to local variables inorder to zero the y without affecting their actual positions. (For knockout calculation purposes)
            Vector3 playerPosition = collision.transform.position;
            Vector3 enemyPosition = transform.position;
            playerPosition.y = 0;
            enemyPosition.y = 0;
            Vector3 pushBackDirection = (playerPosition - enemyPosition).normalized;
            playerRB.AddForce(pushBackDirection * pushBackModifier);
        }   
    }
}
