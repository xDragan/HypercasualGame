using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulAxe : MonoBehaviour
{
    public float angle = 90.0f;
    public float speed = 1.5f;
    public bool activateR;
    public bool activateL;
    Quaternion qStart, qEnd;
    private float startTime;
    void Start()
    {
        qStart = Quaternion.AngleAxis(angle, Vector3.forward);
        qEnd = Quaternion.AngleAxis(-angle, Vector3.forward);
    }
    void Update()
    {
        if (activateR == true)
        {
            startTime += Time.deltaTime * speed;
            transform.rotation = Quaternion.Lerp(qStart, qEnd, (Mathf.Sin(startTime ) + 1.0f) / 2.0f);
        }

    }

}
