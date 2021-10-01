using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{ 
    public GameObject projectil;
    public Transform aimDir;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void AimShooting()
    {
        float v = Input.GetAxis("Vertical");
        aimDir.Rotate(v*-1,0,0,Space.Self);
    }
     
    void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate()
        }
    }
    
}
