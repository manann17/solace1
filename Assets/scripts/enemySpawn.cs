using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class enemySpawn : MonoBehaviour
    
{
    public GameObject Enemy;
    public float spawnAfter;
    public float spawnRate;
    public float spawnFor;
    public float spawnDis;
           float curr;

   
    void Start()
    {
        curr = spawnAfter;
    }

   
    void FixedUpdate()
    {
        if (curr < 0)
        {
            spawn();
            curr = 60 / spawnRate;
        }
        else curr -= Time.fixedDeltaTime;
    }

    void spawn()
    {
       var random = new System.Random();

        float offset = random.Next(-100, 100) / 100;
        Vector3 spawnPos = (transform.forward * -1 + Vector3.right * offset).normalized*spawnDis;
        spawnPos = new Vector3(spawnPos.x, 2, spawnPos.z);
        GameObject newenemy = Instantiate(Enemy, spawnPos, Quaternion.identity);
        newenemy.transform.LookAt(transform);
        newenemy.transform.position=new Vector3(spawnPos.x, 2, spawnPos.z);
        
    }
}
