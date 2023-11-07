using UnityEngine;

public class AmmoPowerUp : MonoBehaviour
{
    [SerializeField] private IntData ammoValue;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Add Ammo to the player's weapon
            AddAmmo(other.gameObject);
            
            // Destroy the game object
            Destroy(gameObject);
        }
    }

    private void AddAmmo(GameObject player)
    {
        // Retrieve the player's weapon component i.e. Weapon Controller Script
        WeaponController weaponController = player.GetComponent<WeaponController>();
        
        // Check if the player has a weapon component
        if (weaponController != null)
        {
            // Add the ammo value to the player's current ammo count
            weaponController.AddAmmo(ammoValue.value);
        }
    }
}
