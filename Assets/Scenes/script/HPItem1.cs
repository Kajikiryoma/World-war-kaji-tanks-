using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPItem1 : MonoBehaviour
{
    public GameObject effectPrefab;
    public AudioClip getSound;
    private TankHealth th;
    private int reward = 3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player1")
        {
            th = GameObject.Find("Player1").GetComponent<TankHealth>();
            th.AddHP(reward);

            Destroy(gameObject);
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
            AudioSource.PlayClipAtPoint(getSound, Camera.main.transform.position);
        }
        else if (other.gameObject.tag == "Player2")
        {
            th = GameObject.Find("Player2").GetComponent<TankHealth>();
            th.AddHP(reward);

            Destroy(gameObject);
            GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
            Destroy(effect, 0.5f);
            AudioSource.PlayClipAtPoint(getSound, Camera.main.transform.position);
        }
    }
}