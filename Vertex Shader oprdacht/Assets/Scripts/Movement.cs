using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
    }

    private void RotationCorection()
    {
        transform.LookAt(rigid.velocity);
    }

    private void Move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigid.velocity = -Vector3.right * speed;
            RotationCorection();
        }
        if (Input.GetKey(KeyCode.W))
        {
            rigid.velocity = Vector3.forward * speed;
            RotationCorection();
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigid.velocity = -Vector3.forward * speed;
            RotationCorection();
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigid.velocity = Vector3.right * speed;
            RotationCorection();
        }
    }

}
