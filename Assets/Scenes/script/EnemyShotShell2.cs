using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotShell2 : MonoBehaviour
{
    public GameObject enemyShellPrefab;
    public float shotSpeed;
    public AudioClip shotSound;
    private int shotInterval;
    public float stopTimer = 5.0f;

    void Update()
    {
        shotInterval += 1;
        stopTimer -= Time.deltaTime;
        // タイマーが0未満になったら、0で止める。
        if (stopTimer < 0)
        {
            stopTimer = 0;
        }

        print("攻撃開始まであと" + stopTimer + "秒");
        if (shotInterval % 330 == 0 && stopTimer <= 0)
        {
            GameObject enemyShell = Instantiate(enemyShellPrefab, transform.position, Quaternion.identity);
            Rigidbody enemyShellRb = enemyShell.GetComponent<Rigidbody>();
            enemyShellRb.AddForce(transform.forward * shotSpeed);
            AudioSource.PlayClipAtPoint(shotSound, transform.position);
            Destroy(enemyShell, 3.0f);
        }
    }

    // このアイテムを複数取得すると攻撃停止時間も「加算」。
    public void AddStopTimer(float amount)
    {
        stopTimer += amount;
    }
}