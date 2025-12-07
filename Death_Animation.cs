using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Death_Animation : MonoBehaviour
{
    public RuntimeAnimatorController death_animation_controller;
    public Avatar death_animation_avatar;
    void Start()
    {
        this.gameObject.GetComponentInChildren<Animator>().runtimeAnimatorController = death_animation_controller;
        this.gameObject.GetComponentInChildren<Animator>().avatar = death_animation_avatar;
        this.gameObject.GetComponent<Worq.AEAI.Enemy.EnemyAI>().enabled = false;
        Invoke("off", 5f);
    }
    public void off()
    {
       // this.gameObject.SetActive(false);
    }
}
