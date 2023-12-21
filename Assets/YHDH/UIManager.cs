using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    PhotonView pv;

    private void Start()
    {
        pv = GetComponent<PhotonView>(); 
    }
    public void EnterBlackHole()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            pv.RPC("BlackHole", RpcTarget.AllBuffered);
        }

        else
        {
            Debug.Log("�����Ͱ� �ƴ�");
        }
    }

    public void EnterDoll()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            pv.RPC("Doll", RpcTarget.AllBuffered);
        }

        else
        {
            Debug.Log("�����Ͱ� �ƴ�");
        }
    }

    public void EnterMonster()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            pv.RPC("Monster", RpcTarget.AllBuffered);
        }

        else
        {
            Debug.Log("�����Ͱ� �ƴ�");
        }
    }

    [PunRPC]
    public void BlackHole()
    {
        PhotonNetwork.LoadLevel(2);
    }

    [PunRPC]
    public void Doll()
    {
        PhotonNetwork.LoadLevel(3);
    }

    [PunRPC]
    public void Monster()
    {
        PhotonNetwork.LoadLevel(4);
    }

}

