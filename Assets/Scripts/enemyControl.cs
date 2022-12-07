using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControl : MonoBehaviour
{
    public GameObject player;
    public float moveSpeed;
    public Rigidbody rb;
    public GameObject Enemy;

    private UnityEngine.Object explosionRef;
    private Transform target;
    private Vector3 moveDirection;

    public float gravMod = 1.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

        explosionRef = Resources.Load("Explosion");
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player)
        {
            Vector3 direction = (player.transform.position - transform.position).normalized;
            float angle = Mathf.Atan2(direction.y, direction.x);// * Mathf.Rad2Deg;
            //rb.transform.Rotate(0f, 0f, angle);
            rb.transform.LookAt(player.transform);
            moveDirection = direction;
        }
    }

    private void FixedUpdate()
    {
        if (player)
        {
            rb.velocity = new Vector3(moveDirection.x, moveDirection.y) * moveSpeed;
        }
    }

    public void gravIncrease()
    {
        gravMod++;
    }
}