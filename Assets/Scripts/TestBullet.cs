using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamaged
{
    void TakeDamage(float amount);
}

public class TestBullet : MonoBehaviour
{
    [SerializeField] float power;

    List<ParticleSystem.Particle> enter = new List<ParticleSystem.Particle>();
    ParticleSystem ps;

    private void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("IN");

        IDamaged target = other.gameObject.GetComponent<IDamaged>();
        if (target != null)
            target.TakeDamage(power);
    }
}
