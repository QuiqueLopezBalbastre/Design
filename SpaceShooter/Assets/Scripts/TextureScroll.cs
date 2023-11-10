using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroll : MonoBehaviour
{

  public float scroll_x_ = 0.0f;
  public float scroll_y_ = 0.5f;

  // Update is called once per frame
  void Update()
  {
    float offset_x = Time.deltaTime * scroll_y_;
    float offset_y = Time.deltaTime * scroll_x_;
    GetComponent<SpriteRenderer>().material.mainTextureOffset = new Vector2(offset_x, offset_y);
  }
}
