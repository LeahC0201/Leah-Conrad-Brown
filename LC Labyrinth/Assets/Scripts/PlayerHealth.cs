﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int currentPlayerHealth = 100;
    public int enemyDamage = 20;
    private Animator playerAnimator;
    public PlayerExplosionParticles particles;
   
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        particles = GetComponent<PlayerExplosionParticles>();
    }

    public void HurtPlayer()
    {
        currentPlayerHealth -= enemyDamage;
        playerAnimator.SetTrigger("Hit");

        if(currentPlayerHealth <= 0)
        {
            particles.Explode();
            Invoke("ReloadScene", 5);
        }
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene("CyberFu");
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "HitCollider")
        {
            HurtPlayer();
        }
    }
}
