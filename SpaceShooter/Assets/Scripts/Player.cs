using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  private Transform tr_;
  public float speed_;

  public void PlayerMovement()
  {
    if (Input.GetKey(KeyCode.RightArrow))
    {
      this.transform.Translate(Vector3.right * speed_ * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      this.transform.Translate(Vector3.left * speed_ * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.UpArrow) && this.transform.position.y <= -0.5f)
    {
      this.transform.Translate(Vector3.up * speed_ * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.DownArrow) && this.transform.position.y >= -5.0f)
    {
      this.transform.Translate(Vector3.down * speed_ * Time.deltaTime);
    }
  }

  public void Shoot()
  {
    if(Input.GetKey(KeyCode.Space))
    {
      Debug.Log("Shot");
    }
  }
  // Start is called before the first frame update
  void Start()
  {
    speed_ = 7.5f;
    // this.position = { 0.0f,-0.75f,-0.2f};
  }

  // Update is called once per frame
  void Update()
  {
    PlayerMovement();
    Shoot();
  }
}
