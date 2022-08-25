using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    public float currentHealth { get; private set;}
    private Animator anim;
    private bool dead;


    private void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();

    }

    public void TakeDamage(float _damage)
    {
        currentHealth -= _damage;

        if (currentHealth > 0)
        {
            
            anim.SetTrigger("die");
            GetComponent<PlayerMovement>().enabled = false;
            dead = true;
            
        }
    }


    public void AddHealth(float _value)
    {

    }


    public void Respawn()
    {
      dead = false;  
      AddHealth(startingHealth);
      anim.ResetTrigger("die");
      anim.Play("Idle");   

    }
}
