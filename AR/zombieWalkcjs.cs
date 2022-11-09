using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieWalkcjs : MonoBehaviour
{
    Animation anim; // 에니메이션 사용
    void Start()
    {
        anim = GetComponent<Animation>();
        anim.Play("walk"); 
    }
    public void ZwalkingF() // 버튼을 누르면 앞으로 나오는 좀비
    {
        gameObject.transform.position -= new Vector3(0, 0, 0.5f);
    }

    public void ZwalkingB() // 버튼을 누르면 뒤로가는 좀비
    {
        gameObject.transform.position += new Vector3(0, 0, 0.5f);
    }

    public void ZwalkingT() // 버튼을 누르면 좀비 회전
    {
        gameObject.transform.Rotate(0, 5, 0);
    }
}