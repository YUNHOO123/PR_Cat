using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneOP : MonoBehaviour
{
    public CinemachineVirtualCamera virtualCamera;
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("�浹");
        if( other.CompareTag("RollingStone"))
        {
            virtualCamera.enabled = false;
        }    
    }
}
