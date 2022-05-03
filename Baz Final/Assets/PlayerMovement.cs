using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private Rigidbody rb;
    [SerializeField]
    private int speed;
    [SerializeField]
    private int turnspeed;
    public GameObject yeahitis;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(transform.forward * speed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(transform.forward * -speed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddTorque(transform.up * turnspeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddTorque(transform.up * -turnspeed);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            yeahitis.SetActive(true);
        }
        else
        {
            yeahitis.SetActive(false);
        }

        if (Input.GetKey(KeyCode.U))
        {
            transform.rotation = new Quaternion(0, transform.rotation.y, 0, 0);
        }
    }

    
}
