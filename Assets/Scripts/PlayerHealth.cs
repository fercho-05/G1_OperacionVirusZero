using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;

    [SerializeField]
    float currentHealth;

    [SerializeField]
    Image healthBar;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        healthBar.fillAmount = currentHealth / maxHealth;
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
