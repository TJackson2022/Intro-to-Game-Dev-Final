using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotControl : MonoBehaviour
{
    public float speed = 2f;
    public Rigidbody rb;
    public AudioSource shotHit;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Shot fired!");
        Destroy(gameObject, 5f);
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Shot Hit!");

        PlayerControl player = collision.GetComponent<PlayerControl>();
        if (player != null)
        {
            player.healthDecrease();
            shotHit.Play();
        }
        Destroy(gameObject);
        Debug.Log("DestroyedBullet");
    }
}
