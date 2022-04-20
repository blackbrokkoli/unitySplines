using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFollow : MonoBehaviour
{ 
    GameObject follow;
    float timePassed = 0f;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // if follow is empty, get a random gameobject with the tag 'follow'
        if (follow == null)
        {
            // pick a random gameobject
            follow = GameObject.FindGameObjectsWithTag("follow")[Random.Range(0, GameObject.FindGameObjectsWithTag("follow").Length)];


        }

    // smoothly rotate towards follow object
    transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(follow.transform.position - transform.position), Time.deltaTime * 10f);
    // smoothly move towards follow object
    transform.position = Vector3.MoveTowards(transform.position, follow.transform.position, Time.deltaTime * 10f);
  
    }
}

