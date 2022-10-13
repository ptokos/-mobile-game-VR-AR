using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class cjsVideo : MonoBehaviour
{
    private const float _maxDistance = 10;
    public VideoClip clip01;
    public VideoClip clip02;
    public GameObject Sphere1;
    public Button button;
    public Button button1;

    void Update()
    {
        RaycastHit hit; // Button 감지하는 레이저
        if (Physics.Raycast(transform.position, transform.forward, out hit, _maxDistance))
        {
            print(hit.transform.gameObject);
            if (hit.transform.gameObject.name == "Button")  // 레이저가 Button을 hit할 떄
            {
                button.GetComponent<Image>().color = Color.blue;  // Button: 파란색
                button1.GetComponent<Image>().color = Color.white;  // Button1: 흰색
                Sphere1.GetComponent<VideoPlayer>().clip = clip01;  // 동영상 clip01 재생

            }
            if (hit.transform.gameObject.name == "Button1") // 레이저가 Button1을 hit할 떄
            {
                button.GetComponent<Image>().color = Color.white;  // Button:  흰색
                button1.GetComponent<Image>().color = Color.blue;   // Button1: 파란색
                Sphere1.GetComponent<VideoPlayer>().clip = clip02;  //동영상 clip02 재생
            }

        }
    }
}