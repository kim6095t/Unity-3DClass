using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class BoxBomb : MonoBehaviour, IDamaged
{
    [SerializeField] ParticleSystem particle;
    [SerializeField] float hp;

    public void TakeDamage(float amount)
    {
        if((hp -= amount) <= 0.0f)
        {
            Bomb();
        }
    }

    private void OnMouseDown()
    {
        Bomb();
    }

    void Bomb()
    {
        ParticleSystem p = Instantiate(particle, transform.position, transform.rotation);
        p.Play();
        Destroy(gameObject);
    }

}
