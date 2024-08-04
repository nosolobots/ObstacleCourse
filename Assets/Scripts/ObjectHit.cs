using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log("Bumped into the wall");    
        if (gameObject.tag != "Hit" && other.gameObject.tag == "Player")
        {
            meshRenderer.material.color = Color.red;
            gameObject.tag = "Hit";
        }
    }
}
