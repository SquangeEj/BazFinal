using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CaravanController : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject[] Waypoints;
    private int currentpoint;
    [SerializeField]
    private float disttopoint;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(Waypoints[currentpoint].transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        disttopoint = Vector3.Distance(Waypoints[currentpoint].transform.position, transform.position);
        if (disttopoint < 5)
        {

            NextPoint();
        }
    }


    void NextPoint()
    {
        currentpoint = (currentpoint + 1) % Waypoints.Length;
        agent.SetDestination(Waypoints[currentpoint].transform.position);
    }
}
