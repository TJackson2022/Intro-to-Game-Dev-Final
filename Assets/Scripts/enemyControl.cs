using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public Transform player;
    public float moveSpeed;
    public Rigidbody rb;
    private Vector2 movement;
    public GameObject Enemy;

    public float gravMod = 1.0f;

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x);// * Mathf.Rad2Deg;
        rb.transform.Rotate(0, 0, angle);
        direction.Normalize();
        movement = direction;
    }

    private void FixedUpdate()
    {
        //if (FindObjectOfType<BatActivate>().activateBats == true)
        //{
        moveCharacter(movement);
        //}
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