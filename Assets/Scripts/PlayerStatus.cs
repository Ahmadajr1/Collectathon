using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class PlayerStatus: MonoBehaviour
{
    [SerializeField] private Image healthBar;

    private float health = 1;

    public void AttackPlayer(float damage)
    {
        health -= damage;
    }

    private void Update()
    {
        healthBar.fillAmount = health;
        if (health <= 0.2)
            die();
    }

    private void die()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
