using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAttackItem : MonoBehaviour
{
    private GameObject[] targets;
    public AudioClip getSound;
    public GameObject effectPrefab;

    void Update()
    {
        // 「EnemyShotShell」オブジェクトに「EnemyShotShell」タグを設定
        targets = GameObject.FindGameObjectsWithTag("EnemyShotShell");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            for (int i = 0; i < targets.Length; i++)
            {
                targets[i].GetComponent<EnemyShotShell>().AddStopTimer(5.0f);
            }

            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(getSound, Camera.main.transform.position);
            GameObject effect = (GameObject)Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
        }
    }
}