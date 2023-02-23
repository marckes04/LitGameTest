using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtractObjects : MonoBehaviour
{
    public Transform target;
    public float attractionForce = 10f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Attract();
    }

    void Attract()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
        Vector3 direction = (target.position - transform.position).normalized;
        rb.AddForce(direction * attractionForce);
        }
    }
}
