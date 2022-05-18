using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public float health;
    public int speed;
    [SerializeField]
    private NavMeshAgent agent;
    public GameObject player;
    public GameObject spawn;
    public GameObject director;
    public int deathpoints;
    public int state;
    [SerializeField]
    private GameObject[] cannons;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        agent = gameObject.GetComponent<NavMeshAgent>();
        director = GameObject.FindGameObjectWithTag("Director");

        GetComponent<NavMeshAgent>().speed = speed ;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawn == null)
        {
            Destroy(gameObject);
            return;
        }
        //takedamage(1);
        switch (state)
        {
            case 2:
                agent.SetDestination(transform.position - player.transform.position);
              
                break;
            case 1:
                agent.SetDestination(player.transform.position);
                
                break;
            case 0:
                agent.SetDestination(spawn.transform.position);
                break;
            default:
                state = 0;
                break;
        }


       
    }


    public void takedamage(int damage)
    {
        foreach(GameObject cannon in cannons)
        {
            cannon.GetComponent<EnemyCannonScript>().isactive = true;
        }
        GetComponent<NavMeshAgent>().speed = speed * 2;
        health -= damage;
        state = 1;
        if(health < 0)
        {
            director.GetComponent<CaravanManager>().ManagerPoints += deathpoints;
            Destroy(gameObject);
            
        }
    }
}
