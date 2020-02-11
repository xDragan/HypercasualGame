using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject spawn;
    private void OnCollisionEnter(Collision collision)
    {
        transform.position = spawn.transform.position;
    }
}
