using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class elevator_move : MonoBehaviour
{
    public float destination1;
    public float duration1;
    public GameObject door;
    public float destination2;
    public float duration2;
    void Start()
    {
        this.transform.DOMoveY(destination1, duration1).OnComplete(() =>
        {
            door.transform.DOMoveY(destination2 , duration2);
        });
    }
}
