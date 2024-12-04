using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject Menucont;
    public KeyCode toggleKey = KeyCode.P;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            ToggleTheTarget();
        }
    }
    void ToggleTheTarget()
    {
        if (!Menucont.activeSelf)
        {
            Time.timeScale = 0.0f;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Time.timeScale = 1.0f;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        Menucont.SetActive(!Menucont.activeSelf);
    }
}
