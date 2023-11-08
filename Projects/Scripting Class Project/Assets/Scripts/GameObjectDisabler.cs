using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectDisabler : MonoBehaviour
{
    private void OnEnable()
    {
        var triggerEventsBehavior = FindObjectOfType<TriggerEventsBehavior>();
        if (triggerEventsBehavior != null)
        {
            triggerEventsBehavior.triggerExitEvent.AddListener(DisableGameObject);
        }
    }

    private void OnDisable()
    {
        var triggerEventsBehavior = FindObjectOfType<TriggerEventsBehavior>();
        if (triggerEventsBehavior != null)
        {
            triggerEventsBehavior.triggerExitEvent.RemoveListener(DisableGameObject);
        }
    }

    private void DisableGameObject()
    {
        gameObject.SetActive(false);
    }
}
