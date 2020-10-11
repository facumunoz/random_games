using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddConstantVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 vec3force;
    
    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity += vec3force;
    }
}
