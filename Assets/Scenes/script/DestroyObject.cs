using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public GameObject effectPrefab;
    public GameObject effectPrefab2;
    public int objectHP;
    public GameObject[] itemPrefabs;
    public int scoreValue;
    private ScoreManager sm;

    // ’Ç‰Á
    void Start()
    {
        sm = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shell"))
        {
            objectHP -= 1;

            if (objectHP > 0)
            {
                Destroy(other.gameObject);
                GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
                Destroy(effect, 2.0f);
            }
            else
            {
                Destroy(other.gameObject);
                GameObject effect2 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                Destroy(effect2, 2.0f);
                Destroy(this.gameObject);

                GameObject dropItem = itemPrefabs[Random.Range(0, itemPrefabs.Length)];
                Vector3 pos = transform.position;
                Instantiate(dropItem, new Vector3(pos.x, pos.y + 0.5f, pos.z), Quaternion.identity);

                // ’Ç‰Á
                sm.AddScore(scoreValue);
            }
        }
    }
}