using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {

    Vector3 PositionOffset;
    Vector3 RotationOffset;
    
    // Use this for initialization
	void Start () {
        PositionOffset = Camera.main.transform.position - this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Camera.main.transform.position = this.transform.position + PositionOffset;
    }
}
