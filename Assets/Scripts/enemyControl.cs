using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;
    public Rigidbody rb;
    private Vector3 movement;
    public GameObject Enemy;

    public float gravMod = 1.0f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Vector3 direction = player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x);// * Mathf.Rad2Deg;
        rb.transform.Rotate(0, 0, angle);
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + direction * moveSpeed * Time.deltaTime);
    }

    //public void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "Shot")
    //    {
    //        gravMod++;
    //    }
    //}

    public void gravIncrease()
    {
        gravMod++;
    }
}