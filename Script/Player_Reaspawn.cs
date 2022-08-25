using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Reaspawn : MonoBehaviour
{
    [SerializeField] private AudioClip checkpointSound; // Sound of the checkpoint.
    private Transform currentCheckpoint; // Storage of the last checkpoint
    private Health playerHealth;


    private void Awake()
    {
        playerHealth = GetComponent<Health>();
    
    }


    public void Respawn()
    {
        transform.position = currentCheckpoint.position; //move player to checkpoint position
        playerHealth.Respawn();

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Checkpoint")
        {
            currentCheckpoint = collision.transform;
            //SoundManager.instance.PlaySound(checkpointSound);
            collision.GetComponent<Collider2D>().enabled = false;
        }
    }

}
