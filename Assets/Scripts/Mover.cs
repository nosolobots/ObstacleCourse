using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5.0f;

    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer() 
    {
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, 0.0f, zValue);
    }
}
