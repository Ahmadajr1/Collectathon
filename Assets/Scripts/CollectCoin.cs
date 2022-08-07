using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    int collectedCoints = 0;
    private SoundManager sm;

    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            collectedCoints++;
            sm.PlayCoinCollect();
            Destroy(other.gameObject);
        }

        if (collectedCoints == 20)
        {
            sm.PlayWinSound();
            EndBoxScript endBox = GameObject.Find("Ending Box").GetComponent<EndBoxScript>();
            endBox.Activate();
            endBox.Move();
        }
    }

}
