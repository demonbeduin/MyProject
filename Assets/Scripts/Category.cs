using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Category : MonoBehaviour
{
    public Light Light_1;
    public int _intensity = 0;

    void Start()
    {
        Light_1 = GetComponent<Light>();
        Light_1.intensity = _intensity;
    }
    //private void OnMouseOver()
    //{
    //    Light_1.intensity = 1;
    //    print("on");

    //}
    //private void OnMouseExit()
    //{
    //    Light_1.intensity = 0;
    //    print("off");
    //}
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            if (_intensity == 0)
            {
                Light_1.intensity = 1;
                print("on");
                _intensity = 1;
            }
            else
            {
                Light_1.intensity = 0;
                print("off");
                _intensity = 0;
            }
        }
    }
}
