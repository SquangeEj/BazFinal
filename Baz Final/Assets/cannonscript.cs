using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonscript : MonoBehaviour
{
    [SerializeField]
    private GameObject Bullet;
    [SerializeField]
    private float fire,firerate,range;
    [SerializeField]
    private AudioSource soundsource;
    // Update is called once per frame
    void Update()
    {
        fire -= 1 * Time.deltaTime;
        if (Input.GetKey(KeyCode.Space) && fire < 0)
        {
            soundsource.Play(); 
            GameObject bullet = Instantiate(Bullet, transform.position + new Vector3 (0,5,0), Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.right * -range);
            fire = firerate;
        }
    }
}
