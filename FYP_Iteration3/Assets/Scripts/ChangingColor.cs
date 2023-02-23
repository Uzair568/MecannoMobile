using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingColor : MonoBehaviour
{
    public Color activeColor;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = activeColor;
    }
}