using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BOSSTO : MonoBehaviour
{
    private GameObject[] enemyBox;

    void Update()
    {
        enemyBox = GameObject.FindGameObjectsWithTag("Enemy");

        print("�G�̐��F" + enemyBox.Length);

        if (enemyBox.Length == 0)
        {
            SceneManager.LoadScene("soviet");
        }
    }
}
