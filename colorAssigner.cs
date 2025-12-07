using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class colorAssigner : MonoBehaviour
{
    public Renderer[] plane_renderer;
    public Material[] Colors;
    void Start()
    {
        for (int i = 0; i < plane_renderer.Length; i++)
        {
            plane_renderer[i].material = Colors[Random.Range(0,Colors.Length)];
        }
    }
}