using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private bool OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().gameObject.tag=="Player")
        {
            other.gameObject.GetComponent<Hero>().Death();
            return true;
        }
        return false;
    }
}
