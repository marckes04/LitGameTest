using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public void Walk(bool walk)
    {
        anim.SetBool(AnimationTag.WALK_PARAMETER, walk);
    }

    public void Shoot()
    {
        anim.SetTrigger(AnimationTag.SHOOT_PARAMETER);
    }

    public void FreezAnimation()
    {
        anim.speed = 0f;
    } 

    public void UnFreezAnimation()
    {
        anim.speed = 1f;
    } 



}


