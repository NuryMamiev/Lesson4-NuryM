using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Fire : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] private GameObject bullet;
    [SerializeField] private float currentBulletSpeed = 0f;
    [SerializeField] private float minBulletSpeed = 600f;
    [SerializeField] private float maxBulletSpeed = 10000;
    [SerializeField] private float chargeSpeed = 600f;
    
    
    void Update()
    {
        Vector3 shootDir = Camera.main.transform.forward;
        if (Input.GetButtonDown("Jump"))
        {
            currentBulletSpeed = 0f;
        }

        if (Input.GetButton("Jump"))
        {
            currentBulletSpeed += chargeSpeed * Time.deltaTime;
            currentBulletSpeed = Mathf.Clamp(currentBulletSpeed, minBulletSpeed, maxBulletSpeed);
            
        }
        
        if (Input.GetButtonUp("Jump"))
        {
            var _bullet = Instantiate(bullet, shootPoint.position, Quaternion.identity);
            _bullet.GetComponent<Rigidbody>().AddForce(shootDir * currentBulletSpeed,ForceMode.Force);
            
        }
    }

    
}
