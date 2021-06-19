using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NetworkManager : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject InGameUI;
    public GameObject Cam;
    public TextMeshProUGUI playerCount;
    public float prozent;

    // Update is called once per frame
    void Update()
    {
        playerCount.text = ("Players: " + PhotonNetwork.otherPlayers.Length);
    }
    public void Connect()
    {
        Debug.Log("Connection is set up");
        PhotonNetwork.ConnectUsingSettings("v01");
    }
    void Spawn()
    {
        PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity, 0);
    }
    void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master Server");
        PhotonNetwork.JoinLobby();
    }
    void OnJoinedLobby()
    {
        MainMenu.SetActive(false);
        Cam.SetActive(false);
        InGameUI.SetActive(true);
        PhotonNetwork.JoinRandomRoom();
        
    }
    void OnPhotonRandomJoinFailed()
    {
        PhotonNetwork.CreateRoom(null);
    }
    void OnJoinedRoom()
    {
        
        Spawn();
        
    }
}
