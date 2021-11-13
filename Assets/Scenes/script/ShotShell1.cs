using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShotShell1 : MonoBehaviour
{
    public int playerNumber;

    public GameObject shellPrefab;
    public float shotSpeed;
    public AudioClip shotSound;
    public int shotCount;
    public Text shellLabel;
    private float timeBetweenShot = 1.40f;
    private float timer;

    void Start()
    {
        shellLabel.text = "Å~" + shotCount;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (Input.GetButtonDown("Shot" + playerNumber) && timer > timeBetweenShot)
        {
            if (shotCount < 1)
            {
                return;
            }

            shotCount -= 1;
            shellLabel.text = "Å~" + shotCount;
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

        if (shotCount > 40)
        {
            shotCount = 40;
        }

        shellLabel.text = "Å~" + shotCount;
    }
}