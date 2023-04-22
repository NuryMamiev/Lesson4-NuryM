using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField, HideInInspector] private Rigidbody rb;
    [SerializeField] private float _rotationspeed = 2f;

    private void OnValidate()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float _horrizontal = Input.GetAxis("Horizontal");
        float _vertical = Input.GetAxis("Vertical");

        rb.angularVelocity = _horrizontal * _rotationspeed * transform.forward;
        rb.velocity = _horrizontal * _rotationspeed * transform.forward;

    }
}