using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float health = 100f;
    [SerializeField] GameObject deathVFX;


    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
            GameObject deathVFXObject = Instantiate(deathVFX, transform.position, transform.rotation);
            Destroy(deathVFXObject, 1f);
        }

    }
    private void Die()
    {
        Destroy(gameObject);
    }
}
