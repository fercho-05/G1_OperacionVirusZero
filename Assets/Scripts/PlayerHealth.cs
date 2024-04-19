using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        if (IsAlive())
        {
            currentHealth -= damage;
            // Aqu� puedes agregar efectos visuales, sonidos, etc., cuando el jugador recibe da�o
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
        // L�gica para la muerte del jugador
        Debug.Log("Player has died!");
        // Aqu� puedes agregar m�s acciones al morir, como reiniciar el nivel, mostrar pantalla de Game Over, etc.
    }
}
