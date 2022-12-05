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
        float rotationMotion = 0;

        float inputForward = Input.GetAxis("Vertical");
        float inputTurn = Input.GetAxis("Horizontal");

        rotationMotion = rotateSpeed * inputTurn * Time.deltaTime;
        motion = (transform.right * speed * inputForward * Time.deltaTime);

        //this.gameObject.transform.GetChild(0).transform.Rotate(0, 0, rotationMotion);
        controller.transform.Rotate(0, 0, -rotationMotion);
        //this.Firepoint.transform.Rotate(0, 0, rotationMotion);
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
