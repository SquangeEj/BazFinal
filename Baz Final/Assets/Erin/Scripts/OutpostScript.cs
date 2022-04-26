using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutpostScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] WaypointSelector;
    [SerializeField]
    private GameObject[] waypoints1;
    [SerializeField]
    private GameObject[] waypoints2;
    [SerializeField]
    private GameObject[] waypoints3;
    [SerializeField]
    private GameObject[] waypoints4;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CaravanWaypoint(GameObject Caravan) 
    {
        int i = Random.Range(0, WaypointSelector.Length);
        {
            if (i == 0)
            {
                Caravan.GetComponent<CaravanController>().Waypoints = waypoints1;
            }
            if (i == 1)
            {
                Caravan.GetComponent<CaravanController>().Waypoints = waypoints2;
            }
            if (i == 2)
            {
                Caravan.GetComponent<CaravanController>().Waypoints = waypoints3;
            }
            if (i == 3)
            {
                Caravan.GetComponent<CaravanController>().Waypoints = waypoints4;
            }
        }

        
    }

}
