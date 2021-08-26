using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lizard : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D otherCollision)
    {
        GameObject otherObject = otherCollision.gameObject;

        if (otherObject.GetComponent<Defender>())
        {
            GetComponent<Attacker>().Attack(otherObject);
        }
    }
}
