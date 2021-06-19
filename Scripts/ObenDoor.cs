using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObenDoor : MonoBehaviour
{
    public Animator anim;
    void Start()
    {
        anim.SetFloat("Blend", 0);
    }
    
    void OnTriggerEnter(Collider collisionInfo)
    {
       if(collisionInfo.gameObject.tag == "Player")
        {
            StartCoroutine(OpenTheDoor());
        }
       
    }
   
    IEnumerator OpenTheDoor()
    {
        anim.SetFloat("Blend", 0.3f);
        yield return new WaitForSeconds(5);
        anim.SetFloat("Blend", 1);
    }
}
