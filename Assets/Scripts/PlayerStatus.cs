using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Unity.UI;

public class PlayerStatus: MonoBehaviour
{
    [SerializeField] TextMeshProUGUI healthText;

    private int health = 3;

    public void AttackPlayer(int damage)
    {
        health -= damage;
    }

    private void Update()
    {
        healthText.SetText("" + health);
        if (health < 1)
            die();
    }

    private void die()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
