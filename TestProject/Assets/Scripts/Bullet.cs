using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifetime = 3f;
    public float bulletSpeed = 100f;

    private int damage = 20;
    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
        Destroy(gameObject, lifetime);
    }

    void OnTriggerEnter(Collider other)
    {
        Health health = other.gameObject.GetComponent<Health>();
        if (other.gameObject.CompareTag("Player"))
        {
            health.TakeDamage(damage);
        }
        if (other.gameObject.CompareTag("Enemy"))
        {
            health.TakeDamage(damage);
        }
    }
}