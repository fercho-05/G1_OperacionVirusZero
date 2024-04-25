using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;

    [SerializeField]
    float currentHealth;

    [SerializeField]
<<<<<<< Updated upstream
    Image healthBar;
=======
    float healthMedKit;

    [SerializeField]
    Image healtBar;

    bool valMedkit;
>>>>>>> Stashed changes

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
<<<<<<< Updated upstream
        healthBar.fillAmount = currentHealth / maxHealth;
    }

=======
        healtBar.fillAmount = currentHealth / maxHealth;
    }
>>>>>>> Stashed changes
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

<<<<<<< Updated upstream
    
    
=======
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            RestoreHealth(true);
        }
    }
    public void RestoreHealth(bool takeMedkit)
    {
        valMedkit = takeMedkit;
        if (valMedkit)
        {
            healthMedKit += currentHealth;
        }        
    }
>>>>>>> Stashed changes

}
