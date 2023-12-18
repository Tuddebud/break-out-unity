using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botten : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int hp = 1;
    public void TakeDamage()
    {
        hp -= 3;
        if (hp == 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
