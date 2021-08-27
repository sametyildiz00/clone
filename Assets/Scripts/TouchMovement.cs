using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMovement : MonoBehaviour
{
    private Rigidbody rb;
    private float moveSpeed = 10f;
    public Vector3 moveVector;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        transform.Translate(moveVector * moveSpeed * Time.deltaTime);
        TouchMove();
    }
    public void TouchMove()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x < Screen.width / 2)
                        rb.velocity = new Vector3(-moveSpeed, 0f, 0f);

                    if (touch.position.x > Screen.width / 2)
                        rb.velocity = new Vector3(moveSpeed, 0f, 0f);
                    break;

                case TouchPhase.Ended:
                    rb.velocity = new Vector3(0f, 0f, 0f);
                    break;
            }
        }
    }





}
