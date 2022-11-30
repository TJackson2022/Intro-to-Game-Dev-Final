using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    public AudioSource Gunshot;

    void Update()
    {
        if (Input.GetKeyDown("s"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
        Gunshot.Play();
    }
}