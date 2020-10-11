using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelOnCollision : MonoBehaviour
{

    [SerializeField]
    string strTag;
    [SerializeField]
    string nextLevel;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == strTag)
        {
            SceneManager.LoadScene(nextLevel);
        }
                
    }
}
