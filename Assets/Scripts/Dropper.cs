using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidBody;
    [SerializeField] float timeToDrop = 5.0f;

    void Start() 
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        renderer.enabled = false;
        rigidBody.useGravity = false;
    }

    void Update() 
    {
        if (Time.time > timeToDrop) 
        {
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
