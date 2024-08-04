using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float spinSpeed = 100.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, spinSpeed * Time.deltaTime, 0);
    }
}
