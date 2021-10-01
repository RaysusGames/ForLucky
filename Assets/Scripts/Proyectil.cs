using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class Proyectil : MonoBehaviour
{
    public float initialVelocity = 10;
    
public void ShootTo(Vector3 Direction)
    {
        GetComponent<Rigidbody>().AddForce(Direction * initialVelocity,ForceMode.Impulse);
    }


    public void ShootWitchForce(Vector3 Direction , float force)
    {
        GetComponent<Rigidbody>().AddForce(Direction*force,ForceMode.Impulse);
    }

    IEnumerator RestoreCollision()
    {
        yield return new WaitForSeconds(0.1f);
        GetComponent<Collider>().isTrigger = false;
    }
}
