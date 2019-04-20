using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugText : MonoBehaviour
{
    public Text TextField = null;
    private int Width = 0;
    private int Height = 0;
    public void SetWidth(int width)
    {
        Width = width;
    }
    public void SetHeight(int height)
    {
        Height = height;
    }
    public void OnResize()
    {
        TextField.text = Width + "x" + Height;
        Screen.SetResolution(Width, Height, Screen.fullScreen);
    }
    void Start()
    {
        TextField.text = Width + "x" + Height;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Screen.fullScreen = !Screen.fullScreen;
        }
    }
}
