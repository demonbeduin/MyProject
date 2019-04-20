using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICanvas : MonoBehaviour
{
    public GameObject UI_Canvas;

    void Start()
    {
        Instantiate(UI_Canvas, new Vector3(0, 0, 0), Quaternion.identity);
    }
    void Update()
    {

    }
}
