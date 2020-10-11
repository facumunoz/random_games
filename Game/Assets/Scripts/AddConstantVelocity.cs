using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPlayerControlledVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 vec3;
    [SerializeField]
    KeyCode KeyPositive;
    [SerializeField]
    KeyCode KeyNegative;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyPositive))
        {
            GetComponent<Rigidbody>().velocity += vec3;
        }
        if (Input.GetKey(KeyNegative))
        {
            GetComponent<Rigidbody>().velocity -= vec3;
        }
    }
}
