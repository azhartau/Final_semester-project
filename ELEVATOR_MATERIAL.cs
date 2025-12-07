using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ELEVATOR_MATERIAL : MonoBehaviour
{
    public Material metalMaterial1;
    public List<Color> colors1;
    public GameObject[] ON_Off1;
    public void Start()
    {       
        for (int i = 0; i < ON_Off1.Length; i++)
        {
            metalMaterial1.color = colors1[Random.Range(0, 8)];
            ON_Off1[i].gameObject.SetActive(true);
        }       
    }
}
