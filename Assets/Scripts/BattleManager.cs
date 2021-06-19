using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    public float Players;
    public Text notStarted;
    public GameObject musicManager;
    public GameObject musicManager2;
    
    // Start is called before the first frame update
    void Start()
    {
        Players = PhotonNetwork.otherPlayers.Length + 1f;
    }

    // Update is called once per frame
    void Update()
    {
      if(Players <= 4 && Players > 1)
        {
            StartMatch();
        }
        else
        {
            musicManager.SetActive(true);
        }
    }

    void StartMatch()
    {
        notStarted.enabled = false;
        musicManager2.SetActive(true);

        if(Players == 1)
        {
           
        }
    }
}
