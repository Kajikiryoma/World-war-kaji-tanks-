using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomController : MonoBehaviour
{
    private Camera cam;
    private float zoom;
    private float view;

    void Start()
    {
        cam = GetComponent<Camera>();
        view = cam.fieldOfView;
    }

    void Update()
    {
        cam.fieldOfView = view + zoom;

        if (cam.fieldOfView < 10f)
        {
            cam.fieldOfView = 10f;
        }

        if (cam.fieldOfView > 60f)
        {
            cam.fieldOfView = 60f;
        }

        if (Input.GetKey(KeyCode.Return))
        {
            zoom -= 0.5f;

        } // 右シフトキーを押すと、kakudai
        else if (Input.GetKey(KeyCode.RightShift))
        {
            zoom += 0.5f;
        }
    }
}