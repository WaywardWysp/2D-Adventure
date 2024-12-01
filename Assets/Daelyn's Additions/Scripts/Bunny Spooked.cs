using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnySpooked : MonoBehaviour
{
    Animator animator;

    void OnTriggerEnter2D(Collider2D other)
    {
        animator = GetComponent<Animator>();
        animator.SetTrigger("Spooked");
    }
}
