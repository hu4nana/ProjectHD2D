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
        //directionToCamera.y = 0; // y ���� ������� ����

        //// ���� ���͸� �ٶ󺸵��� ȸ���� ���
        //Quaternion targetRotation = Quaternion.LookRotation(cam.transform.x);

        //// x �� ȸ������ ����
        //transform.rotation = Quaternion.Euler(cam.transform.eulerAngles.x, 0, 0);
    }
}
