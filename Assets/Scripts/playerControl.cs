using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPos = transform.position;
        Vector2 motion = Vector2.zero;

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        motion = (transform.forward * speed * inputY * Time.deltaTime) + (transform.right * speed * inputX * Time.deltaTime);

        controller.Move(motion);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
}
