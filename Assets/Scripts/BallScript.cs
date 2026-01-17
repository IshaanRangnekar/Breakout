using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float ballIV = 600f;
    private Rigidbody rb;
    private bool ballIP;

    // Start is called before the first frame update
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && ballIP==false)
        {
            transform.parent = null;
            ballIP = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(ballIV, ballIV, 0));
        }
    }
}
