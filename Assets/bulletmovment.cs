using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmovment : MonoBehaviour
{
    Rigidbody myrigidbody;
    // Start is called before the first frame update

    void Start()
    {
        myrigidbody = GetComponent<Rigidbody>();
        myrigidbody.velocity = new Vector3(0, -2, 0);

    }

    // Update is called once per frame
    void Update()
    {
       float speed = 3;
       myrigidbody.velocity = myrigidbody.velocity.normalized * speed;
       // if (Input.GetKey(KeyCode.X))
        //{
         //   myrigidbody.AddForce(new Vector3(0, -15, 0));
           // myrigidbody.AddForce(new Vector3(0, -0, 0));
       // }
    }
    private void OnCollisionEnter(Collision collision)
    {
        //float speed = 3;
        GameObject otherGameObject = collision.gameObject;
        enemy hitenemy = otherGameObject.GetComponent<enemy>();
        botten hitbotten = otherGameObject.GetComponent<botten>();
        if (hitenemy != null)
        {
            hitenemy.TakeDamage();

        }
        if (hitbotten != null)
        {
            transform.position = new Vector3(0, 7, 0);
            myrigidbody.velocity = new Vector3(0, -2, 0);
            hitbotten.TakeDamage();
        }

        // if (collision.gameObject.tag == "Player")
        //{
        //  myrigidbody.velocity = new Vector3(myrigidbody.velocity.x * speed, myrigidbody.velocity.y * -1, myrigidbody.velocity.z);
        //}

    }
}
