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
        Destroy(gameObject, 10f);
        rb.velocity = transform.right * speed;
    }

    private void OnCollisionEnter(Collision collider)
    {
        Debug.Log("Shot Hit!");

        PlayerControl player = collider.gameObject.GetComponent<PlayerControl>();
        if (player != null)
        {
            player.healthDecrease();
            shotHit.Play();
        }
        Destroy(gameObject);
        Debug.Log("DestroyedBullet");
    }
}
