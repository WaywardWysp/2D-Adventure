using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    //D.W. Added for Robot Fix Sound FX
    public AudioClip collectedClip;

    //Audio Source Collection
    AudioSource audioSource;


    // Awake is called when the Projectile GameObject is instantiated
    void Awake()
    {

        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        if (transform.position.magnitude > 100.0f)
        {
            Destroy(gameObject);
        }
    }



    public void Launch(Vector2 direction, float force)
    {
        rigidbody2d.AddForce(direction * force);

    }


    void OnCollisionEnter2D(Collision2D other)
    {
        EnemyController enemy = other.collider.GetComponent<EnemyController>();
  
        if (enemy != null)
        {
            enemy.Fix();
            enemy.PlaySound(collectedClip);
        }

        Destroy(gameObject);
    }

}

