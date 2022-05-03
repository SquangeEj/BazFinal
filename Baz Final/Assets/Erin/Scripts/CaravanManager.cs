using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaravanManager : MonoBehaviour
{
    public int ManagerPoints;
    [SerializeField]
    private GameObject[] Outposts;
    [SerializeField]
    private GameObject[] Waypoints;
    [SerializeField]
    public GameObject Unit;

    // DELETE THIS JUST A TIMER
    public float lol = 60;
    public float spawnrate;

    // Update is called once per frame
    void Update()
    {
        lol -= 1;
        if(lol < 0)
        {
            lol = spawnrate ;
            SpawnCaravan();
        }

        
    }

    public void SpawnCaravan()
    {
       int i = Random.Range(0, Outposts.Length);
      //  Debug.Log(i);
        var caravan = Instantiate(Unit, Outposts[i].transform);
        caravan.GetComponent<CaravanController>().points = ManagerPoints / 2;
        ManagerPoints = ManagerPoints / 2;
        //  Debug.Log(ManagerPoints);
        caravan.GetComponent<CaravanController>().Director = gameObject;
        Outposts[i].GetComponent<OutpostScript>().CaravanWaypoint(caravan);
       // Debug.Log("succesful spawn");


    }
}
