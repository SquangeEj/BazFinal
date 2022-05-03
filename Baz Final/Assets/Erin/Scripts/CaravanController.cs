using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CaravanController : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject[] Waypoints;
    private int currentpoint;
    public GameObject Director;
    [SerializeField]
    private float disttopoint;
    [SerializeField]
    private GameObject BoatSpawn;
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(Waypoints[currentpoint].transform.position);

        if (points >= 1)
        {
            for (int i = 0; i <= points; i += 1)
            {
                for (int z = 0; z <= points; z += 1)
                {
                    GameObject go = Instantiate(BoatSpawn, transform.position + new Vector3((i - points / 2)*2, 0, (z - points / 2)*2), Quaternion.identity);
                    go.transform.parent = transform;
                }

            }
        }
        else;
        {
            GameObject go = Instantiate(BoatSpawn, transform.position, Quaternion.identity);
            go.transform.parent = transform;
        }

    }

    // Update is called once per frame
    void Update()
    {
        disttopoint = Vector3.Distance(Waypoints[currentpoint].transform.position, transform.position);
        if (disttopoint < 10)
        {

            NextPoint();
           // Debug.Log(currentpoint + " " + disttopoint);
        }
    }


    void NextPoint()
    {
        currentpoint = (currentpoint + 1) % Waypoints.Length;
        agent.SetDestination(Waypoints[currentpoint].transform.position);
        if(currentpoint == Waypoints.Length -1 )
        {

            Director.GetComponent<CaravanManager>().ManagerPoints += points * Random.Range(0,3);
            Debug.Log(currentpoint + "  current " + Waypoints.Length) ;
            Destroy(gameObject);
        }
    }
}
