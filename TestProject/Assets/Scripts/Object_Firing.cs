using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEditor;
using UnityEngine;

public class Object_Firing : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform barrelEnd;

    private float nextFire = 1f;
    private float fireRate = 5f;

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (Time.time - nextFire > 1 / fireRate)
            {
                nextFire = Time.time;
                GameObject clone = Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation);
                Physics.IgnoreCollision(clone.GetComponent<Collider>(), GetComponent<Collider>());
            }
        }
    }
}