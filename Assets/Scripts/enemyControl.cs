using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatController : MonoBehaviour
{
    public Transform player;
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 movement;
    public GameObject Enemy;

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        //if (FindObjectOfType<BatActivate>().activateBats == true)
        //{
        //    moveCharacter(movement);
        //}
    }

    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + direction * moveSpeed * Time.deltaTime);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        //if (collision.gameObject.tag == "Bullet")
        //{
        //    BatDeath();
        //}
    }

    //public void BatDeath()
    //{
    //    Destroy(Enemy);
    //}

}