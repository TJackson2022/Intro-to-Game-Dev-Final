using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGunControl : MonoBehaviour
{
    public Transform firePoint;
    public GameObject shotPrefab;
    public AudioSource Gunshot;

    public float timeBetweenShots = 5f;
    private float fireTime;

    private void Start()
    {
        fireTime = timeBetweenShots;
    }

    void Update()
    {
        fireTime -= Time.deltaTime;
        if (fireTime <= 0)
        {
            Shoot();
            fireTime = timeBetweenShots;
        }
    }

    void Shoot()
    {
        Instantiate(shotPrefab, firePoint.position, firePoint.rotation);
        Gunshot.Play();
        //PlayerPrefs.DeleteAll();
        // Debug.Log("Player Preferences delelted");
    }
}
