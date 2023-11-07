using UnityEngine;

public class HealthPowerUp : ScriptableObject
{
    [SerializeField] private FloatData healthValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Apply the health value to the player
            ApplyHealth(other.gameObject);
            
            // Destroy the power up Game Object
            Destroy(gameObject);
        }
    }

    private void ApplyHealth(GameObject player)
    {
        // Retrieve the player's health component i.e. HealthController Script
        HealthController healthController = player.GetComponent<HealthController>();
        
        // Check if the player has a health component
        if (healthController != null)
        {
            // Add the health value to the player's current health
            healthController.AddHealth(healthValue.value);
        }
    }
}
