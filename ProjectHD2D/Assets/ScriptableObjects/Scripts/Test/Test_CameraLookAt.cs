using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_CameraLookAt : MonoBehaviour
{
    Camera curCam;

    bool switchCam = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.LookAt(Camera.main.transform);

        //Vector3 directionToCamera = cam.transform.position - transform.position;
        //directionToCamera.y = 0; // y 축은 고려하지 않음

        //// 방향 벡터를 바라보도록 회전값 계산
        //Quaternion targetRotation = Quaternion.LookRotation(cam.transform.x);

        //// x 축 회전값만 적용
        //transform.rotation = Quaternion.Euler(cam.transform.eulerAngles.x, 0, 0);
    }
}
