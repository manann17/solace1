using JetBrains.Annotations;
using OpenCover.Framework.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class gun : MonoBehaviour
{
    public float damage = 1f;
    public float reloadTime;
    private bool isReloading;
    public float fireRate;
    public float magSize;
    float currAmmo;
    public float maxAmmo;

    void Start()
    {
        if (currAmmo==-1)
        currAmmo = maxAmmo;
    }




    void Update()
    {
        if (isReloading)
            return; 
        if (currAmmo <= 0)
        {
            StartCoroutine(Reload());
            Reload();
            return;
        }
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    IEnumerator Reload()
    {
        isReloading = true;
        Debug.Log("Reloading");
        yield return new WaitForSeconds(reloadTime);
        currAmmo = maxAmmo;
        isReloading = false;
    }
    void Shoot()
    {
        currAmmo--;
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit)) 
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
    
        }

        

            }
             }
       
        
       

