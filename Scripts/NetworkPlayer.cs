using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NetworkPlayer : Photon.MonoBehaviour
{
    public GameObject cam;
    public GameObject sceneCam;
    // Start is called before the first frame update
    void Start()
    {
        if (photonView.isMine)
        {
            cam.SetActive(true);
            GetComponent<PlayerMovement>().enabled = true;
            sceneCam.SetActive(false);
            GetComponent<Target>().enabled = true;

            
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
