using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(SphereCollider))]
public class Coin : MonoBehaviour
{
    private float value = 1.0f;
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().gameObject.tag=="Player")
        {
            other.gameObject.GetComponent<Hero>().score += value;
            Debug.Log("Score: " +other.gameObject.GetComponent<Hero>().score);
            // return true;
            Destroy(this);
        }
        // return false;
    }
}