using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private float health = 100;
    private float maxhealth = 100;
    [SerializeField]
    private GameObject slider;
    public GameObject death;
    [SerializeField]
    private GameObject player;
  

    // Update is called once per frame
    void Update()
    {
        if(health < maxhealth)
        {
            health += 1 * Time.deltaTime;
            slider.GetComponent<HealthBarScript>().SetHealth(health);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        slider.GetComponent<HealthBarScript>().SetHealth(health);

        if(health < 0)
        {
            death.SetActive(true);
            Destroy(player.GetComponent<PlayerMovement>());
        }

    }
}
