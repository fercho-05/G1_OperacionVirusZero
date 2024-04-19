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
            // Aquí puedes agregar efectos visuales, sonidos, etc., cuando el jugador recibe daño
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
        // Lógica para la muerte del jugador
        Debug.Log("Player has died!");
        // Aquí puedes agregar más acciones al morir, como reiniciar el nivel, mostrar pantalla de Game Over, etc.
    }
}
