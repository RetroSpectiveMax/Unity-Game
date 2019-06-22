using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingController : MonoBehaviour {

    public GameObject bullet;
    public GameObject superBullet;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(bullet, this.transform.position, Quaternion.Euler(90, this.transform.rotation.eulerAngles.y, 0));
            Debug.Log(this.transform.rotation.y);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Instantiate(superBullet, this.transform.position + new Vector3(0, 0, 1), Quaternion.Euler(90, this.transform.rotation.eulerAngles.y, 0));
        }
	}
}
