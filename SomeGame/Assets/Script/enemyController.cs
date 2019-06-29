using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyController : MonoBehaviour {

    // Use this for initialization
    public enemyAttackController eac;
    public Transform player;
    NavMeshAgent myNavMeshAgent;

    public float speed = 1;
    void Start()
    {
        myNavMeshAgent = GetComponent<NavMeshAgent>();    
    }

    void Update()
    {
        if(eac.playerNoticed == false)
        {
            this.transform.position = new Vector3(PingPong(Time.time * speed, -9.75f, 9.75f), this.transform.position.y, this.transform.position.z);
        }
        if(eac.playerNoticed == true){
            myNavMeshAgent.SetDestination(player.transform.position);
        }
    }
    float PingPong(float t, float minLength, float maxLength)
    {
        return Mathf.PingPong(t, maxLength - minLength) + minLength;
    }
    
    
}
