using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class spawn : MonoBehaviour
{
    public Transform[] spawnLocation;
    public GameObject[] pieces;
    private void Start()
    {
        for (int i = 0; i < pieces.Length; i++)
        {
            Instantiate(pieces[i], spawnLocation[Random.Range(0, 36)].position, Quaternion.Euler(0 , 0 , 0));
        }   
    }
}