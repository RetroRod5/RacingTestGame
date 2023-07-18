using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    Rigidbody2D rig;
    float Hinput;
    [SerializeField] float MinSpeed = 0.01f;
    [SerializeField] float MaxSpeed = 0.12f;
    [SerializeField] float Acell = 1.5f;
    [SerializeField] float Speed;

    void Start()
    {
        rig = GetComponent <Rigidbody2D>();
    }

    void Update()
    {
        Hinput = Input.GetAxisRaw("Horizontal");
        if (Hinput == 0 & Mathf.Abs(Speed) > MinSpeed)
        {
            Speed = Speed - (Mathf.Sign(Speed) * Acell * Time.deltaTime);
        }
        if (Mathf.Abs(Speed) <= MinSpeed)
        {
            Speed = 0;
        }
        Speed = Speed + (Hinput * Acell * Time.deltaTime);
        if (Mathf.Abs(Speed) > MaxSpeed)
        {
            Speed = Math.Sign(Speed) * MaxSpeed;
        }
    }

    private void FixedUpdate()
    {
        rig.MovePosition(new Vector2((Speed + transform.position.x), 0f));
    }
}
