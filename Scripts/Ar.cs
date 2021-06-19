using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ar : MonoBehaviour
{
    public float damage = 50f;
    public float range = 50f;
    public Camera cam;
    public GameObject impact;
    public float impactForce = 50f;
    public float fireRate = 11f;
    private float nextTimeToFire = 2f;
    public ParticleSystem muzzleFlash;
    public GameObject Hand;
    public Transform GunTip;
    public GameObject Shot;
    public GameObject Image;
    void Start()
    {
        muzzleFlash.Pause();
        impact.SetActive(false);

    }
    // Update is called once per frame
    void Update()
    {
        muzzleFlash.transform.position = GunTip.transform.position;
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire && transform.parent == Hand.transform)
        {
            nextTimeToFire = Time.time + 1.5f / fireRate;
            Shoot();
            Shot.GetComponent<AudioSource>().Play();
        }
        if(transform.parent == Hand.transform)
        {
            Image.SetActive(true);
        }

    }
    public void Shoot()
    {
        muzzleFlash.transform.rotation = cam.transform.rotation;
        muzzleFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
            impact.SetActive(true);
            GameObject Bulleteffekt = Instantiate(impact, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(Bulleteffekt, 1f);
        }
    }
}
