using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 1f;
    public float rotateSpeed = 1f;

    void Update()
    {
        Vector2 currentPos = transform.position;
        Vector2 motion = Vector2.zero;
        float shipRotate = 0.0f;

        float inputForward = Input.GetAxis("Vertical");
        float inputTurn = Input.GetAxis("Horizontal");

        motion = (transform.forward * speed * inputForward * Time.deltaTime);

        controller.transform.Rotate(0, 0, shipRotate * rotateSpeed);
        controller.Move(motion);
    }

    /*
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
        
    }*/
}
