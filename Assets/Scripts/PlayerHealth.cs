using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;

    [SerializeField]
    float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        if (IsAlive())
        {
            currentHealth -= damage;
        }

        if (!IsAlive())
        {
            Die();
        }
    }

    public bool IsAlive()
    {
        return currentHealth > 0f;
    }

    private void Die()
    {
        Debug.Log("Player has died!");
        SceneManager.LoadScene("GameOver");
    }

    public void TakeDamageOfZombies(float damage)
    {
        currentHealth -= Mathf.Abs(damage);

        if (currentHealth <= 0.0F)
        {
            Die();
        }
    }

}
