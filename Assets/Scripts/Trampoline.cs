using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public float bounceforce = 5f;
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRigibody = collision.gameObject.GetComponent<Rigidbody>();
            if (playerRigibody != null )
            {
                playerRigibody.AddForce(Vector3.up * bounceforce, ForceMode.Impulse);
            }
        }


    }
}
