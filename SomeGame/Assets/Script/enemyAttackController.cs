using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttackController : MonoBehaviour {
    
    public Transform player;

    public float health = 100f;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(health <= 0)
        {
            Destroy(this.gameObject);
        }
        if(radiusDetection.getTriggered() == true)
        {
            transform.LookAt(player);
            Debug.Log("Noticeed");
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            health -= 10;
        }
    }
}
