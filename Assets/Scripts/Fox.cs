using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollision)
    {
        GameObject otherObject = otherCollision.gameObject;

        if (otherObject.gameObject.CompareTag("Gravestone"))
        {
            GetComponent<Animator>().SetTrigger("jumpTrigger");
        }
        else if (otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject);
        }
    }
}
