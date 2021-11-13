using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goout : MonoBehaviour
{

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player1" || col.gameObject.tag == "Player2")
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().name);
        }
    }
}