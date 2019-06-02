using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    float offset;
    public float cameraHeight;
    
    // Use this for initialization
	void Start () {
        offset = 10;
	}
	
	// Update is called once per frame
	void Update () {
        Camera.main.transform.position = this.transform.position + offset * transform.forward * -1;
        Camera.main.transform.position += Vector3.up * cameraHeight;
        Camera.main.transform.LookAt(this.transform);
    }
}
