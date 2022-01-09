using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime = 3f;
    private float bulletSpeed = 100f;
    public Transform lookTarget = null;

    private int damage = 20;
    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter(Collider other)
    {
        GameObject hit = other.gameObject;
        Health health = hit.GetComponent<Health>();

        if (health != null)
        {
            health.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}