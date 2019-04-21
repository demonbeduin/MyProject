using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Category : MonoBehaviour
{
    public Light _light;
    public int _intensity = 1;

    void Start()
    {
        _light = GetComponent<Light>();
        _light.intensity = _intensity;
    }
    private void OnMouseOver()
    {
        _light.intensity = 1;
        print("on");

    }
    private void OnMouseExit()
    {
        _light.intensity = 0;
        print("off");
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            _light.intensity = 1;
            print("on");
        }
    }
}
