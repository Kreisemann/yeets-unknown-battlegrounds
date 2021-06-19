using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
  //Tags
    string weaponTag = "Weapon1";
    string weaponTag2 = "ShotGun";
    string weaponTag3 = "Sniper";
    string weaponTag4 = "AR";
    string weaponTag5 = "Bow";
    //Lables
    public GameObject Bowlbl;
    public GameObject ARlbl;
    public GameObject Sniperlbl;
    public GameObject ShotGunlbl;
    public GameObject Weapon1lbl;
   //Max Items
    public int maxWeapons = 2;
    //Cam
    public Transform cameraTransform;
    //Pick up key
    public KeyCode pickupKey = KeyCode.F;
    //range
    public float range = 50f;
    //Player
    public GameObject player;
    //Items
    public List<GameObject> weapons;

    // Update is called once per frame
    void Update()
    {
       
        
            RaycastHit hit;
            Ray ray = new Ray(cameraTransform.position, cameraTransform.forward);

            if (Physics.Raycast(ray, out hit, range))
            {
                if (hit.transform.CompareTag(weaponTag) && Input.GetKeyDown(pickupKey) && weapons.Count < maxWeapons)
                {
                    Weapon1lbl.SetActive(true); 
                   
                }
                if (hit.transform.CompareTag(weaponTag2) && Input.GetKeyDown(pickupKey) && weapons.Count < maxWeapons)
                {
                    ShotGunlbl.SetActive(true);

                }
                if (hit.transform.CompareTag(weaponTag3) && Input.GetKeyDown(pickupKey) && weapons.Count < maxWeapons)
                {
                    Sniperlbl.SetActive(true);

                }
                if (hit.transform.CompareTag(weaponTag4) && Input.GetKeyDown(pickupKey) && weapons.Count < maxWeapons)
                {
                    Bowlbl.SetActive(true);

                }
                if (hit.transform.CompareTag(weaponTag5) && Input.GetKeyDown(pickupKey) && weapons.Count < maxWeapons)
                {
                    ARlbl.SetActive(true);

                }
            }
        
    }
}
