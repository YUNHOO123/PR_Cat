using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    public static int roomNumber = 1;
    void Start()
    {
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("������ ����");        
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("������ ����");
    }

    //������������ �濡�� ���� �ȵ�.

    public void JoinRoom()
    {
        Debug.Log("���η�");
        // ������ ����Ǿ��ִ��� Ȯ���ϰ�
        // �ȵǾ������� �ٽ� ������ �����ϴ� �۾�
        if (PhotonNetwork.IsConnected)
        {
            // ������ ����Ǿ������� �濡 ���ų�, ����� �۾�
            // �õ��� ���� �̹� �������̸� ����ó��                 
            PhotonNetwork.JoinRandomRoom();
            //if (!PhotonNetwork.CurrentRoom.IsOpen)
            //{
            //    PhotonNetwork.LeaveRoom();
            //    CreateRoom();
            //}
        }
        else
            PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnLeftRoom()
    {
        Debug.Log("�� ������");
    }
    public override void OnJoinedRoom()
    {
        Debug.Log("�� ����");
        //if(PhotonNetwork.IsMasterClient)
        //    PhotonNetwork.Instantiate("Bat", transform.position - new Vector3(0, 11, 0), transform.rotation);
        //PhotonNetwork.Instantiate("RagDollPlayer", transform.position, transform.rotation);
        if (!PhotonNetwork.CurrentRoom.IsOpen)
        {
            PhotonNetwork.LeaveRoom();
            PhotonNetwork.LoadLevel(0);
        }
        else
            PhotonNetwork.LoadLevel(1);
        
        //photonView.RPC("OnGameRoom", RpcTarget.AllBuffered);
        // �����Ͱ� �游���
        // ��� ������ ��ȯ �ȴ�
        // 
    }

    public override void OnJoinRandomFailed(short returnCode, string message)
    {
        Debug.Log("�������");
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 5;
        PhotonNetwork.CreateRoom("1���� ����", roomOptions);
    }
}
