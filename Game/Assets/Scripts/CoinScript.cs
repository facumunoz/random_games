using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    // Update is called once per frame

    private void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(90 * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.name == "Player")
        {
            Destroy(gameObject);
        }
    }
}
