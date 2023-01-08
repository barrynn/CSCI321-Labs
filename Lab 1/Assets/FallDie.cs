using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDie : MonoBehaviour
{
//checks if the player object triggered the event and if so it sets the boolean
//fell in the PlayerController script to true. In case the player fell during the
//moving platforms the player's parent is returned to null if the exit command of
//MovePlatform doesnt fire
    public PlayerController player;
    void OnTriggerEnter(Collider col){
	if(col.CompareTag("Player")){
		player.fell = true;
		player.transform.parent = null;
	}
    }
}
