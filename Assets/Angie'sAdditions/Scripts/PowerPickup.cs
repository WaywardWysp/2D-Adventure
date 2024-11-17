using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A.O. ADDED for powerup candy!
public class PowerPickup : MonoBehaviour

{
    public AudioClip pickupClip;
    public ParticleSystem powerPickup;

    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();


        if (controller != null)
        {
            controller.speed = 6;
            controller.PlaySound(pickupClip);
            Instantiate(powerPickup, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }

}