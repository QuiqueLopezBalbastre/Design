using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    private Vector3 spawn_point = new Vector3(0, 0, 0);
    public void Death()
    {
        this.transform.Translate(spawn_point);
    }
}