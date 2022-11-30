using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 3;
        int level = 2;
        health = health + level;


        int speed =1;
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
