using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCannonScript : MonoBehaviour
{
    public bool isactive = false;
    public GameObject player;
    [SerializeField]
    private GameObject Bullet;
    [SerializeField]
    private int shootvel;
    [SerializeField]
    private float firerate;
    private float fire;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        fire -= 1 * Time.deltaTime;
        if(isactive == true)
        {
            transform.forward = (transform.forward +  player.transform.position) - transform.position;

            if (fire < 0)
            {


                GameObject enemybullet = Instantiate(Bullet, transform.position, Quaternion.identity);
                enemybullet.GetComponent<Rigidbody>().AddForce(transform.forward * shootvel);
                enemybullet.GetComponent<Rigidbody>().AddForce(transform.up * (Vector3.Distance(player.transform.position, transform.position) / 10), ForceMode.VelocityChange);
                Destroy(enemybullet, 8f);
                fire = firerate;    
            }
        }
    }

    
}
