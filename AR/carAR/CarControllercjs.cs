using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllercjs : MonoBehaviour
{
    public float rotSpeed = 0.1f;

    void Update()
    {
        //만일, 터치 된 부위가 1개 이상이라면
        if(Input.touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
       

        //만일, 터치 상태가 움직이고 있는 중이라면
        if(touch.phase == TouchPhase.Moved)
        {
                //만일, 카메라 위치에서 정면 방향으로 레이를 발사하여 부딪힌 대상이
                //8번레이어라면 터치 이동량을 구한다
                Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
                RaycastHit hitInfo;

                if(Physics.Raycast(ray, out hitInfo, Mathf.Infinity, 1<<8 ))
                {
                    Vector3 deltaPos = touch.deltaPosition;
                    //직전 프레임에서 현재 프레임까지의 x축 터치 이동량에 비례하여
                    //로컬 y축 방향으로 회전시킨다
                    transform.Rotate(transform.up, deltaPos.x * -1.0f* rotSpeed);
                }
        }

        }

    }
}