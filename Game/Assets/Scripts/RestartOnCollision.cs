using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartOnCollision : MonoBehaviour
{
       private void OnCollisionEnter()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
}
