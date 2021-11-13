using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellItem1 : MonoBehaviour
{
    public AudioClip getSound;
    public GameObject effectPrefab;
    private ShotShell ss;
    private int reward = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player1")
        {
            ss = GameObject.Find("ShotShell1").GetComponent<ShotShell>();

            ss.AddShell(reward);
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(getSound, Camera.main.transform.position);
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);

        }
        else if (other.gameObject.tag == "Player2")
        {
            ss = GameObject.Find("ShotShell2").GetComponent<ShotShell>();

            ss.AddShell(reward);
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(getSound, Camera.main.transform.position);
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
        }
    }
}