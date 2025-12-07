using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Camera_Controller : MonoBehaviour
{
    public Transform player;
    public float smooth_speed;
    public Vector3 offset = new Vector3(1, 1, -1);
    private void LateUpdate()
    {
        Vector3 despos = offset + player.position;
        Vector3 newpos = Vector3.Lerp(transform.position, despos, smooth_speed * Time.deltaTime);
        transform.position = newpos;
    }
}
