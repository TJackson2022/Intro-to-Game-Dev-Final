using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGunHandler : MonoBehaviour
{
    public Transform firePoint;
    public GameObject shotPrefab;
    public AudioSource Gunshot;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(shotPrefab, firePoint.position, firePoint.rotation);
        //Gunshot.Play();
    }
}