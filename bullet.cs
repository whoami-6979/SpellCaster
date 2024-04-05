using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float life = 1; //no of hit required to destroy the gameobject

    private void Awake()
    {
        Destroy(gameObject,life);
    }

    private void OnCollisionEnter(Collision collision)//On collision with other objects it gets destroyed
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }
}
