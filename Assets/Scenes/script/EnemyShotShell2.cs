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
        // �^�C�}�[��0�����ɂȂ�����A0�Ŏ~�߂�B
        if (stopTimer < 0)
        {
            stopTimer = 0;
        }

        print("�U���J�n�܂ł���" + stopTimer + "�b");
        if (shotInterval % 330 == 0 && stopTimer <= 0)
        {
            GameObject enemyShell = Instantiate(enemyShellPrefab, transform.position, Quaternion.identity);
            Rigidbody enemyShellRb = enemyShell.GetComponent<Rigidbody>();
            enemyShellRb.AddForce(transform.forward * shotSpeed);
            AudioSource.PlayClipAtPoint(shotSound, transform.position);
            Destroy(enemyShell, 3.0f);
        }
    }

    // ���̃A�C�e���𕡐��擾����ƍU����~���Ԃ��u���Z�v�B
    public void AddStopTimer(float amount)
    {
        stopTimer += amount;
    }
}