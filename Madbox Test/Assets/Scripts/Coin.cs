using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField, Range(0.0f, 5.0f)]
    float rotateForce = 0.0f;

    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward, rotateForce);
    }
}
