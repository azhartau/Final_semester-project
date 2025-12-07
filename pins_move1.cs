using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class pins_move1 : MonoBehaviour
{
    public float destination1;
    public float duration1;
    public float destination2;
    public float duration2;
    private void Update()
    {
        if (this.transform.position.y <= 5)
        {
            this.gameObject.transform.DOMoveY(destination1, duration1);
        }
        if (this.transform.position.y>=14)
        {
            this.gameObject.transform.DOMoveY(destination2, duration2);
        }      
    }
}
