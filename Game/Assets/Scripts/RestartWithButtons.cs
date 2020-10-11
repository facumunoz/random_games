using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartWithButtons : MonoBehaviour
{
    [SerializeField]
    KeyCode Restart;
    
       void FixedUpdate()
    {
        if (Input.GetKey(Restart))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
