using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
     private float damage = 1;
    

   private void OnTriggerEnter2D(Collider2D collision)
   {
        if(collision.tag == "Player" )
        {
            collision.GetComponent<Health>().TakeDamage(damage);
        }
   }

}
