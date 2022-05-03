using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaravanPointScript : MonoBehaviour
{
    public int point;
    [SerializeField]
    private GameObject[] skiffs;
    void Start()
    {
        if (point >= 10)
        {
            GameObject skiff = Instantiate(skiffs[0], transform.position, Quaternion.identity);
            skiff.GetComponent<EnemyScript>().spawn = this.gameObject;
        }
        else if (point >= 5 && point < 10)
        {
            GameObject skiff = Instantiate(skiffs[1], transform.position, Quaternion.identity);
            skiff.GetComponent<EnemyScript>().spawn = this.gameObject;
        }
        else if (point < 5)
        {
            GameObject skiff = Instantiate(skiffs[2], transform.position, Quaternion.identity);
            skiff.GetComponent<EnemyScript>().spawn = this.gameObject;
        }
    }

   
}
