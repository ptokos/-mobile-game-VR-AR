using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chan_cjs : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.Play("Base Layer.WALK00_F"); // 걷기
    }
    public void RUN00_F() // 
    {
        anim.Play("Base Layer.RUN00_F"); // 뛰기
    }

    public void JUMP01() //
    {
        anim.Play("Base Layer.JUMP01"); // 점프
    }

    public void DAMAGED01() // 
    {
        anim.Play("Base Layer.DAMAGED01"); // 넘어짐
    }
}