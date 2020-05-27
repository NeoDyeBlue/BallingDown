using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlyrMovement : MonoBehaviour
{

    public Rigidbody Rb;
    public float movSpeed;
 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKey("a"))
        {
            Rb.AddForce(-movSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            Rb.AddForce(movSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
