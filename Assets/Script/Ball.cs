using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ForceFactor = 100;
    Rigidbody rb;
    private Vector3 forceDirection;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GameObject.Find("CanvasMenu").SetActive(false);
    }

    void Update()
    {
        float dx = Input.GetAxis("Horizontal");
        float dz = Input.GetAxis("Vertical");
        forceDirection.Set(
            dx * ForceFactor * Time.deltaTime,
            0,
            dz * ForceFactor * Time.deltaTime);

        rb.AddForce(forceDirection);
    }
}
