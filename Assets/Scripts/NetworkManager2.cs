using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkManager2 : MonoBehaviour
{
	public GameObject lobbyPanel;
	// Methode um Serververbindung zu starten
	public void Connect()
	{
		PhotonNetwork.ConnectUsingSettings("v01");
	}

	void Update()
	{
		// Ausgabe des aktuellen Serverstatus
		Debug.Log(PhotonNetwork.connectionStateDetailed.ToString());
	}

	void OnConnectedToMaster()
	{
		PhotonNetwork.JoinLobby();
	}

	void OnJoinedLobby()
	{
		// Lobby panel anzeigen
		lobbyPanel.SetActive(true);
	}

	public void ButtonJoinRoom()
	{
		// Raum betreten
		PhotonNetwork.JoinRandomRoom();
	}

	void OnPhotonRandomJoinFailed()
	{
		PhotonNetwork.CreateRoom("myRoom");
	}

	void OnJoinedRoom()
	{
		lobbyPanel.SetActive(false);

	}

	void Spawn()
	{
		if (PhotonNetwork.player.ID == 1)
		{
			PhotonNetwork.Instantiate("Player", Vector3.zero, Quaternion.identity, 0);
		}
		else
		{
			PhotonNetwork.Instantiate("Player", new Vector3(0, 2, 0), Quaternion.identity, 0);
		}

	}
}

