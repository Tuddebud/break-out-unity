using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour
{
    Rigidbody myRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            myRigidBody.AddForce(new Vector3(25, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            myRigidBody.AddForce(new Vector3(-25, 0, 0));
        }
        
        

    }
}

