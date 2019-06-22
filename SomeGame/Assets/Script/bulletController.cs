using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletController : MonoBehaviour {

    public float bulletSpeed;
    public GameObject player;
    public float StartTime;
    
    // Use this for initialization
	void Start () {
        StartTime = Time.time;
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
        if (Time.time - StartTime > 5)
        {
            Destroy(this.gameObject);
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
