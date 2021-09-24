using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickMover : MonoBehaviour
{
    [SerializeField] LayerMask groundMask;
    [SerializeField] UnityEvent<Vector3> OnClickPoint;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            OnTouchScreen();
        }
    }

    void OnTouchScreen()
    {
        // (스크린 좌표계)마우스 위치.
        // Camera.ScreenToWorldPoint : 스크린 좌표계를 월드 좌표계로 변환.
        //Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);


        // 메인 카메라가 비추는 마우스 포지션의 위치 -> 월드 좌표로 변경 후 레이로 반환.
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if(Physics.Raycast(ray, out hit, float.MaxValue, groundMask))
        {
            // 지형을 클릭했다.
            // hit.point는 출돌 지점 위치.
            OnClickPoint?.Invoke(hit.point);
        }
    }
}
