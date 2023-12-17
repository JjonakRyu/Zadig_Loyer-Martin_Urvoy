using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{

    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadSceneAsync(2);
        }
    }
}
