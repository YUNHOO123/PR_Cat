using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerSpawner : MonoBehaviourPun
{
    [SerializeField] Transform[] playerPos;    

    void Start()
    {
        //if (PhotonNetwork.IsMasterClient)
        //{
        //    for (int i = 0; i < PhotonNetwork.CurrentRoom.PlayerCount; i++)
        //    {
        //        PhotonNetwork.Instantiate("Player", playerPos[i].position, Quaternion.identity);
        //    }
        //}
        GameObject playerObj = PhotonNetwork.Instantiate("Player", transform.position, Quaternion.identity);
        GameManager.instance.playerList.Add(playerObj.GetComponent<Temp.TestPlayer>());
        // ���ӸŴ����� TestPlayer�� ���ӿ�����Ʈ ����Ʈ����� ������ �־ ����ش�.
    }
}
