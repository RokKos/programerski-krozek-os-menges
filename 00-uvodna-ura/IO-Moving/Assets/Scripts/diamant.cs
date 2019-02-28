using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diamant : MonoBehaviour
{
    [SerializeField] ParticleSystem particleSystem;

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.tag == "Player") {
            particleSystem.Play();
        }
    }
}
