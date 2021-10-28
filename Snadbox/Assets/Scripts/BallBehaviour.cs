using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    float speed;
    [SerializeField]
    float verticleSpeed;
    float existence = 5f;
    //just like with the bubbles, I get the component and add force forwards and upwards, and made them serialized fields so i could tweak the values in engine
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.forward * (speed / 2), ForceMode.VelocityChange);
        rb.AddForce(Vector3.up * verticleSpeed, ForceMode.VelocityChange);
    }
    //to make sure there are not too many balls all on the screen at once, this if statement destroys the ball after 5 seconds
    void Update()
    {
        if(existence >= 0)
        {
            existence -= Time.deltaTime;
        }
        else
        {
            Destroy(gameObject);
        }
    }






}
