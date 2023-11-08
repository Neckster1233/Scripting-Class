using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }

    public ParticleSystem particleSystem;

    private void Start()
    {
        particleSystem.Stop(); // Make sure that the particle system is initally stopped
    }

    public void PlayParticles()
    {
        particleSystem.Play();
    }
}
