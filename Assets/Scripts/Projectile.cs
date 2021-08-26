using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float damage = 25f;

    [SerializeField] float projectileSpeed = 1f;

/*    [SerializeField] float spinningSpeed = 11f;    
*/    void Update ()
    {
        transform.Translate(Vector2.right * projectileSpeed * Time.deltaTime);
/*        transform.Rotate(0, 0, spinningSpeed * Time.deltaTime);
*/   }


    private void OnTriggerEnter2D(Collider2D other)
    {
        var health = other.gameObject.GetComponent<Health>();
        var attacker = other.GetComponent<Attacker>();
        if(attacker && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);
        }
        
    }

}
