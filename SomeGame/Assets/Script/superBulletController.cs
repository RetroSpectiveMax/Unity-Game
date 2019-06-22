using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superBulletController : MonoBehaviour {

    public float bulletSpeed;
    public GameObject player;
    public float StartTime;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(2f, 2f, 2f);
        if (Input.GetKeyUp(KeyCode.R))
        {
            StartTime = Time.time;
            this.transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
            Debug.Log("R is released");
        }
        if (Time.time - StartTime > 5)
        {
            Destroy(this.gameObject);
        }
    }
}
