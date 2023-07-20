using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraRotate : MonoBehaviour
{
    bool SlideWait;
    public bool Roable = true;
    Vector3 firstPos, gap;
    public int slideNum;
    public Transform MainCam;
    public Camera MainCam2;
    int ZoomAble = 0;

    public Animator ZoomAni;

    void Update()
    {
        // 문지름
        if (Input.GetMouseButtonDown(0) || (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Began) && Roable)
        {
            SlideWait = true;
            firstPos = Input.GetMouseButtonDown(0) ? Input.mousePosition : (Vector3)Input.GetTouch(0).position;
        }

        if (Input.GetMouseButton(0) || (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved) && Roable)
        {
            gap = (Input.GetMouseButton(0) ? Input.mousePosition : (Vector3)Input.GetTouch(0).position) - firstPos;
            if (gap.magnitude < 100) return;
            gap.Normalize();

            if (SlideWait)
            {
                SlideWait = false;
                // 위
                if (gap.y > 0 && gap.x > -0.5f && gap.x < 0.5f)
                {
                    slideNum = 1;
                }
                // 아래
                else if (gap.y < 0 && gap.x > -0.5f && gap.x < 0.5f)
                {
                    slideNum = 2;
                }
                // 오른쪽
                else if (gap.x > 0 && gap.y > -0.5f && gap.y < 0.5f)
                {
                    slideNum = 3;
                }
                // 왼쪽
                else if (gap.x < 0 && gap.y > -0.5f && gap.y < 0.5f)
                {
                    slideNum = 4;
                }
                else return;
            }
        }
        else
        {
            if (slideNum != 0)
            {
                slideNum = 0;
            }
        }

        if (slideNum == 4 && Roable)
        {
            Roable = false;
            slideNum = 0;
            transform.DORotate(new Vector3(0, transform.localEulerAngles.y - 90, 0), 1f);
            Invoke("CamerRoaAble", 1.1f);
        }

        if (slideNum == 3 && Roable)
        {
            Roable = false;
            slideNum = 0;
            transform.DORotate(new Vector3(0, transform.localEulerAngles.y + 90, 0), 1f);
            Invoke("CamerRoaAble", 1.1f);
        }

        if (slideNum == 1 && Roable && ZoomAble == 0)
        {
            ZoomAble = 1;
            Roable = false;
            slideNum = 0;
            MainCam.DOLocalMove(new Vector3(-1.39f, 3.12f, -1.5f), 1.8f);
            MainCam.DOLocalRotate(new Vector3(30, 45, 0), 1.8f);
            ZoomAni.SetBool("Zoom", true);
            Invoke("CamerRoaAble", 2f);
        }

        if (slideNum == 2 && Roable && ZoomAble == 2)
        {
            ZoomAble = 3;
            Roable = false;
            slideNum = 0;
            MainCam.DOLocalMove(new Vector3(-2.970444f, 4.243591f, -3.350143f), 1.8f);
            MainCam.DOLocalRotate(new Vector3(45, 45, 0), 1.8f);
            ZoomAni.SetBool("Zoom", false);
            Invoke("CamerRoaAble", 2f);
        }
    }



    void CamerRoaAble()
    {
        Roable = true;

        if (ZoomAble == 1)
            ZoomAble = 2;

        if (ZoomAble == 3)
            ZoomAble = 0;

    }
}
