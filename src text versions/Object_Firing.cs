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
    private float weaponRange = 90f;
    private Camera fpscam;
    private void Start()
    {
        fpscam = GetComponentInParent<Camera>();
    }
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (Time.time - nextFire > 1 / fireRate)
            {
                nextFire = Time.time;
                Vector3 rayOrigin = fpscam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
                RaycastHit hit;
                Debug.DrawRay(rayOrigin, transform.forward * 10, Color.red);
                if (Physics.Raycast(rayOrigin, fpscam.transform.forward, out hit, weaponRange))
                {
                    Instantiate(bulletPrefab, barrelEnd.position, barrelEnd.rotation);
                }
            }
        }
    }
}