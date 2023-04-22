using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycledShield : MonoBehaviour
{
    [SerializeField] private Vector3 startPoint;
    [SerializeField] private Vector3 endPoint;
    [SerializeField] private float speed = 0.5f;

    private float timer = 0f;
    private void Update()
    {
        timer += Time.deltaTime * speed;

        float pingPong = Mathf.PingPong(timer, 1.0f);
        transform.position = Vector3.Lerp(startPoint, endPoint, pingPong);

    }
}
