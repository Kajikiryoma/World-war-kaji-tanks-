using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TankHealth1 : MonoBehaviour
{
    public GameObject effectPrefab1;
    public GameObject effectPrefab2;
    public int tankHP;
    public Text HPLabel;
    public Slider HPSlider;
    public GameObject winLabel;

    void Start()
    {
        HPLabel.text = "HP: " + tankHP;
        HPSlider.value = tankHP;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "EnemyShell" || other.gameObject.tag == "Shell")
        {
            tankHP -= 1;
            HPLabel.text = "HP: " + tankHP;
            HPSlider.value = tankHP;
            Destroy(other.gameObject);

            if (tankHP > 0)
            {
                GameObject effect1 = Instantiate(effectPrefab1, transform.position, Quaternion.identity);
                Destroy(effect1, 1.0f);
            }
            else
            {
                GameObject effect2 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                Destroy(effect2, 1.0f);
                this.gameObject.SetActive(false);
                winLabel.SetActive(true);

            }
        }
    }

    public void AddHP(int amount)
    {
        tankHP += amount;

        if (tankHP > 15)
        {
            tankHP = 15;
        }

        HPLabel.text = "HP: " + tankHP;
        HPSlider.value = tankHP;
    }
}