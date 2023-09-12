using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float moveSpd;

    
   
    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        //iM=GetComponent<InputManager>();
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveWASD();
    }
    void MoveWASD()
    {
        if (InputManager.GetInputMove() != Vector3.zero)
        {
            rigid.velocity =
                new Vector3(InputManager.GetInputMove().x * moveSpd,
                rigid.velocity.y,
                InputManager.GetInputMove().z * moveSpd);
        }
    }
}
