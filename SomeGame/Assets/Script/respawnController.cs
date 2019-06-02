using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnController : MonoBehaviour {

    public Vector3 respawnPos;

	// Use this for initialization
	void Start () {
        respawnPos = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "death")
        {
            this.transform.position = respawnPos;
        }
    }
}
