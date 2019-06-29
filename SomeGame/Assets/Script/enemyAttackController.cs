using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAttackController : MonoBehaviour {
    
    public Transform player;
    public radiusDetection rd;

    public float health = 50f;
    public bool playerNoticed = false;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(health <= 0)
        {
            Destroy(this.gameObject);
        }
        if (rd.Triggered == true)
        {
            transform.LookAt(player);
            Debug.Log("Facing the player");
            playerNoticed = true;
        }
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            health -= 2;
        }
    }
}
