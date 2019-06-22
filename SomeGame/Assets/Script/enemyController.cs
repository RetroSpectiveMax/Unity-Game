using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

    // Use this for initialization

    public float speed = 1;

    void Update()
    {
        this.transform.position = new Vector3(PingPong(Time.time * speed, -9.75f, 9.75f), this.transform.position.y, this.transform.position.z); 
    }
    float PingPong(float t, float minLength, float maxLength)
    {
        return Mathf.PingPong(t, maxLength - minLength) + minLength;
    }
}
