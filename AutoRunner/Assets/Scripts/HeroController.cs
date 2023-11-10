using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class HeroController : MonoBehaviour
{

    public float horizontal_input_;
    public float vertical_input_;
    public bool jump_ = false;
    public float lateral_speed_ = 10.0f;
    public float forward_speed_ = 30.0f;
    public float jump_force = 500.0f;

    // Start is called before the first frame update

    public void Run()
    {
        this.transform.Translate(Vector3.forward * forward_speed_ * Time.deltaTime);
    }
    public void InputHero()
    {
        if (Input.GetKey("a"))
        {
            // horizontal_input_ = -1;
            Debug.Log("A");
            this.transform.Translate(Vector3.left * lateral_speed_ * Time.deltaTime);
        }
        if (Input.GetKey("left"))
        {
            Debug.Log("Left");
        }
        if (Input.GetKey("d"))
        {
            // horizontal_input_ = 1;
            Debug.Log("D");
            this.transform.Translate(Vector3.right * lateral_speed_ * Time.deltaTime);
        }
        if (Input.GetKey("right"))
        {
            Debug.Log("Right");
        }
        if (Input.GetKey("w"))
        {
            // vertical_input_ = 1;
            Debug.Log("W");
            // this.transform.Translate(Vector3.forward * speed_);
        }
        if (Input.GetKey("up"))
        {
            Debug.Log("Up");
        }
        if (Input.GetKey("s"))
        {
            // vertical_input_ = -1;
            Debug.Log("S");
            // this.transform.Translate(Vector3.forward * speed_ * -1);
        }
        if (Input.GetKey("down"))
        {
            Debug.Log("Down");
        }
        if (Input.GetKeyDown("space") && jump_ == false)
        {
            jump_ = true;
            Debug.Log("Jumping");
            this.GetComponent<Rigidbody>().AddForce(0, jump_force, 0);
        }
        if (Input.GetKey("return"))
        {
            Debug.Log("Return");
        }
    }
    public void Update()
    {
        InputHero();
        Run();
        if(this.GetComponent<Transform>().position.y < 0 && jump_ == true)
        {
            Debug.Log("Grounded");
            jump_ = false;
        }
        else{
        }
    }
}
