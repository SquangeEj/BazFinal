using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCannonBall : MonoBehaviour
{

    [SerializeField]
    private int damage;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            if(other.gameObject.GetComponent<PlayerHealth>())
            {
                other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
            }
            Destroy(gameObject);
        }
       // Destroy(gameObject);
    }
}
