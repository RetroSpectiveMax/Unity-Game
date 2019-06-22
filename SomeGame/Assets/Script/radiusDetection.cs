using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class radiusDetection : MonoBehaviour {

    // Use this for initialization
    public static bool Triggered = false;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public static bool getTriggered()
    {
        return Triggered;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Triggered = true;
        }
    }
}
