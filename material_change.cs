using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class material_change : MonoBehaviour
{
    public Material metalMaterial1;
    public List<Color> colors1;
    public GameObject[] ON_Off1;
    public void Start()
    {
        metalMaterial1.color = colors1[Random.Range(0 , 8)];
        ON_Off1[Random.Range(0, 25)].SetActive(true);
    }
}
