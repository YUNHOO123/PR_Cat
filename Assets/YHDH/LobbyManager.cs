using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class LobbyManager : MonoBehaviourPunCallbacks
{    
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
    
    public void JoinRoom()
    {
        Debug.Log("���η�");
        // ������ ����Ǿ��ִ��� Ȯ���ϰ�
        // �ȵǾ������� �ٽ� ������ �����ϴ� �۾�
        if (PhotonNetwork.IsConnected)
        {
            Debug.Log("������� �õ�");
            // ������ ����Ǿ������� �濡 ���ų�, ����� �۾�
            PhotonNetwork.JoinRandomRoom();
        }
        else
            PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("�� ����");
        //if(PhotonNetwork.IsMasterClient)
        //    PhotonNetwork.Instantiate("Bat", transform.position - new Vector3(0, 11, 0), transform.rotation);
        //PhotonNetwork.Instantiate("RagDollPlayer", transform.position, transform.rotation);
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
