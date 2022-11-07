using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovementForward : MonoBehaviour
{
    public float bulletSpeed = 10f;
    void Update()
    {
        float forwardSpeed = bulletSpeed * Time.deltaTime;
        transform.Translate(Vector3.up * forwardSpeed);
    }
}
