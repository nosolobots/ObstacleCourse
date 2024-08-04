using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    private Rigidbody rb;
    private MeshRenderer meshRenderer;
    [SerializeField] double dropDelay = 3.0;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;    

        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ( rb.useGravity == false && (Time.time > dropDelay))
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;
        }
    }
}
