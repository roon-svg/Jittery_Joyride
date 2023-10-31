using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Addhealth : MonoBehaviour

{
    PlayerHealth playerHealth;

    public int addHealth = 1;

     void Awake()
    {
        playerHealth = FindAnyObjectByType<PlayerHealth>();

    }
     void OnTriggerEnter2D(Collider2D collision)
    {
      if(playerHealth.health < playerHealth.maxHealth)
        {
            Destroy(gameObject);
            playerHealth.health = playerHealth.health + addHealth;
        }
    }

}
