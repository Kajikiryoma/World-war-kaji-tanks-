using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera mainCamera;
    public Camera subCamera;
    private bool mainCameraON = true;

    void Start()
    {
        mainCamera.enabled = true;
        subCamera.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && mainCameraON == true)
        {
            mainCamera.enabled = false;
            subCamera.enabled = true;

            mainCameraON = false;

        } // �������uC�{�^���v�����������A�u���v�A�umainCameraON�v�̃X�e�[�^�X���ufalse�v�̎�
        else if (Input.GetKeyDown(KeyCode.C) && mainCameraON == false)
        {
            mainCamera.enabled = true;
            subCamera.enabled = false;

            mainCameraON = true;
        }
    }
}