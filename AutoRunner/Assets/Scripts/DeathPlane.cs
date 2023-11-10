using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    public float forward_speed_ = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<Collider>().gameObject.tag=="Player")
        {
            // other.gameObject.GetComponent<Hero>().Death();
            Hero.Death();
            // return true;
        }
        // return false;
    }
    void FollowHero()
    {
        // this.transform.position.z = pos.z;
        // this.transform.Position.z = herotr.position.y; 
        this.transform.Translate(Vector3.forward * forward_speed_ * Time.deltaTime);
    }
}
