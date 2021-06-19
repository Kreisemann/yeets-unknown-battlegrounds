using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxing : MonoBehaviour
{
    public GameObject fist;
    public Animator anim;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            fist.SetActive(true);
            Box();
        }
        else
        {
            fist.SetActive(false);
        }
    }
    void Box()
    {

    }
}
