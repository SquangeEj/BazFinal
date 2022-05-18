using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    [SerializeField]
    private int damage;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            if (other.GetComponent<EnemyScript>())
            {
                other.GetComponent<EnemyScript>().takedamage(damage);
                Debug.Log("Worked");

                Destroy(gameObject);
            }
        }
        else
        {
            StartCoroutine(death());
        }
    }
    

    IEnumerator death()
    {
        yield return new WaitForSeconds(5f);

        Destroy(gameObject);

        yield return null;
    }
}
