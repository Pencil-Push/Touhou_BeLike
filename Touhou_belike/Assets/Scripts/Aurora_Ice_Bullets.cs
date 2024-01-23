using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aurora_Ice_Bullets : MonoBehaviour
{
    public Transform icePoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // shooting logic
        Instantiate(bulletPrefab, icePoint.position, icePoint.rotation);
    }
}
