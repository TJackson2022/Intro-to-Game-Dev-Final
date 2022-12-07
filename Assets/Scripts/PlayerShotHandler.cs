using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotHandler : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody rb;
    public AudioSource shotHit;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Shot fired!");
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Shot Hit!");

        shotHit.Play();

        EnemyControl enemy = collision.GetComponent<EnemyControl>();
        if (enemy != null)
        {
            enemy.gravIncrease();
        }
        Destroy(gameObject, 10f);
        Debug.Log("DestroyedBullet");
    }
}
