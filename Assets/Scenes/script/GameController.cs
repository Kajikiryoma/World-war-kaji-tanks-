using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text timeLabel;
    public float timeCount;
    private int player1HP;
    private int player2HP;

    void Start()
    {
        timeLabel.text = "TIME:" + timeCount;
    }

    void Update()
    {
        timeCount -= Time.deltaTime;
        timeLabel.text = "TIME:" + timeCount.ToString("0");

        if (GameObject.Find("Player1") != null)
        {
            player1HP = GameObject.Find("Player1").GetComponent<TankHealth>().tankHP;
        }

        if (GameObject.Find("Player2") != null)
        {
            player2HP = GameObject.Find("Player2").GetComponent<TankHealth>().tankHP;
        }

        if (timeCount < 0)
        {
            if (player1HP > player2HP)
            {
                SceneManager.LoadScene("Player1Win");
            }
            else if (player1HP < player2HP)
            {
                SceneManager.LoadScene("Player2Win");
            }
            else
            {
                SceneManager.LoadScene("Draw");
            }
        }
    }
}