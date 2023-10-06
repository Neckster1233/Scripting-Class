using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PickUpItem : MonoBehaviour

{
    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup();
        }
    }

    void Pickup()
    {
        Debug.Log("Item Picked Up");
        Destroy(gameObject);
    }
}