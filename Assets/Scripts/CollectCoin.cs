using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectCoin : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI coinText;
    int collectedCoints = 0;
    private SoundManager sm;

    // Start is called before the first frame update
    void Start()
    {
        sm = GameObject.Find("Sound Manager").GetComponent<SoundManager>();
    }

    private void Update()
    {
        coinText.SetText("" + collectedCoints);
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
