using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

    Rigidbody rb;
    public float Speed = 1000f;
    public float Rotate = 100f;
    public float Jump;
    public bool jumpBool = false;
    public float health = 100f;
    
    // Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * Rotate * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Rotate * Time.deltaTime);
        }
        if (jumpBool)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * Jump * Time.deltaTime);
                jumpBool = false;
            }
        }
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
	}
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            jumpBool = true;
        }
        if(collision.gameObject.tag == "enemy")
        {
            health -= 10;
            Debug.Log(health);
        }
    }
}

