using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{
    public float speed = 2f;
    public float maxCloseness;


    void FixedUpdate()
    {


        if (Vector3.Distance(transform.position, Camera.main.transform.position) > maxCloseness)
        {
            transform.position = Vector3.MoveTowards(transform.position, Camera.main.transform.position, speed * Time.fixedDeltaTime);
        }
        transform.LookAt(Camera.main.transform);



    }
    }


