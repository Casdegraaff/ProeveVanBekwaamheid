using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HightLight : MonoBehaviour
{
    //Starting color for the matrial
    private Color startcolor;

    //The color that is going to be used as higlight
    public Color HighLightColor;

    //Function that when hoverd over makes the color different
    void OnMouseEnter()
    {
        startcolor = GetComponent<Renderer>().material.color;
        GetComponent<Renderer>().material.color = HighLightColor;
    }

    //When stop hovering color goes back to start color
    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = startcolor;
    }
}
