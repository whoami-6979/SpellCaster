using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Transform spellSpawnPoint; // Create a empty GameObject and add this script to it.
    public GameObject spellPrefab; // The prebab required to act as the spell
    //RigidBody is required in the prefab to move forward
    public float spellSpeed = 10; // the speed 

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))//key to trigger the spell
        { 
        var spell = Instantiate(spellPrefab, spellSpawnPoint.position, spellSpawnPoint.rotation); // innititate the spell and make it move forward.
        spell.GetComponent<Rigidbody>().velocity = spellSpawnPoint.forward * spellSpeed;
        }
    }
}
