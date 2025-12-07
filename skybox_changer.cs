using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class skybox_changer : MonoBehaviour
{
    public Material[] skyBox;
    private void Start()
    {
        RenderSettings.skybox = skyBox[Random.Range(0, skyBox.Length)];
    }
}

