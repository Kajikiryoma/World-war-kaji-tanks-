using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotShell : MonoBehaviour
{
    public GameObject shellPrefab;
    public float shotSpeed;
    public AudioClip shotSound;
    public int shotCount;
    public Text shellLabel;
    private float timeBetweenShot = 0.35f;
    private float timer;

    void Start()
    {
        shellLabel.text = "~" + shotCount;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && timer > timeBetweenShot)
        {
            if (shotCount < 1)
            {
                return;
            }

            shotCount -= 1;
            shellLabel.text = "~" + shotCount;
            timer = 0.0f;
            GameObject shell = Instantiate(shellPrefab, transform.position, Quaternion.identity);
            Rigidbody shellRb = shell.GetComponent<Rigidbody>();
            shellRb.AddForce(transform.forward * shotSpeed);
            Destroy(shell, 3.0f);
            AudioSource.PlayClipAtPoint(shotSound, transform.position);
        }
    }

    public void AddShell(int amount)
    {
        shotCount += amount;

        if (shotCount > 10)
        {
            shotCount = 10;
        }

        // ‰ñ•œ‚ğUI‚É”½‰f‚³‚¹‚éB
        shellLabel.text = "~" + shotCount;
    }
}