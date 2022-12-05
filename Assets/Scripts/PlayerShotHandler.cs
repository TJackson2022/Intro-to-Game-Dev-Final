using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShotHandler : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void OnTriggerEnter(Collider collision)
    {
        EnemyControl enemy = collision.GetComponent<EnemyControl>();
        if (enemy != null)
        {
            enemy.gravIncrease();
        }
        Destroy(gameObject);
    }
}
