using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walls_color : MonoBehaviour
{
    public Renderer[] plane_renderer;
    public Material[] Colors;
    void Start()
    {       
        plane_renderer[0].material = Colors[Random.Range(0, 28)];
        plane_renderer[1].material = plane_renderer[0].material;
    }
}